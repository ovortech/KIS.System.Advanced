using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Domain.Entities
{
    public class Funcao
    {
        [Key]
        public int ID_FUNCAO { get; set; }
        public string DESC_FUNCAO { get; set; }
        public bool ATIVO { get; set; }

    }
}
