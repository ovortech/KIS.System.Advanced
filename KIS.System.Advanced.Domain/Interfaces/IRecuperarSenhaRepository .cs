using KIS.System.Advanced.Domain.Entities;
using System;

namespace KIS.System.Advanced.Domain.Interfaces
{
    public interface IRecuperarSenhaRepository : IRepositoryBase<RecuperarSenha>
    {
        Usuario ValidateToken(String token);
    }
}
