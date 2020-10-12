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
    public class DespesaTest
    {
        protected DespesaRepository _despesaRepository;
        [TestInitialize]
        public void Initialize()
        {
            _despesaRepository = new DespesaRepository();
        }

        [TestMethod]
        public void AddUser()
        {
           
            var despesas = _despesaRepository.GetAll();
            Despesa despesa = new Despesa
            {
               ID_TIPO_DESPESA = 1,
               DESC_DESPESA = "nd",
               VALOR_DESPESA = 1,
               DATA_DESPESA = DateTime.Now,
               ID_LOGIN_DESPESA = 2, 
            };

        _despesaRepository.Add(despesa);
            var despesadepois = _despesaRepository.GetAll();

            Assert.IsTrue(despesas.Count() < despesadepois.Count());
        }


        [TestMethod]
        public void GetAllUser()
        {
            var aa = _despesaRepository.GetAll().ToList();
            Assert.IsTrue(aa != null);
        }
    }
}
