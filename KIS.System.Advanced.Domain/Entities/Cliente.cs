using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Domain.Entities
{
    public class Cliente
    {
        [Key] // Deverá ser add, para representar a chave no dataBase
        public int ID_CLIENTE { get; set; }
        public string NOME_CLIENTE { get; set; }
        public bool ATIVO { get; set; }
    }
}
