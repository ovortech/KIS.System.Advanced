using KIS.System.Advanced.MVC.Support.Security;
using KIS.System.Advanced.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KIS.System.Advanced.MVC.Support
{
    public class CustomControllerBase<T> : Controller where T : class 
    {
        /// <summary>
        /// Dados basicos do usuario logado
        /// </summary>
        public CustomPrincipal CurrentUser { get; set; }

        public PartialViewResult GetForm(T model)
        {
            return PartialView("AddOrEdit", model);
        }        
    }

    [Flags]
    public enum AcessRole
    {
        ADMIN = 1,
        VENDAS = 1 << 1
    }

}