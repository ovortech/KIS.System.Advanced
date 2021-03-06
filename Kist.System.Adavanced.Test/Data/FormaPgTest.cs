﻿using KIS.System.Advanced.Domain.Entities;
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
        protected FormaPgRepository _FormaPgRepository;
        [TestInitialize]
        public void Initialize()
        {
            _FormaPgRepository = new FormaPgRepository();
        }

        [TestMethod]
        public void AddUser()
        {
           
            var formaPgs = _FormaPgRepository.GetAll();
            FormaPg formaPg = new FormaPg
            {
                ID_PEDIDO = 2,
                ID_TIPO_PG = 1,
                VALOR_FORM_PG = 1
            };

        _FormaPgRepository.Add(formaPg);
            var tipoPgsdepopis = _FormaPgRepository.GetAll();

            Assert.IsTrue(formaPgs.Count() < tipoPgsdepopis.Count());
        }


        [TestMethod]
        public void GetAllUser()
        {
            var aa = _FormaPgRepository.GetAll().ToList();
            Assert.IsTrue(aa != null);
        }
    }
}
