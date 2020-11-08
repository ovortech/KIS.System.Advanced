
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Domain.Entities
{
    public class Pedido : ExclusaoLogica
    {
        public int ID_PEDIDO { get; set; }
        public int ID_USUARIO_PEDIDO { get; set; }
        public Double TOTAL_PEDIDO { get; set; }
        public string OBS_PEDIDO { get; set; }
        public DateTime DATA_REG_PEDIDO { get; set; }
        public int ID_CLIENTE { get; set; }
        public Boolean FATURADO_PEDIDO { get; set; }
        public int ID_VENDEDOR { get; set; }

        [NotMapped]
        //// <summary>
        /// Propriedade obsoleta para pedido. sempre retorna null.
        /// </summary>
        public override bool ATIVO { get => true; }

    }
}
