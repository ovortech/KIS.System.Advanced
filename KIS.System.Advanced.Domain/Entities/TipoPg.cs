using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Domain.Entities
{
    public class TipoPg : ExclusaoLogica
    {
        [Key]
        public int ID_TIPO_PG { get; set; }
        public string NOME_PG { get; set; }
        public Boolean ATIVO { get; set; }

    }
}
