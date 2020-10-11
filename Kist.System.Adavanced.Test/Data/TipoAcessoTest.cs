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
    public class TipoAcessoTest
    {
        protected TipoAcessoRepository _tipoAcessoRepository;
        [TestInitialize]
        public void Initialize()
        {
            _tipoAcessoRepository = new TipoAcessoRepository();
        }

        [TestMethod]
        public void AddUser()
        {

            var tipoPGs = _tipoAcessoRepository.GetAll();
            TipoAcesso tipoPg = new TipoAcesso
            {
                DESC_TIPO_ACESSO = "Test"
            };

            _tipoAcessoRepository.Add(tipoPg);
            var tipoPgsdepopis = _tipoAcessoRepository.GetAll();

            Assert.IsTrue(tipoPGs.Count() < tipoPgsdepopis.Count());
        }


        [TestMethod]
        public void GetAllUser()
        {
            var aa = _tipoAcessoRepository.GetAll().ToList();
            Assert.IsTrue(aa != null);
        }
    }
}
