using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace KIS.System.Advanced.Infra.Data.Repositories
{
    public class LoginRepository : RepositoryBase<Login>, ILoginRepository
    {
        public LoginRepository() : base()
        {
        }

        public Login Logar(Login login)
        {
            var usuario = this.Db.Logins.Where(x => x.UserName == login.UserName && x.Password == login.Password).FirstOrDefault();
            var result = (from _login in Db.Logins
                          join user in Db.Usuarios on _login.UserId equals user.UsuarioId
                          where _login.UserName == login.UserName && _login.Password == login.Password
                          select new
                          {
                              UserId = _login.UserId,
                              UserName = _login.UserName,
                              Password = _login.Password,
                              UsuarioId = _login.UsuarioId,
                              Usuario = user
                          }).FirstOrDefault();

            var logado = new Login
            {
                UserId = result.UserId,
                UserName = result.UserName,
                Password = result.Password,
                UsuarioId = result.UsuarioId,
                Usuario = result.Usuario
            };
            return logado;
        }
    }
}
