using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Domain.Interfaces;
using KIS.System.Advanced.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Business
{
    public class UsuarioBS
    {
        IUsuarioRepository dbUsuario;
        public UsuarioBS()
        {
            dbUsuario = new UsuarioRepository();
        }

        public Usuario Logar(Usuario usuario)
        {
            try
            {
                var usuarioLogado = dbUsuario.Login(usuario);
                return usuarioLogado;
            }
            catch (EntityException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
