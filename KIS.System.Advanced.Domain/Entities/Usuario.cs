using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Domain.Entities
{
    public class Usuario
    {
        public Usuario()
        {
            //TipoAcessos = new List<TipoAcesso>();
        }

        [Key]
        public int ID_USUARIO { get; set; }
        public string LOGIN_USUARIO { get; set; }
        public string SENHA_USUARIO { get; set; }
        public int ID_TIPO_ACESSO_USUARIO { get; set; }
        [NotMapped]
        public virtual List<TipoAcesso> TipoAcessos { get; set; }
        public string NOME_USUARIO { get; set; }
        public string EMAIL_USUARIO { get; set; }
        public int ID_FUNCAO_USUARIO { get; set; }
        [NotMapped]
        public virtual Funcao Funcao { get; set; }
    }
}
