using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Domain.Interfaces;
using KIS.System.Advanced.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KIS.System.Advanced.Business
{
    public class ProdutoBS
    {
        IProdutoRepository dbProduto;
        public ProdutoBS()
        {
            dbProduto = new ProdutoRepository();
        }

        public List<Produto> GetAll()
        {
            try
            {
                return dbProduto.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar produtos: {ex.Message}.");
            }
        }

        public Produto Get(int idProduto)
        {
            try
            {
                return dbProduto.GetById(idProduto);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar produto: {ex.Message}.");
            }
        }

        public void Save(Produto produto)
        {
            try
            {
                dbProduto.Add(produto);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao salvar produtos: {ex.Message}.");
            }
        }

    }
}
