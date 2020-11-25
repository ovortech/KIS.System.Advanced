using KIS.System.Advanced.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kist.System.Adavanced.Test.Business
{
    [TestClass]
    public class RecuperarSenhaTest
    {
        protected RecuperarSenhaBS _recuperarSenhaBS;
        [TestInitialize]
        public void Initialize()
        {
            _recuperarSenhaBS = new RecuperarSenhaBS();
        }

        [TestMethod]
        public void AlterarSenha()
        {
            var usuario = _recuperarSenhaBS.SendEmailNewPassword("mnmelo", "http://localhost");

            Assert.IsTrue(usuario != null);
        }
    }
}
