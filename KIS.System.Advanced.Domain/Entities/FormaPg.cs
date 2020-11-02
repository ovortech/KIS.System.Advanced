using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Domain.Entities
{
   public class FormaPg
    {
        public int ID_FORM_PG { get; set; }
        public int ID_PEDIDO { get; set; }
        //public Pedido Pedido { get; set; }
        public int ID_TIPO_PG { get; set; }
        public double VALOR_FORM_PG { get; set; }
        public bool ATIVO { get; set; }

    }
}
