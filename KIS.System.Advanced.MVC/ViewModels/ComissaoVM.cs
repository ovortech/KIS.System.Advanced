using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KIS.System.Advanced.MVC.ViewModels
{
    public class ComissaoVM
    {
        public int Id { get; set; }
        public DateTime DataVenda { get; internal set; }
        public string TipoVenda { get; set; }
        public string NomeProduto { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public double ValorVenda { get; set; }
        public double ValorCustoUnitario { get; set; }
        public double ValorLucro { get; set; }
        public double PercComissao { get; set; }
        public bool Pago { get; set; }
    }
}