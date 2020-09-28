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
    public class ClienteTest
    {
        protected ClienteRepository _clienteRepository;
        [TestInitialize]
        public void Initialize()
        {
            _clienteRepository = new ClienteRepository();
        }

        [TestMethod]
        public void AddUser()
        {
           
            var clientes = _clienteRepository.GetAll();
            Cliente cliente = new Cliente
            {
                NOME_CLIENTE = "Everton",
            };

            _clienteRepository.Add(cliente);
            var clientedepopis = _clienteRepository.GetAll();

            Assert.IsTrue(clientes.Count() < clientedepopis.Count());
        }


        [TestMethod]
        public void GetAllUser()
        {
            var aa = _clienteRepository.GetAll().ToList();
            Assert.IsTrue(aa != null);
        }
    }
}
