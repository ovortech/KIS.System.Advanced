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

        private readonly IClienteService _clienteService;
        private readonly IProdutoService _produtoService;
        private readonly ITipoPagamentoService _tipoPagamentoService;
        private readonly IVendedorService _vendedorService;
        public VendasController(IClienteService clienteService, 
                                IProdutoService produtoService, 
                                ITipoPagamentoService tipoPagamentoService, 
                                IVendedorService vendedorService)
        {
            _clienteService = clienteService;
            _produtoService = produtoService;
            _tipoPagamentoService = tipoPagamentoService;
            _vendedorService = vendedorService;
        }
        
        #endregion

        [CustomAuthorize(IsPermission = AcessRole.ADMIN | AcessRole.VENDAS)]
        public ActionResult Index()
        {
            var pedido = CarregarModel();
            return View(pedido);
        }

        [CustomAuthorize(IsPermission = AcessRole.ADMIN | AcessRole.VENDAS)]
        public PartialViewResult AddOrEdit(int id)
        {
            var result = new VendasVM();
            return PartialView(result);
        }
        
        public VendasVM CarregarModel()
        {
            var pedido = new VendasVM();

            var clientes = _clienteService.GetAllActive();
            var clientesVM = AutoMapper.Mapper.Map<List<ClienteVM>>(clientes);
            pedido.Clientes = clientesVM;

            var produtos = _produtoService.GetAllActive();
            var produtosVM = AutoMapper.Mapper.Map<List<ProdutoVM>>(produtos);
            pedido.Produtos = produtosVM;

            var tiposPagamento = _tipoPagamentoService.GetAllActive();
            var tiposPagamentoVM = AutoMapper.Mapper.Map<List<TipoPGVM>>(tiposPagamento);
            pedido.TipoPGs = tiposPagamentoVM;

            var vendedores = _vendedorService.GetAllActive();
            var vendedoresVM = AutoMapper.Mapper.Map<List<VendedorVM>>(vendedores);
            pedido.Vendedores = vendedoresVM;

            return pedido;
        }
    }
}