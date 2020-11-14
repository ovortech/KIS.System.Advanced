using AutoMapper;
using KIS.System.Advanced.MVC.ViewModels;
using System.Web.UI.WebControls;
using KIS.System.Advanced.Domain.Entities;
using System;
using KIS.System.Advanced.Domain.Enums;
using KIS.System.Advanced.Domain.Dto;

namespace KIS.System.Advanced.MVC.Support
{
    public sealed class AutoMapperHelper
    {
        private static volatile AutoMapperHelper _instance;
        private static object syncRoot = new object();

        public AutoMapperHelper()
        {
            InitiazeMapper();
        }

        public static void Instance()
        {
            if (_instance == null)
            {
                lock (syncRoot)
                {
                    if (_instance == null)
                        _instance = new AutoMapperHelper();
                }
            }
        }

        public void InitiazeMapper()
        {
            Mapper.Initialize(cfg =>
            {
                MappingModel(cfg);
            });
        }

        private static void MappingModel(IMapperConfigurationExpression cfg)
        {
            cfg.ValidateInlineMaps = false;

            MappingUsuario(cfg);
            MappingUsuarioVM(cfg);
            MappingProduto(cfg);
            MappingVendedor(cfg);
            MappingTipoPagamento(cfg);
            MappingClientes(cfg);
            MappingComissao(cfg);
            MappingVendas(cfg);
            MappingItemPedido(cfg);
            MappingFormasPagamento(cfg);
        }

        private static void MappingComissao(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<ComissaoVM, Comissao>()
                .ForMember(destinationMember: vm => vm.ID_COMISSAO, memberOptions: map => map.MapFrom(sourceMember: s => s.IdComissao))
                .ForMember(destinationMember: vm => vm.ID_ITEM_PEDIDO, memberOptions: map => map.MapFrom(sourceMember: s => s.IdItemPedido))
                .ForMember(destinationMember: vm => vm.VALOR_CUSTO_COMISSAO, memberOptions: map => map.MapFrom(sourceMember: s => s.ValorCustoUnitario))
                .ForMember(destinationMember: vm => vm.VALOR_LUCRO_COMISSAO, memberOptions: map => map.MapFrom(sourceMember: s => s.ValorLucro))
                .ForMember(destinationMember: vm => vm.PERCENTUAL_COMISSAO, memberOptions: map => map.MapFrom(sourceMember: s => s.PercComissao))
                .ForMember(destinationMember: vm => vm.PAGO_COMISSAO, memberOptions: map => map.MapFrom(sourceMember: s => s.Pago))
                .ForMember(destinationMember: vm => vm.ATIVO, memberOptions: map => map.MapFrom(sourceMember: s => s.Ativo))
                .ForMember(destinationMember: vm => vm.DATA_PAGAMENTO_COMISSAO, memberOptions: map => map.MapFrom(sourceMember: s => s.DataVenda))
                ;

            cfg.CreateMap<ComissaoDto, ComissaoVM>()
                ;
        }

        private static void MappingVendas(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<VendasVM, Pedido>()
               .ForMember(destinationMember: vm => vm.ID_PEDIDO, memberOptions: map => map.MapFrom(sourceMember: s => s.IdPedido))
               .ForMember(destinationMember: vm => vm.ID_CLIENTE, memberOptions: map => map.MapFrom(sourceMember: s => s.IdCliente))
               .ForMember(destinationMember: vm => vm.ID_VENDEDOR, memberOptions: map => map.MapFrom(sourceMember: s => s.IdVendedor))
               .ForMember(destinationMember: vm => vm.OBS_PEDIDO, memberOptions: map => map.MapFrom(sourceMember: s => s.Observacao));

            cfg.CreateMap<Pedido, VendasVM>()
                .ForMember(destinationMember: vm => vm.IdPedido, memberOptions: map => map.MapFrom(sourceMember: s => s.ID_PEDIDO))
               .ForMember(destinationMember: vm => vm.IdCliente, memberOptions: map => map.MapFrom(sourceMember: s => s.ID_CLIENTE))
               .ForMember(destinationMember: vm => vm.IdVendedor, memberOptions: map => map.MapFrom(sourceMember: s => s.ID_VENDEDOR))
               .ForMember(destinationMember: vm => vm.Observacao, memberOptions: map => map.MapFrom(sourceMember: s => s.OBS_PEDIDO));
        }

        private static void MappingItemPedido(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<ItemPedidoVM, ItemPedido>()
               .ForMember(destinationMember: vm => vm.VALOR_UN_PEDIDO, memberOptions: map => map.MapFrom(sourceMember: s => s.ValorUnitario))
               .ForMember(destinationMember: vm => vm.ID_PRODUTO, memberOptions: map => map.MapFrom(sourceMember: s => s.IdProduto))
               .ForMember(destinationMember: vm => vm.OBS_PRODUTO, memberOptions: map => map.MapFrom(sourceMember: s => s.Observacao))
               .ForMember(destinationMember: vm => vm.DESCONTO_PEDIDO, memberOptions: map => map.MapFrom(sourceMember: s => s.Desconto))
               .ForMember(destinationMember: vm => vm.QTD_PEDIDO, memberOptions: map => map.MapFrom(sourceMember: s => s.Quantidade));

            cfg.CreateMap<ItemPedido, ItemPedidoVM>()
               .ForMember(destinationMember: vm => vm.ValorUnitario, memberOptions: map => map.MapFrom(sourceMember: s => s.VALOR_UN_PEDIDO))
               .ForMember(destinationMember: vm => vm.IdProduto, memberOptions: map => map.MapFrom(sourceMember: s => s.ID_PRODUTO))
               .ForMember(destinationMember: vm => vm.Observacao, memberOptions: map => map.MapFrom(sourceMember: s => s.OBS_PRODUTO))
               .ForMember(destinationMember: vm => vm.Desconto, memberOptions: map => map.MapFrom(sourceMember: s => s.DESCONTO_PEDIDO))
               .ForMember(destinationMember: vm => vm.Quantidade, memberOptions: map => map.MapFrom(sourceMember: s => s.QTD_PEDIDO));
        }

        private static void MappingFormasPagamento(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<FormaPGVM, FormaPg>()
               .ForMember(destinationMember: vm => vm.VALOR_FORM_PG, memberOptions: map => map.MapFrom(sourceMember: s => s.ValorPG))
               .ForPath(destinationMember: vm => vm.ID_TIPO_PG, memberOptions: map => map.MapFrom(sourceMember: s => s.TipoPGVM.Id));


            cfg.CreateMap<FormaPg, FormaPGVM>()
               .ForMember(destinationMember: vm => vm.ValorPG, memberOptions: map => map.MapFrom(sourceMember: s => s.VALOR_FORM_PG))
               .ForPath(destinationMember: vm => vm.TipoPGVM.Id, memberOptions: map => map.MapFrom(sourceMember: s => s.ID_TIPO_PG));
        }

        private static void MappingVendedor(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<VendedorVM, Vendedor>()
               .ForMember(destinationMember: vm => vm.ID_VENDEDOR, memberOptions: map => map.MapFrom(sourceMember: s => s.Id))
               .ForMember(destinationMember: vm => vm.NOME_VENDEDOR, memberOptions: map => map.MapFrom(sourceMember: s => s.Nome));

            cfg.CreateMap<Vendedor, VendedorVM>()
              .ForMember(destinationMember: vm => vm.Id, memberOptions: map => map.MapFrom(sourceMember: s => s.ID_VENDEDOR))
              .ForMember(destinationMember: vm => vm.Nome, memberOptions: map => map.MapFrom(sourceMember: s => s.NOME_VENDEDOR));
        }

        private static void MappingUsuarioVM(IMapperConfigurationExpression cfg)
        {

            cfg.CreateMap<UsuarioVM, Usuario>()
                .ForMember(destinationMember: vm => vm.ID_USUARIO, memberOptions: map => map.MapFrom(sourceMember: s => s.IdUsuario))
                .ForMember(destinationMember: vm => vm.LOGIN_USUARIO, memberOptions: map => map.MapFrom(sourceMember: s => s.Login))
                //.ForMember(destinationMember: vm => vm.SENHA_USUARIO, memberOptions: map => map.MapFrom(sourceMember: s => s.Senha))
                .ForMember(destinationMember: vm => vm.NOME_USUARIO, memberOptions: map => map.MapFrom(sourceMember: s => s.Nome))
                .ForMember(destinationMember: vm => (TipoAcessoEnum)vm.ID_TIPO_ACESSO_USUARIO, memberOptions: map => map.MapFrom(sourceMember: s => s.TipoAcessos))
                .ForMember(destinationMember: vm => vm.ID_FUNCAO_USUARIO, memberOptions: map => map.MapFrom(sourceMember: s => s.Funcao))
                .ForMember(destinationMember: vm => vm.EMAIL_USUARIO, memberOptions: map => map.MapFrom(sourceMember: s => s.Email));

            cfg.CreateMap<Usuario, UsuarioVM>()
                .ForMember(destinationMember: vm => vm.IdUsuario, memberOptions: map => map.MapFrom(sourceMember: s => s.ID_USUARIO))
                .ForMember(destinationMember: vm => vm.Login, memberOptions: map => map.MapFrom(sourceMember: s => s.LOGIN_USUARIO))
                //.ForMember(destinationMember: vm => vm.Senha, memberOptions: map => map.MapFrom(sourceMember: s => s.SENHA_USUARIO))
                .ForMember(destinationMember: vm => vm.Nome, memberOptions: map => map.MapFrom(sourceMember: s => s.NOME_USUARIO))
                .ForMember(destinationMember: vm => vm.TipoAcessos, memberOptions: map => map.MapFrom(sourceMember: s => (TipoAcessoEnum)s.ID_TIPO_ACESSO_USUARIO))
                .ForMember(destinationMember: vm => vm.Funcao, memberOptions: map => map.MapFrom(sourceMember: s => s.ID_FUNCAO_USUARIO))
                .ForMember(destinationMember: vm => vm.Email, memberOptions: map => map.MapFrom(sourceMember: s => s.EMAIL_USUARIO));
        }

        private static void MappingUsuario(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<LoginVM, Usuario>()
               .ForMember(destinationMember: vm => vm.LOGIN_USUARIO, memberOptions: map => map.MapFrom(sourceMember: s => s.UserName))
               .ForMember(destinationMember: vm => vm.SENHA_USUARIO, memberOptions: map => map.MapFrom(sourceMember: s => s.Password));

            cfg.CreateMap<Usuario, LoginVM>()
               .ForMember(destinationMember: vm => vm.UserName, memberOptions: map => map.MapFrom(sourceMember: s => s.LOGIN_USUARIO))
               .ForMember(destinationMember: vm => vm.Password, memberOptions: map => map.MapFrom(sourceMember: s => s.SENHA_USUARIO));
        }

        private static void MappingProduto(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<ProdutoVM, Produto>()
               .ForMember(destinationMember: vm => vm.ID_PRODUTO, memberOptions: map => map.MapFrom(sourceMember: s => s.IdProduto))
               .ForMember(destinationMember: vm => vm.CODIGO_PRODUTO, memberOptions: map => map.MapFrom(sourceMember: s => s.CodProduto))
               .ForMember(destinationMember: vm => vm.SERVICO_PRODUTO, memberOptions: map => map.MapFrom(sourceMember: s => s.IsServico))
               .ForMember(destinationMember: vm => vm.NOME_PRODUTO, memberOptions: map => map.MapFrom(sourceMember: s => s.NomeProduto))
               .ForMember(destinationMember: vm => vm.VALOR_PRODUTO, memberOptions: map => map.MapFrom(sourceMember: s => s.ValorProduto));

            cfg.CreateMap<Produto, ProdutoVM>()
               .ForMember(destinationMember: vm => vm.IdProduto, memberOptions: map => map.MapFrom(sourceMember: s => s.ID_PRODUTO))
               .ForMember(destinationMember: vm => vm.CodProduto, memberOptions: map => map.MapFrom(sourceMember: s => s.CODIGO_PRODUTO))
               .ForMember(destinationMember: vm => vm.IsServico, memberOptions: map => map.MapFrom(sourceMember: s => s.SERVICO_PRODUTO))
               .ForMember(destinationMember: vm => vm.NomeProduto, memberOptions: map => map.MapFrom(sourceMember: s => s.NOME_PRODUTO))
               .ForMember(destinationMember: vm => vm.ValorProduto, memberOptions: map => map.MapFrom(sourceMember: s => s.VALOR_PRODUTO));
        }

        private static void MappingTipoPagamento(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<TipoPGVM, TipoPg>()
                .ForMember(destinationMember: vm => vm.ID_TIPO_PG, memberOptions: map => map.MapFrom(sourceMember: s => s.Id))
                .ForMember(destinationMember: vm => vm.NOME_PG, memberOptions: map => map.MapFrom(sourceMember: s => s.Nome));

            cfg.CreateMap<TipoPg, TipoPGVM>()
                .ForMember(destinationMember: vm => vm.Id, memberOptions: map => map.MapFrom(sourceMember: s => s.ID_TIPO_PG))
                .ForMember(destinationMember: vm => vm.Nome, memberOptions: map => map.MapFrom(sourceMember: s => s.NOME_PG));
        }

        private static void MappingClientes(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<ClienteVM, Cliente>()
                .ForMember(destinationMember: vm => vm.ID_CLIENTE, memberOptions: map => map.MapFrom(sourceMember: s => s.Id))
                .ForMember(destinationMember: vm => vm.NOME_CLIENTE, memberOptions: map => map.MapFrom(sourceMember: s => s.Nome));

            cfg.CreateMap<Cliente, ClienteVM>()
                .ForMember(destinationMember: vm => vm.Id, memberOptions: map => map.MapFrom(sourceMember: s => s.ID_CLIENTE))
                .ForMember(destinationMember: vm => vm.Nome, memberOptions: map => map.MapFrom(sourceMember: s => s.NOME_CLIENTE));
        }

        //clientes
    }
}