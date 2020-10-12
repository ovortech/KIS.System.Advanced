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
    public class TipoPgTest
    {
        protected TipoPgRepository _tipoPgRepository;
        [TestInitialize]
        public void Initialize()
        {
            _tipoPgRepository = new TipoPgRepository();
        }

        [TestMethod]
        public void AddUser()
        {
           
            var tipoPGs = _tipoPgRepository.GetAll();
            TipoPg tipoPg = new TipoPg
            {
                NOME_PG = "credito",
            };

        _tipoPgRepository.Add(tipoPg);
            var tipoPgsdepopis = _tipoPgRepository.GetAll();

            Assert.IsTrue(tipoPGs.Count() < tipoPgsdepopis.Count());
        }


        [TestMethod]
        public void GetAllUser()
        {
            var aa = _tipoPgRepository.GetAll().ToList();
            Assert.IsTrue(aa != null);
        }
    }
}
