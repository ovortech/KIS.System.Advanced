using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KIS.System.Advanced.MVC.ViewModels
{
    public class UsuarioVM
    {
        public int IdUsuario { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public List<TipoAcessoVM> TipoAcessos { get; set; }
        public TipoAcessoVM TipoAcesso { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public FuncaoUsuarioVM ID_FUNCAO_USUARIO { get; set; }
    }

    public class TipoAcessoVM
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
    public class FuncaoUsuarioVM
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}