using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KIS.System.Advanced.MVC.ViewModels
{
	public partial class VendasVM
	{
		public List<ClienteVM> Clientes { get; set; }
		public List<ProdutoVM> Produtos { get; set; }
        public List<TipoPGVM> TipoPGs { get; set; }
        public List<VendedorVM> Vendedores { get; set; }
    }

	public class TipoPGVM
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }

	public class FormaPGVM
    {
        public TipoPGVM TipoPGVM { get; set; }
        public Double ValorPG { get; set; }
    }
}