using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Domain.Entities
{
    public class Contrato : ExclusaoLogica
    {
        public int ID_CONTRATO { get; set; }
        public int ID_PEDIDO_CONTRATO { get; set; }
        public int ID_CLIENTE_CONTRATO { get; set; }
        public Boolean FATURADO_CONTRATO { get; set; }

    }
}
