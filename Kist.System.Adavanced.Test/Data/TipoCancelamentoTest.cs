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
    public class TipoCancelamentoTest
    {
        protected TipoCancelamentoRepository _tipoCancelamentoRepository;
        [TestInitialize]
        public void Initialize()
        {
            _tipoCancelamentoRepository = new TipoCancelamentoRepository();
        }

        [TestMethod]
        public void AddUser()
        {
           
            var tipoCancelamentos = _tipoCancelamentoRepository.GetAll();
            TipoCancelamento tipoCancelamento = new TipoCancelamento
            {
            };

        _tipoCancelamentoRepository.Add(tipoCancelamento);
            var tipoCancelamentosdepopis = _tipoCancelamentoRepository.GetAll();

            Assert.IsTrue(tipoCancelamentos.Count() < tipoCancelamentosdepopis.Count());
        }


        [TestMethod]
        public void GetAllUser()
        {
            var aa = _tipoCancelamentoRepository.GetAll().ToList();
            Assert.IsTrue(aa != null);
        }
    }
}
