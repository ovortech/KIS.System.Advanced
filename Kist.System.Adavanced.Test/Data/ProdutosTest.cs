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
    public class ProdutosTest
    {
        protected ProdutoRepository _produtoRepository;
        [TestInitialize]
        public void Initialize()
        {
            _produtoRepository = new ProdutoRepository();
        }

        [TestMethod]
        public void AddUser()
        {
           
            var produtos = _produtoRepository.GetAll();
            Produto produto = new Produto
            {
                CODIGO_PRODUTO = "",
                NOME_PRODUTO = "CHAVE",
                SERVICO_PRODUTO = true,
                VALOR_PRODUTO = 1,

            };

        _produtoRepository.Add(produto);
            var produtosdepois = _produtoRepository.GetAll();

            Assert.IsTrue(produtos.Count() < produtosdepois.Count());
        }


        [TestMethod]
        public void GetAllUser()
        {
            var aa = _produtoRepository.GetAll().ToList();
            Assert.IsTrue(aa != null);
        }
    }
}
