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
    public class VendasController : CustomControllerBase<VendasVM>
    {
        #region PROPRIEDADES / CONSTRUTOR

        private readonly IPedidoService _pedidoService;
        public VendasController(IPedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }
        
        #endregion

        // GET: Vendas
        [CustomAuthorize(IsPermission = AcessRole.ADMIN | AcessRole.VENDAS)]
        public ActionResult Index()
        {
            return View();
        }

        [CustomAuthorize(IsPermission = AcessRole.ADMIN | AcessRole.VENDAS)]
        public PartialViewResult AddOrEdit(int id)
        {
            var result = new VendasVM();
            return PartialView(result);
        }
        
        [HttpGet]
        [CustomAuthorize(IsPermission = AcessRole.ADMIN | AcessRole.VENDAS)]
        public int GetNextOrderNumber()
        {
            return _pedidoService.GetNextOrderNumber();
        }

    }
}