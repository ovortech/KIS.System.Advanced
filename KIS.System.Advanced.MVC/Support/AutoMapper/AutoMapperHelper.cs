using AutoMapper;
using KIS.System.Advanced.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace KIS.System.Advanced.MVC.Support
{
    public static class AutoMapperHelper
    {
        public static void InitiazeMapper()
        {
            Mapper.Initialize(cfg =>
            {
                ModelForViewModel(cfg);
                ViewModelForModel(cfg);
            });
        }

        private static void ViewModelForModel(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<LoginVM, Login>();
        }

        private static void ModelForViewModel(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Login, LoginVM>();
        }
    }
}