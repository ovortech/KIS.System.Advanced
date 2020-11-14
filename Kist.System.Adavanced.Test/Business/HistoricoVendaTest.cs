﻿using KIS.System.Advanced.Business;
using KIS.System.Advanced.Domain.Dto;
using KIS.System.Advanced.Infra.Data.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Kist.System.Adavanced.Test.Business
{
    [TestClass]
    public class HistoricoVendaTest
    {
        HistoricoVendaBS _historicoVendaBS;

        [TestInitialize]
        public void Initialize()
        {
            _historicoVendaBS = new HistoricoVendaBS();
        }

        [TestMethod]
        public void GetHistoricoVendaDtos()
        {

            _historicoVendaBS.GetHistoricoVendaDtos(1, DateTime.Now.AddDays(-10), DateTime.Now);

            Assert.IsTrue(true);
        }
    }
}
