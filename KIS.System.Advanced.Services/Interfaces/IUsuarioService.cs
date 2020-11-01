using KIS.System.Advanced.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Services.Interfaces
{
    public interface IUsuarioService
    {
        Usuario Logar(Usuario login);
        List<Usuario> GetAll();
        void Save(Usuario usuario);
        Usuario Get(int idUsuario);
        void Delete(int idUsuario);
        void Update(Usuario usuario);
    }
}
