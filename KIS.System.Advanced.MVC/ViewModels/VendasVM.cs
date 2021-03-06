﻿using KIS.System.Advanced.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KIS.System.Advanced.MVC.ViewModels
{
    public partial class VendasVM
    {
        public int IdPedido { get; set; }
        public int IdVendedor{ get; set; }
        public string Observacao { get; set; }
        public int IdCliente { get; set; }        
        public List<ItemPedidoVM> ItemPedidosVM { get; set; }
        public List<FormaPGVM> FormaPGs { get; set; }
    }
}