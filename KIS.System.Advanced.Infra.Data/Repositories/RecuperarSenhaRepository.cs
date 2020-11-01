using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KIS.System.Advanced.Infra.Data.Repositories
{
    public class RecuperarSenhaRepository : RepositoryBase<RecuperarSenha>, IRecuperarSenhaRepository
    {
        public RecuperarSenhaRepository() : base()
        {

        }

        public Usuario ValidateToken(string token)
        {
            var result = (from recuperarSenha in Db.RecuperarSenhas
                          join user in Db.Usuarios
                            on recuperarSenha.ID_USUARIO equals user.ID_USUARIO
                          where recuperarSenha.PRIVATE_TOKEN == token && recuperarSenha.ALTERADO_SENHA == false
                          select user).FirstOrDefault();
            return result;
        }

        public void CloseTokens(int iD_USUARIO)
        {
            var recuperarSenha = Db.RecuperarSenhas.Where(r => r.ID_USUARIO == iD_USUARIO && r.ALTERADO_SENHA == false).ToList();

            foreach (var item in recuperarSenha)
            {
                item.ALTERADO_SENHA = true;
                Update(item);
            }
        }
    }
}
