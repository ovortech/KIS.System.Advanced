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
    public class ContratoTest
    {
        protected ContratoRepository _contratoRepository;
        [TestInitialize]
        public void Initialize()
        {
            _contratoRepository = new ContratoRepository();
        }

        [TestMethod]
        public void AddUser()
        {
           
            var contratos = _contratoRepository.GetAll();
            Contrato contrato = new Contrato
            {
                ID_PEDIDO_CONTRATO = 2,
                ID_CLIENTE_CONTRATO = 1,
                FATURADO_CONTRATO = true,
            };

        _contratoRepository.Add(contrato);
            var contratodepois = _contratoRepository.GetAll();

            Assert.IsTrue(contratos.Count() < contratodepois.Count());
        }


        [TestMethod]
        public void GetAllUser()
        {
            var aa = _contratoRepository.GetAll().ToList();
            Assert.IsTrue(aa != null);
        }
    }
}
