using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Domain.Entities
{
    public class RecuperarSenha
    {

        public int ID_RECUPERAR_SENHA { get; set; }
        public int ID_USUARIO { get; set; }
        public string PRIVATE_TOKEN { get; set; }
        public Boolean ALTERADO_SENHA { get; set; }
        public bool ATIVO { get; set; }

    }
}
