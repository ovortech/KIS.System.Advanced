using KIS.System.Advanced.Business;
using KIS.System.Advanced.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly ProdutoBS produtoBS;
        public ProdutoService()
        {
            produtoBS = new ProdutoBS();
        }
    }
}
