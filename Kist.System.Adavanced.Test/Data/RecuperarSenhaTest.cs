using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Infra.Data.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kist.System.Adavanced.Test.Data
{
    [TestClass]
    public class RecuperarSenhaTest
    {
        protected RecuperarSenhaRepository _recuperarSenhaRepository;
        [TestInitialize]
        public void Initialize()
        {
            _recuperarSenhaRepository = new RecuperarSenhaRepository();
        }

        [TestMethod]
        public void AddUser()
        {
           
            var recuperarSenhas = _recuperarSenhaRepository.GetAll();
             RecuperarSenha recuperarSenha = new RecuperarSenha
            {
                ID_USUARIO = 2,
                PRIVATE_TOKEN = "nada",
                ALTERADO_SENHA =  true,
            };

        _recuperarSenhaRepository.Add(recuperarSenha);
            var recuperarSenhadepois = _recuperarSenhaRepository.GetAll();

            Assert.IsTrue(recuperarSenhas.Count() < recuperarSenhadepois.Count());
        }


        [TestMethod]
        public void GetAllUser()
        {
            var aa = _recuperarSenhaRepository.GetAll().ToList();
            Assert.IsTrue(aa != null);
        }
    }
}
