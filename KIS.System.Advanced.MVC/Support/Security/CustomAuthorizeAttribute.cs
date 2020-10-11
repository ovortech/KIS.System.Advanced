using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;


namespace KIS.System.Advanced.MVC.Support.Security
{
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
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
                if (!customPrincipal.IsInRole(Roles))
                    filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "AccessDenied", action = "Index" }));
                //}
            }
        }
    }
}