using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KIS.System.Advanced.MVC.ViewModels
{
    public class PedidoCancelamentoVM
    {
        public int IdPedido { get; set; }
        public int IdTipoCancelamento { get; set; }
        public String Decricao { get; set; }
        public List<TipoCancelamentoVM> TipoCancelamentosVM { get; set; }
    }
}