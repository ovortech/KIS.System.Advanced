using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Domain.Entities
{
    public class Comissao : ExclusaoLogica
    {
        [Key]
        public int ID_COMISSAO { get; set; }
        public int ID_ITEM_PEDIDO { get; set; }
        public double VALOR_CUSTO_COMISSAO { get; set; }
        public double VALOR_LUCRO_COMISSAO { get; set; }
        public double PERCENTUAL_COMISSAO { get; set; }
        public Boolean PAGO_COMISSAO { get; set; }
        public DateTime? DATA_PAGAMENTO_COMISSAO { get; set; }

        [NotMapped]
        //// <summary>
        /// Propriedade obsoleta para esta entidade. sempre retorna null.
        /// </summary>
        public override bool ATIVO { get => true; }

    }
}
