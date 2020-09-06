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
    public class LoginService : ILoginService
    {
        private readonly LoginBS loginBS;
        public LoginService()
        {
            loginBS = new LoginBS();
        }
        public IEnumerable<Login> Logar(Login login)
        {
            return loginBS.Logar(login);
        }
    }
}
