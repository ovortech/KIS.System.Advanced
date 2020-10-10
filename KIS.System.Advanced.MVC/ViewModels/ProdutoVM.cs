using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.WebParts;

namespace KIS.System.Advanced.MVC.ViewModels
{
    public class ProdutoVM
    {
        public int IdProduto { get; set; }
        public string CodProduto { get; set; }
        public string NomeProduto { get; set; }
        public Boolean IsServico { get; set; }
        public float ValorProduto { get; set; }
    }
}