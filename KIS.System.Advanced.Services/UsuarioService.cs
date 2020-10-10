using KIS.System.Advanced.Business;
using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly UsuarioBS usuarioBS;
        public UsuarioService()
        {
            usuarioBS = new UsuarioBS();
        }
        public Usuario Logar(Usuario login)
        {
            return usuarioBS.Logar(login);
        }
    }
}
