using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KIS.System.Advanced.MVC.ViewModels
{
    public partial class ContratoVM
    {
        public List<ClienteVM> Clientes { get; set; }
    }

    public class GridContratoVM
    {
        public int IdContrato { get; set; }
        public int IdPedido { get; set; }
        public int IdVendedor { get; set; }
        public String NomeCliente { get; set; }
        public String NomeVendedor { get; set; }
        public String Observacao { get; set; }
        public DateTime DataVenda { get; set; }
        public Double TotalPedido { get; set; }
        public bool Faturado { get; set; }
        public DateTime? DataFaturamento { get; set; }
    }
}