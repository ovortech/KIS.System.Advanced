using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Domain.Entities
{
   public class PedidoCancelamento
    {
        public int id_pedido_cancelamento { get; set; }
        public int id_pedido { get; set; }
        public int id_tipo_cancelamento { get; set; }
        public string desc_pedido_cancelamento { get; set; }
        public DateTime data_cancelamento { get; set; }
    }
}
