using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KIS.System.Advanced.MVC.ViewModels
{
	public partial class VendasVM
	{
		public List<ClienteVM> Clientes { get; set; }
		public List<ProdutoVM> Produto { get; set; }
        public List<TipoPGVM> TipoPGVM { get; set; }
	}

	public class TipoPGVM
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }

	public class FormaPG
    {
        public TipoPGVM MyProperty { get; set; }
        public Double ValorPG { get; set; }
    }
}