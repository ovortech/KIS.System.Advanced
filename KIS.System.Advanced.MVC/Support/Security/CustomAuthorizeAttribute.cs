using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using diagnostic = System.Diagnostics;


namespace KIS.System.Advanced.MVC.Support.Security
{
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        public AcessRole IsPermission;
        public CustomAuthorizeAttribute()
        {
            //AcessRole[] roles = new AcessRole[] { AcessRole.ADMIN, AcessRole.VENDAS };
            //var permissionRoles = roles.Select(r => Enum.GetName(typeof(AcessRole), r));
            //Roles = string.Join(",", permissionRoles);
        }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            return base.AuthorizeCore(httpContext);
        }

        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (SessionPersister.User == null)
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Login", action = "Index" }));
            else
            {
                //UsuarioService usuarioService = new UsuarioService();
                //var logado = usuarioService.Logar(new Usuario { LOGIN_USUARIO = SessionPersister.UserName, SENHA_USUARIO = "1234" });
                //if (logado != null)
                //{
                //string roles = "";
                //logado.TipoAcessos.Select(s => s.DESC_TIPO_ACESSO).ToList().ForEach(x => roles += x + ",");
                var customPrincipal = SessionPersister.User;
                
                if (!customPrincipal.IsInRole(IsPermission.ToString()))
                    filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "AccessDenied", action = "Index" }));
                //}
            }
        }
    }
}