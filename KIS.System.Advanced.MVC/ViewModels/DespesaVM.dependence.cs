using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KIS.System.Advanced.MVC.ViewModels
{
    public partial class DespesaVM
    {
        public List<TipoDespesaVM> TiposDespesa { get; set; }
        public List<DespesaVM> Despesas { get; set; }
    }

    public class TipoDespesaVM
    {
        public int Id { get; set; }
        public string NomeDespesa{ get; set; }

    }
}