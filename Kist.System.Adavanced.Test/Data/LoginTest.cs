
using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Infra.Data.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kist.System.Adavanced.Test.Data
{
    [TestClass]
    public class LoginTest
    {
        protected LoginRepository _loginRepository;
        [TestInitialize]
        public void Initialize()
        {
            _loginRepository = new LoginRepository();
        }

        [TestMethod]
        public void Logar()
        {
            var login = new Login { UserName = "marcosmelo", Password = "123456" };
            var user =_loginRepository.Logar(login);
            Assert.AreEqual(2, user.UserId);
        }
    }
}
