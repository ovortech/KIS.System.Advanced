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
    public class TipoDespesaTest
    {
        protected TipoDespesaRepository _tipoDespesaRepository;
        [TestInitialize]
        public void Initialize()
        {
            _tipoDespesaRepository = new TipoDespesaRepository();
        }

        [TestMethod]
        public void AddUser()
        {
           
            var tipoDespesas = _tipoDespesaRepository.GetAll();
             TipoDespesa tipoDespesa = new TipoDespesa
            {
               NOME_TIPO_DESPESA = "nd",
            };

        _tipoDespesaRepository.Add(tipoDespesa);
            var tipoDespesasdepois = _tipoDespesaRepository.GetAll();

            Assert.IsTrue(tipoDespesas.Count() < tipoDespesasdepois.Count());
        }


        [TestMethod]
        public void GetAllUser()
        {
            var aa = _tipoDespesaRepository.GetAll().ToList();
            Assert.IsTrue(aa != null);
        }
    }
}
