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
        public IIdentity Identity { get; set; }
        public String Nome { get; set; }

        public CustomPrincipal(Usuario usuario)
        {
            Identity = new GenericIdentity(usuario.LOGIN_USUARIO);
            Nome = usuario.NOME_USUARIO;
            Role = usuario.TipoAcessos.DESC_TIPO_ACESSO.ToUpper();
        }

        public String Role { get; protected set; }
        public bool IsInRole(string roles)
        {
            var result = roles.ToUpper().Split(',').Any(r => r.Trim().Equals(Role));
            return result;
        }
    }
}