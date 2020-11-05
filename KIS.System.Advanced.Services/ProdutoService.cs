using KIS.System.Advanced.Business;
using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace KIS.System.Advanced.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly ProdutoBS produtoBS;
        public ProdutoService()
        {
            produtoBS = new ProdutoBS();
        }

        public void Delete(int idProduto)
        {
            produtoBS.Delete(idProduto);
        }

        public void Update(Produto produto)
        {
            produtoBS.Update(produto);
        }

        public Produto Get(int idProduto)
        {
            return produtoBS.Get(idProduto);
        }

        public List<Produto> GetAll()
        {
            return produtoBS.GetAll();
        }

        public void Save(Produto produto)
        {
            produtoBS.Save(produto);
        }

    }
}
