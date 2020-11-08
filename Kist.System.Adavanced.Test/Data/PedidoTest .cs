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
    public class PedidoTest
    {
        protected PedidoRepository _pedidoRepository;
        [TestInitialize]
        public void Initialize()
        {
            _pedidoRepository = new PedidoRepository();
        }

        [TestMethod]
        public void AddUser()
        {
           
            var pedidos = _pedidoRepository.GetAll();
            Pedido pedido = new Pedido
            {
                ID_USUARIO_PEDIDO = 2,
                TOTAL_PEDIDO = 1,
                OBS_PEDIDO = "nada",
                DATA_REG_PEDIDO = DateTime.Now,
                ID_CLIENTE = 1,
                FATURADO_PEDIDO = true,
                ID_VENDEDOR = 2,
            };

        _pedidoRepository.Add(pedido);
            var pedidodepois = _pedidoRepository.GetAll();

            Assert.IsTrue(pedidos.Count() < pedidodepois.Count());
        }


        [TestMethod]
        public void GetAllPedido()
        {
            var aa = _pedidoRepository.GetAll().ToList();
            Assert.IsTrue(aa != null);
        }


        [TestMethod]
        public void ExclusaoLogica()
        {
            _pedidoRepository.RemoveLogic(2);
            // Assert.IsTrue(aa != null);
        }
    }
}
