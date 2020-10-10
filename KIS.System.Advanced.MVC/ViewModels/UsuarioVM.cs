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
        public TipoAcesso TipoAcessos { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public FuncaoUsuario FuncaoUsuario { get; set; }
    }

    public enum TipoAcesso
    {
        Admin = 1,
        Vendas = 2
    }
    public enum FuncaoUsuario
    {
        Gerente = 1,
        Vendedor = 2
    }
}