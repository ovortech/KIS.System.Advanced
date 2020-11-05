using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Domain.Entities
{
    public class TipoAcesso : ExclusaoLogica
    {
        public int ID_TIPO_ACESSO { get; set; }
        public string DESC_TIPO_ACESSO { get; set; }
        public Boolean ATIVO { get; set; }

    }
}
