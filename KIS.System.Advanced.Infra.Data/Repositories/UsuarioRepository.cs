using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace KIS.System.Advanced.Infra.Data.Repositories
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        public IEnumerable<Usuario> BuscarPorNome(string nome)
        {
            return Db.Usuarios.Where(p => p.Nome.Contains(nome));
        }
    }
}
