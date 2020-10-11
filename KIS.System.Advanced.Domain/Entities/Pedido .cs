
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Domain.Entities
{
    public class Pedido
    {
        public int ID_PEDIDO { get; set; }
        public int ID_USUARIO_PEDIDO { get; set; }
        public float TOTAL_PEDIDO { get; set; }
        public string OBS_PEDIDO { get; set; }
        public int DATA_REG_PEDIDO { get; set; }
        public int ID_CLIENTE { get; set; }
        public Boolean FATURADO_PEDIDO { get; set; }

    }
}
