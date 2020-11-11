using KIS.System.Advanced.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace KIS.System.Advanced.MVC.Support.Security
{
    public class CustomPrincipal : IPrincipal
    {
        /// <summary>
        /// User Login do usuario
        /// </summary>
        public IIdentity Identity { get; protected set; }
        public String Nome { get; protected set; }
        public String Email { get; protected set; }
        public int IdUsuario { get; protected set; }
        public DateTime FimDaSessao { get; set; }

        public CustomPrincipal(Usuario usuario)
        {
            HttpContext.Current.Session.Timeout = 180;

            Identity = new GenericIdentity(usuario.LOGIN_USUARIO);
            Nome = usuario.NOME_USUARIO;
            Email = usuario.EMAIL_USUARIO;
            IdUsuario = usuario.ID_USUARIO;
            UserRole = usuario.TipoAcessos.DESC_TIPO_ACESSO.ToUpper();
            FimDaSessao = DateTime.Now.AddMinutes(HttpContext.Current.Session.Timeout);
        }

        public String UserRole { get; protected set; }
        public bool IsInRole(string roles)
        {
            //Enum.Parse(typeof(AcessRole), customPrincipal.Role)
            var result = roles.ToUpper().Split(',').Any(r => r.Trim().Equals(UserRole));
            return result;
        }
    }
}