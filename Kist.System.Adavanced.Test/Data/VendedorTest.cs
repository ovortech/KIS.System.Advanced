using KIS.System.Advanced.Infra.Data.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KIS.System.Advanced.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kist.System.Adavanced.Test.Data
{
    [TestClass]
    public class VendedorTest
    {
        protected VendedorRepository _VendedorRepository;
        [TestInitialize]
        public void Initialize()
        {
            _VendedorRepository = new VendedorRepository();
        }

        [TestMethod]
        public void AddVendedor()
        {

            var Vendedors = _VendedorRepository.GetAll();
            Vendedor Vendedor = new Vendedor
            {
                NOME_VENDEDOR = "Teste Vendedor",
            };

            _VendedorRepository.Add(Vendedor);
            var Vendedorsdepopis = _VendedorRepository.GetAll();

            Assert.IsTrue(Vendedors.Count() < Vendedorsdepopis.Count());
        }


        [TestMethod]
        public void GetAllUVendedor()
        {
            var aa = _VendedorRepository.GetAll().ToList();
            Assert.IsTrue(aa != null);
        }
    }
}
