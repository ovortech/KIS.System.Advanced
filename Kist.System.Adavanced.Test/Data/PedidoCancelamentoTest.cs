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
    public class PedidoCancelamentoTest
    {
        protected PedidoCancelamentoRepository _PedidoCancelamentoRepository;
        [TestInitialize]
        public void Initialize()
        {
            _PedidoCancelamentoRepository = new PedidoCancelamentoRepository();
        }

        [TestMethod]
        public void AddUser()
        {
           
            var pedidoCancelamentos = _PedidoCancelamentoRepository.GetAll();
            PedidoCancelamento pedidoCancelamento = new PedidoCancelamento
            {
                ID_PEDIDO_CANCELAMENTO = 1,
                ID_PEDIDO = 1,
                ID_TIPO_CANCELAMENTO = 1,
                DESC_PEDIDO_CANCELAMENTO = "nada",
                DATA_CANCELAMENTO = //"Erro ref a config de datetime",//
            };

        _PedidoCancelamentoRepository.Add(pedidoCancelamento);
            var pedidoCancelamentosdepois = _PedidoCancelamentoRepository.GetAll();

            Assert.IsTrue(pedidoCancelamentos.Count() < pedidoCancelamentosdepois.Count());
        }


        [TestMethod]
        public void GetAllUser()
        {
            var aa = _PedidoCancelamentoRepository.GetAll().ToList();
            Assert.IsTrue(aa != null);
        }
    }
}
