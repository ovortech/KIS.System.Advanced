using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Domain.Entities
{
    public class ItemPedido : ExclusaoLogica
    {
        public int ID_ITEM_PEDIDO { get; set; }
        public int ID_PEDIDO { get; set; }
        //public Pedido Pedido { get; set; }
        public int ID_PRODUTO { get; set; }
        public Produto Produto { get; set; }
        public string OBS_PRODUTO { get; set; }
        public int QTD_PEDIDO { get; set; }
        public float VALOR_UN_PEDIDO { get; set; }
        public float DESCONTO_PEDIDO { get; set; }

    }
}
