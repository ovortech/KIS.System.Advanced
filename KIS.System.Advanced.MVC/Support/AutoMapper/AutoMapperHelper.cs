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
            //get
            //{
                if (_instance == null)
                {
                    lock (syncRoot)
                    {
                        if (_instance == null)
                            _instance = new AutoMapperHelper();
                    }
                }
            //    return _instance;
            //}
        }

        public void InitiazeMapper()
        {
            Mapper.Initialize(cfg =>
            {
                MappingUsuario(cfg);
            });
        }

        private static void MappingModel(IMapperConfigurationExpression cfg)
        {
            MappingUsuario(cfg);
        }

        private static void MappingUsuario(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<LoginVM, Domain.Entities.Usuario>()
               .ForMember(destinationMember: vm => vm.LOGIN_USUARIO, memberOptions: map => map.MapFrom(sourceMember: s => s.UserName))
               .ForMember(destinationMember: vm => vm.SENHA_USUARIO, memberOptions: map => map.MapFrom(sourceMember: s => s.Password));

            cfg.CreateMap<Domain.Entities.Usuario, LoginVM>()
               .ForMember(destinationMember: vm => vm.UserName, memberOptions: map => map.MapFrom(sourceMember: s => s.LOGIN_USUARIO))
               .ForMember(destinationMember: vm => vm.Password, memberOptions: map => map.MapFrom(sourceMember: s => s.SENHA_USUARIO));
        }

    }
}