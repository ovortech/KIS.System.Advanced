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
    public class LoginBS
    {
        ILoginRepository dbLogin;
        public LoginBS()
        {
            dbLogin = new LoginRepository();
        }

        public IEnumerable<Login> Logar()
        {
            try
            {
                var alllogins = dbLogin.GetAll();
                return alllogins;
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
