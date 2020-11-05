
using KIS.System.Advanced.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kist.System.Adavanced.Test.Business
{
    [TestClass]
    public class PedidoTest
    {

        protected PedidoBS _pedidoBS;
        [TestInitialize]
        public void Initialize()
        {
            _pedidoBS = new PedidoBS();
        }

        [TestMethod]
        public void GetNextOrder()
        {
            var result = _pedidoBS.GetNextOrderNumber();
            Assert.IsTrue(result != null);
        }

        [TestMethod]
        public void GetAll()
        {
            var result = _pedidoBS.GetAll();
            Assert.IsTrue(result != null);
        }
    }
}
