using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Domain.Entities
{
    public class Comissao
    {
        [Key]
        public int ID_ITEM_PEDIDO { get; set; }
        public double VALOR_COMPRA_COMISSAO { get; set; }
        public double VALOR_LUCRO_COMISSAO { get; set; }
        public double PERCENTUAL_COMISSAO { get; set; }
        public bool ATIVO { get; set; }


    }
}
