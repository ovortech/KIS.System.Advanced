using AutoMapper;
using KIS.System.Advanced.MVC.ViewModels;
using System.Web.UI.WebControls;
using KIS.System.Advanced.Domain.Entities;

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
                ModelForViewModel(cfg);
                ViewModelForModel(cfg);
            });
        }

        private static void ViewModelForModel(IMapperConfigurationExpression cfg)
        {
            //cfg.CreateMap<LoginVM, Domain.Entities.Usuario>();
        }

        private static void ModelForViewModel(IMapperConfigurationExpression cfg)
        {
            //cfg.CreateMap<Domain.Entities.Usuario, LoginVM>()
            //    .ForMember(destinationMember: vm => vm.LoginId, memberOptions: map => map.MapFrom(sourceMember: s => s.UserId));
            //;
        }
    }
}