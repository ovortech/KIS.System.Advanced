using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KIS.System.Advanced.MVC.ViewModels
{
    public class DetailPedidoVM
    {
        public int IdPedido { get; set; }
        public int IdItemPedido { get; set; }
        public int IdProduto { get; set; }
        public String NomeProduto { get; set; }
        public String Descricao { get; set; }
        public int Quantidade { get; set; }
        public Double ValorUnitario { get; set; }
        public Double DescontoUnitario { get; set; }
        public Double Total { get; set; }
    }
}