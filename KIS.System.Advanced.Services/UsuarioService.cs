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

        public void Delete(int idUsuario)
        {
            usuarioBS.Delete(idUsuario);
        }

        public Usuario Get(int idUsuario)
        {
            return usuarioBS.Get(idUsuario);
        }

        public List<Usuario> GetAll()
        {
            return usuarioBS.GetAll();
        }

        public Usuario Logar(Usuario login)
        {
            return usuarioBS.Logar(login);
        }

        public void Save(Usuario usuario)
        {
            usuarioBS.Save(usuario);
        }

        public void Update(Usuario usuario)
        {
            usuarioBS.Update(usuario);
        }
    }
}
