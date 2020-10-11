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
    public class FormaPgTest
    {
        protected FormaPgRepository _formaPgRepository;
        [TestInitialize]
        public void Initialize()
        {
            _formaPgRepository = new FormaPgRepository();
        }

        [TestMethod]
        public void AddUser()
        {
           
            var formaPgs = _formaPgRepository.GetAll();
            FormaPg formaPg = new FormaPg
            {
                //   NOME_PG = "debito",
                ID_PEDIDO = 1,
                ID_TIPO_PG = 1,
                VALOR_FORM_PG = 10,

            };

        _formaPgRepository.Add(formaPg);
            var formaPgsdepois = _formaPgRepository.GetAll();

            Assert.IsTrue(formaPgs.Count() < formaPgsdepois.Count());
        }


        [TestMethod]
        public void GetAllUser()
        {
            var aa = _formaPgRepository.GetAll().ToList();
            Assert.IsTrue(aa != null);
        }
    }
}
