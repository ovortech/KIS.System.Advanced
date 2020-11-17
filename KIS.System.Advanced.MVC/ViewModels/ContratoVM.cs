using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KIS.System.Advanced.MVC.ViewModels
{
    public partial class ContratoVM
    {
        public int IdCliente { get; set; }

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
    }
}