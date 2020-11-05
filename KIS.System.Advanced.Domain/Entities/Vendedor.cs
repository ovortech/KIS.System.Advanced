using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Domain.Entities
{
    public class Vendedor : ExclusaoLogica
    {
        public int ID_VENDEDOR { get; set; }
        public string NOME_VENDEDOR { get; set; }
        public Boolean ATIVO { get; set; }

    }
}
