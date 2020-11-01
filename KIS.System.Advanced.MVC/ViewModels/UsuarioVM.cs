using KIS.System.Advanced.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace KIS.System.Advanced.MVC.ViewModels
{
    public class UsuarioVM
    {
        public int IdUsuario { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public TipoAcessoEnum TipoAcessos { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public FuncaoEnum Funcao { get; set; }
    }


}