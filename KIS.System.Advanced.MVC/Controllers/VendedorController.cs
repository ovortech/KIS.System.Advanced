using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.MVC.Support;
using KIS.System.Advanced.MVC.Support.Security;
using KIS.System.Advanced.MVC.ViewModels;
using KIS.System.Advanced.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KIS.System.Advanced.MVC.Controllers
{
    public class VendedorController : CustomControllerBase<VendedorVM>
    {
        #region PROPRIEDADES / CONTRUTOR
        private static List<VendedorVM> vendedorVMs;
        private IVendedorService _vendedorService;
        public static List<VendedorVM> vendedores
        {
            get { return vendedorVMs; }
            set { vendedorVMs = value; }
        }
        public VendedorController(IVendedorService vendedorService)
        {
            _vendedorService = vendedorService;
        }

        #endregion
        // GET: Vendedor                
        [CustomAuthorize(IsPermission = AcessRole.ADMIN | AcessRole.VENDAS)]
        public ActionResult Index()
        {
            var vendedores = _vendedorService.GetAll();
            var vendedoresVM = AutoMapper.Mapper.Map<List<VendedorVM>>(vendedores);
            return View(vendedoresVM);
        }

        [CustomAuthorize(IsPermission = AcessRole.ADMIN | AcessRole.VENDAS)]
        public JsonResult Get(int id)
        {
            var vendedor = _vendedorService.Get(id);
            var vendedorVM = AutoMapper.Mapper.Map<VendedorVM>(vendedor);
            return Json(vendedorVM, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [CustomAuthorize(IsPermission = AcessRole.ADMIN | AcessRole.VENDAS)]
        public ActionResult Save(VendedorVM vendedorVM)
        {
            try
            {
                var vendedor = AutoMapper.Mapper.Map<Vendedor>(vendedorVM);
                if (vendedor.ID_VENDEDOR > 0)
                    _vendedorService.Update(vendedor);
                else
                    _vendedorService.Save(vendedor);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                throw;
            }
        }

        [CustomAuthorize(IsPermission = AcessRole.ADMIN | AcessRole.VENDAS)]
        public PartialViewResult AddOrEdit(int id)
        {
            var result = new VendedorVM();
            return PartialView(result);
        }

        [HttpPost]
        //[CustomAuthorize(IsPermission = AcessRole.ADMIN | AcessRole.VENDAS)]
        [CustomAuthorize(IsPermission = AcessRole.ADMIN | AcessRole.VENDAS)]
        public ActionResult Delete(int id)
        {
            try
            {
                _vendedorService.Delete(id);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}