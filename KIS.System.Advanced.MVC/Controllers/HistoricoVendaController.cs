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
    public class HistoricoVendaController : CustomControllerBase<HistoricoVM>
    {
        #region PROPRIEDADES / CONSTRUTOR

        private readonly IVendedorService _vendedorService;
        public HistoricoVendaController(IVendedorService vendedorService)
        {
            _vendedorService = vendedorService;
        }

        #endregion

        public ActionResult Index()
        {
            HistoricoVM model = CarregarModel();
            return View(model);
        }

        [CustomAuthorize(IsPermission = AcessRole.ADMIN | AcessRole.VENDAS)]
        public PartialViewResult AddOrEdit(int id)
        {
            var result = new UsuarioVM();
            return PartialView(result);
        }

        private HistoricoVM CarregarModel()
        {
            var model = new HistoricoVM();
            var vendedores = _vendedorService.GetAll();
            var vendedoresVM = AutoMapper.Mapper.Map<List<VendedorVM>>(vendedores);
            model.Vendedores = vendedoresVM;
            return model;
        }

    }
}