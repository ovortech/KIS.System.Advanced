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
    public class ItemPedidoTest
    {
        protected ItemPedidoRepository _ItemPedidoRepository;
        [TestInitialize]
        public void Initialize()
        {
            _ItemPedidoRepository = new ItemPedidoRepository();
        }

        [TestMethod]
        public void AddUser()
        {
           
            var itemPedidos = _ItemPedidoRepository.GetAll();
            ItemPedido itemPedido = new ItemPedido
            {
                ID_PEDIDO = 2,
                ID_PRODUTO = 1,
                OBS_PRODUTO = "nada",
                QTD_PEDIDO = 1,
                VALOR_UN_PEDIDO = 10,
                DESCONTO_PEDIDO = 1,
            };

        _ItemPedidoRepository.Add(itemPedido);
            var itemPedidosdepois = _ItemPedidoRepository.GetAll();

            Assert.IsTrue(itemPedidos.Count() < itemPedidosdepois.Count());
        }


        [TestMethod]
        public void GetAllUser()
        {
            var aa = _ItemPedidoRepository.GetAll().ToList();
            Assert.IsTrue(aa != null);
        }
    }
}
