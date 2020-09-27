using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Domain.Entities
{
    public class Comissao
    {
        public int ID_ITEM_PEDIDO { get; set; }
        public float VALOR_COMPRA_COMISSAO { get; set; }
        public float VALOR_LUCRO_COMISSAO { get; set; }
        public float PERCENTUAL_COMISSAO { get; set; }

    }
}
