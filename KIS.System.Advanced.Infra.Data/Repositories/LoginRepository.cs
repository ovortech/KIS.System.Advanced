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
            return usuario;
        }
    }
}
