using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace KIS.System.Advanced.Infra.Data.Repositories
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository() : base()
        {

        }

        public Usuario Login(Usuario usuario)
        {
            var userLogado = Db.Usuarios.Where(x => x.LOGIN_USUARIO == usuario.LOGIN_USUARIO && x.SENHA_USUARIO == usuario.SENHA_USUARIO).FirstOrDefault();
            return userLogado;
        }
    }
}
