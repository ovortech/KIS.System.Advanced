using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KIS.System.Advanced.MVC.ViewModels
{
    public partial class DespesaVM
    {
        public int Id { get; set; }
        public int IdTipoDespesa { get; set; }
        public string Descritivo { get; set; }
        [Required]
        [Display(Name = "Valor da Despesa")]
        public double ValorDespesa { get; set; }
        [Required]
        [Display(Name = "Data da Despesa")]
        public DateTime Data { get; set; }
        public int IdLogin { get; set; }
        public TipoDespesaVM TipoDespesa { get; set; }
    }

    public class TipoDespesaVM
    {
        public int Id { get; set; }
        public string NomeDespesa { get; set; }

    }
}