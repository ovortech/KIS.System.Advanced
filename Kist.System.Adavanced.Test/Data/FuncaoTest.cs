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
    public class FuncaoTest
    {
        protected FuncaoRepository _funcaoPgRepository;
        [TestInitialize]
        public void Initialize()
        {
            _funcaoPgRepository = new FuncaoRepository();
        }

        [TestMethod]
        public void AddFuncao()
        {

            var tipoPGs = _funcaoPgRepository.GetAll();
            Funcao funcao = new Funcao
            {
                DESC_FUNCAO = "Teste funcao",
            };

            _funcaoPgRepository.Add(funcao);
            var tipoPgsdepopis = _funcaoPgRepository.GetAll();

            Assert.IsTrue(tipoPGs.Count() < tipoPgsdepopis.Count());
        }


        [TestMethod]
        public void GetAllFuncao()
        {
            var aa = _funcaoPgRepository.GetAll().ToList();
            Assert.IsTrue(aa != null);
        }
    }
}
