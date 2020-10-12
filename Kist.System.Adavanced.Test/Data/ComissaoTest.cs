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
    public class ComissaoTest
    {
        protected ComissaoRepository _comissaoRepository;
        [TestInitialize]
        public void Initialize()
        {
            _comissaoRepository = new ComissaoRepository();
        }

        [TestMethod]
        public void AddUser()
        {
           
            var comissaos = _comissaoRepository.GetAll();
              Comissao comissao = new Comissao
            {
              
               ID_ITEM_PEDIDO = 2,
               VALOR_COMPRA_COMISSAO = 1,
               VALOR_LUCRO_COMISSAO = 1,
               PERCENTUAL_COMISSAO = 1,
               
            };

        _comissaoRepository.Add(comissao);
            var comissaosdepois = _comissaoRepository.GetAll();

            Assert.IsTrue(comissaos.Count() < comissaosdepois.Count());
        }


        [TestMethod]
        public void GetAllUser()
        {
            var aa = _comissaoRepository.GetAll().ToList();
            Assert.IsTrue(aa != null);
        }
    }
}
