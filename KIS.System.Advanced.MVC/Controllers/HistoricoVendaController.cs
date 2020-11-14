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
    public class HistoricoVendaController : CustomControllerBase<HistoricoVendaVM>
    {
        #region PROPRIEDADES / CONSTRUTOR

        private readonly IVendedorService _vendedorService;
        private readonly IHistoricoVendaService _historicoVendaService;
        public HistoricoVendaController(IVendedorService vendedorService, IHistoricoVendaService historicoVendaService)
        {
            _vendedorService = vendedorService;
            _historicoVendaService = historicoVendaService;
        }

        #endregion

        public ActionResult Index()
        {
            HistoricoVendaVM model = CarregarModel();
            return View(model);
        }


        [CustomAuthorize(IsPermission = AcessRole.ADMIN | AcessRole.VENDAS)]
        [HttpPost]
        public PartialViewResult Grid(int idVendedor, DateTime dataInicio, DateTime dataFim)
        {
            List<GridHistoricoVendaVM> grid = new List<GridHistoricoVendaVM>();
            if (idVendedor != 0)
            {
                grid = AutoMapper.Mapper.Map<List<GridHistoricoVendaVM>>(_historicoVendaService.HistoricoVendaDto(idVendedor, dataInicio, dataFim));
            }
            return PartialView(grid);
        }

        [CustomAuthorize(IsPermission = AcessRole.ADMIN | AcessRole.VENDAS)]
        [HttpPost]
        public PartialViewResult Detalhes(int IdPedido)
        {
            List<DetailPedidoVM> ItensPedido = new List<DetailPedidoVM>();
            if (IdPedido != 0)
            {
                ItensPedido = AutoMapper.Mapper.Map<List<DetailPedidoVM>>(_historicoVendaService.HistoricoVendaDetalheDto(IdPedido));
            }
            return PartialView(ItensPedido);
        }

        [CustomAuthorize(IsPermission = AcessRole.ADMIN | AcessRole.VENDAS)]
        [HttpPost]
        public ActionResult Cencelar(int IdPedido)
        {

            return View();
        }


        private HistoricoVendaVM CarregarModel()
        {
            var model = new HistoricoVendaVM();
            var vendedores = _vendedorService.GetAll();
            var vendedoresVM = AutoMapper.Mapper.Map<List<VendedorVM>>(vendedores);
            model.Vendedores = vendedoresVM;
            return model;
        }

    }
}