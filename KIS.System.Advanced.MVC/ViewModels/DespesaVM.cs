using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KIS.System.Advanced.MVC.ViewModels
{
    public partial class DespesaVM
    {
        public int Id { get; set; }
        public int IdTipoDespesa { get; set; }
        public string Descritivo { get; set; }
        public double ValorDespesa { get; set; }
        public DateTime Data { get; set; }
        public int IdLogin { get; set; }
    }
}