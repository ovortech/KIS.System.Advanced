using KIS.System.Advanced.Infra.Data.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Kist.System.Adavanced.Test.Data
{
    [TestClass]
    public class ProdutoTest
    {
        protected ProdutoRepository _produtoRepository;
        [TestInitialize]
        public void Initialize()
        {
            _produtoRepository = new ProdutoRepository();
        }

        [TestMethod]
        public void GetAll()
        {
            var produtos = _produtoRepository.GetAll(); //TODO: finish this method

        }
    }
}
