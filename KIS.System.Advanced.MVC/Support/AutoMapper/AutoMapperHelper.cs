using AutoMapper;
using KIS.System.Advanced.MVC.ViewModels;
using System.Web.UI.WebControls;
using KIS.System.Advanced.Domain.Entities;
using System;

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
            MappingUsuario(cfg);
            MappingProduto(cfg);
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
    }
}