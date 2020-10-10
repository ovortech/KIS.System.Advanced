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
            Roles = new ReadOnlyCollection<string>(usuario.TipoAcessos.Select(r => r.DESC_TIPO_ACESSO.ToUpper()).ToList());
        }

        public IReadOnlyList<String> Roles { get; protected set; }
        public bool IsInRole(string role)
        {
            var result = Roles.Any(r => role.ToUpper().Split(',').Contains(r));
            return result;
        }
    }
}