
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Domain.Entities
{
   public class PedidoCancelamento
    {
        public int ID_PEDIDO_CANCELAMENTO { get; set; }
        public int ID_PEDIDO { get; set; }
        //public Pedido Pedido { get; set; }
        public int ID_TIPO_CANCELAMENTO { get; set; }
        public TipoCancelamento TipoCancelamento { get; set; }
        public string DESC_PEDIDO_CANCELAMENTO { get; set; }
        public DateTime DATA_CANCELAMENTO { get; set; }
    }
}
