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
            try
            {
                var comissaos = _comissaoRepository.GetAll();
                Comissao comissao = new Comissao
                {
                    ID_ITEM_PEDIDO = 5,
                    VALOR_CUSTO_COMISSAO = 5,
                    VALOR_LUCRO_COMISSAO = 55,
                    PERCENTUAL_COMISSAO = 0,
                    PAGO_COMISSAO = false
                };

                _comissaoRepository.Add(comissao);
                var comissaosdepois = _comissaoRepository.GetAll();

                Assert.IsTrue(comissaos.Count() < comissaosdepois.Count());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        [TestMethod]
        public void GetAllUser()
        {
            var aa = _comissaoRepository.GetAll().ToList();
            Assert.IsTrue(aa != null);
        }


        [TestMethod]
        public void GetAllComissaoDto()
        {
            var aa = _comissaoRepository.GetDto(2, DateTime.Now.AddDays(-10), DateTime.Now).ToList();
            Assert.IsTrue(aa != null);
        }
    }
}
