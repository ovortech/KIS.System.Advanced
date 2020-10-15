using KIS.System.Advanced.MVC.Support.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KIS.System.Advanced.MVC.Support
{
    public class CustomControllerBase : Controller
    {
        /// <summary>
        /// Dados basicos do usuario logado
        /// </summary>
        public CustomPrincipal CurrentUser { get; set; }

        //public static string AuthorizationRoles(AcessRole[] acessos)
        //{

        //    return "";
        //}
    }
    [Flags]
    public enum AcessRole
    {
        ADMIN = 1,
        VENDAS = 1 << 1
    }
}