using KIS.System.Advanced.Domain.Interfaces;
using KIS.System.Advanced.Infra.Data.Repositories;
using System;

namespace KIS.System.Advanced.Business
{
    public class ProdutoBS
    {
        IProdutoRepository dbProduto;
        public ProdutoBS()
        {
            dbProduto = new ProdutoRepository();
        }

    }
}
