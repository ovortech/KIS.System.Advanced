
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Domain.Entities
{
    public class PedidoCancelamento : ExclusaoLogica
    {
        public int ID_PEDIDO_CANCELAMENTO { get; set; }
        public int ID_PEDIDO { get; set; }
        public int ID_TIPO_CANCELAMENTO { get; set; }
        public string DESC_PEDIDO_CANCELAMENTO { get; set; }
        public DateTime DATA_CANCELAMENTO { get; set; }

        [NotMapped]
        //// <summary>
        /// Propriedade obsoleta para PedidoCancelamento. sempre retorna null.
        /// </summary>
        public override bool ATIVO { get => true; }
    }
}
