﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KIS.System.Advanced.MVC.ViewModels
{
    public partial class HistoricoVendaVM
    {
        public List<VendedorVM> Vendedores { get; set; }
        public List<GridHistoricoVendaVM> GridHistoricoVenda { get;set;}
    }

    public class GridHistoricoVendaVM
    {
        public int IdPedido { get; set; }
        public int IdVendedor { get; set; }
        public String NomeVendedor { get; set; }
        public String Observacao { get; set; }
        public DateTime DataVenda { get; set; }
        public double TotalPedido { get; set; }
        public Boolean Faturado { get; set; }
        public bool Cancelado { get; set; }
        public String DescricaoCancelamento { get; set; }
        public List<DetailPedidoVM> ItemsPedido { get; set; }
    }    
}