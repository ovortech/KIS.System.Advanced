using KIS.System.Advanced.Domain.Entities;
using System.Collections;
using System.Collections.Generic;

namespace KIS.System.Advanced.Domain.Interfaces
{  

    public interface IUsuarioRepository : IRepositoryBase<Usuario>
    {
        Usuario Login(Usuario usuario);
        Usuario GetByUserName(string userName);
    }

}
