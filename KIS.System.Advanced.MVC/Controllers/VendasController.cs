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
    public class VendasController : CustomControllerBase<VendasVM>
    {
        #region PROPRIEDADES / CONSTRUTOR

        private readonly IClienteService _clienteService;
        private readonly IProdutoService _produtoService;
        private readonly ITipoPagamentoService _tipoPagamentoService;
        private readonly IVendedorService _vendedorService;
        private readonly IPedidoService _pedidoService;
        public VendasController(IClienteService clienteService,
                                IProdutoService produtoService,
                                ITipoPagamentoService tipoPagamentoService,
                                IVendedorService vendedorService,
                                IPedidoService pedidoService)
        {
            _clienteService = clienteService;
            _produtoService = produtoService;
            _tipoPagamentoService = tipoPagamentoService;
            _vendedorService = vendedorService;
            _pedidoService = pedidoService;
        }

        #endregion

        [CustomAuthorize(IsPermission = AcessRole.ADMIN | AcessRole.VENDAS)]
        public ActionResult Index()
        {
            var venda = LoadModel();
            return View(venda);
        }

        [CustomAuthorize(IsPermission = AcessRole.ADMIN | AcessRole.VENDAS)]
        public ActionResult Edit(int id)
        {
            var venda = LoadModel();
            return View("Index", venda);
        }

        [CustomAuthorize(IsPermission = AcessRole.ADMIN | AcessRole.VENDAS)]
        public PartialViewResult AddOrEdit(int id)
        {
            var result = new VendasVM();
            return PartialView(result);
        }

        [HttpPost]
        [CustomAuthorize(IsPermission = AcessRole.ADMIN | AcessRole.VENDAS)]
        public void SaveNewOrder(VendasVM venda)
        {
            try
            {
                var pedido = AutoMapper.Mapper.Map<Pedido>(venda);
                pedido.ID_USUARIO_PEDIDO = SessionPersister.User.IdUsuario;
                var itensPedido = AutoMapper.Mapper.Map<List<ItemPedido>>(venda.ItemPedidosVM);
                var formasPagamento = AutoMapper.Mapper.Map<List<FormaPg>>(venda.FormaPGs);

                _pedidoService.SaveNewOrder(pedido, itensPedido, formasPagamento);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao salvar pedido: {ex.Message}");
            }
        }

        private VendasVM LoadModel()
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