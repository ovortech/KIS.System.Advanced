using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Domain.Entities
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; } 
        public int CargoId { get; set; }
    }
}
