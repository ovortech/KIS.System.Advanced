using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KIS.System.Advanced.MVC.ViewModels
{
    public partial class ComissaoVM
    {      
        public int IdComissao { get; set; }

        private DateTime dataInicio;

        public DateTime DataInicio
        {
            get { return dataInicio == DateTime.MinValue ? DateTime.Now : dataInicio; }
            set { dataInicio = value; }
        }

        private DateTime dataFim;

        public DateTime DataFim
        {
            get { return dataFim == DateTime.MinValue ? DateTime.Now : dataInicio; }
            set { dataFim = value; }
        }
        public int IdItemPedido { get; set; }
        public DateTime DataVenda { get; internal set; }
        public string TipoVenda { get; set; }
        public string NomeProduto { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public double ValorVenda { get; set; }
        public double ValorCustoUnitario { get; set; }
        [Required]
        public double ValorLucro { get; set; }
        [Required]
        public double PercComissao { get; set; }
        public bool Pago { get; set; }
        public bool Ativo { get; set; }
        public DateTime? DataPg { get; set; }
    }
}