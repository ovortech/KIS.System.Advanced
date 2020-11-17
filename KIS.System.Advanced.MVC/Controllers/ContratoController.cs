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
    public class ContratoController : CustomControllerBase<ContratoVM>
    {
        #region Construtor e propriedades
        IContratoService _contratoService;
        IClienteService _clienteService;
        IPedidoService _pedidoService;
        public ContratoController(IContratoService contratoService, IClienteService clienteService, IPedidoService pedidoService)
        {
            _contratoService = contratoService;
            _clienteService = clienteService;
            _pedidoService = pedidoService;
        }

        #endregion

        // GET: Contrato
        [CustomAuthorize(IsPermission = Support.AcessRole.ADMIN)]
        public ActionResult Index()
        {
            ContratoVM model = CarregarModel();

            return View(model);
        }


        [CustomAuthorize(IsPermission = AcessRole.ADMIN)]
        [HttpPost]
        public PartialViewResult Detalhes(int IdPedido)
        {
            List<DetailPedidoVM> ItensPedido = new List<DetailPedidoVM>();
            if (IdPedido != 0)
            {
                ItensPedido = AutoMapper.Mapper.Map<List<DetailPedidoVM>>(_pedidoService.DetalhePedidoDto(IdPedido));
            }
            return PartialView(ItensPedido);
        }

        [CustomAuthorize(IsPermission = AcessRole.ADMIN)]
        [HttpPost]
        public PartialViewResult Grid(int idCliente, String dataInicio, String dataFim)
        {
            DateTime dtInicio = dataInicio.ParseDateTimeBrToUs();
            DateTime dtFim = dataFim.ParseDateTimeBrToUs();
            List<GridContratoVM> grid = new List<GridContratoVM>();

            if (idCliente != 0)
                grid = AutoMapper.Mapper.Map<List<GridContratoVM>>(_contratoService.GetContratoDto(idCliente, dtInicio, dtFim));

            return PartialView(grid);
        }

        private ContratoVM CarregarModel()
        {
            var model = new ContratoVM();
            var clientes = _clienteService.GetAllActive();
            var clienteVMs = AutoMapper.Mapper.Map<List<ClienteVM>>(clientes);
            model.Clientes = clienteVMs;
            return model;
        }


    }
}