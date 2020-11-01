using KIS.System.Advanced.Business;
using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Services
{
    public class RecuperarSenhaService : IRecuperarSenhaService
    {
        private readonly RecuperarSenhaBS recuperarSenhaBS;
        public RecuperarSenhaService()
        {
            recuperarSenhaBS = new RecuperarSenhaBS();
        }

        public Usuario ValidateToken(string token)
        {
            return recuperarSenhaBS.ValidateToken(token);
        }

        public Usuario SendEmailNewPassword(string userName)
        {
            return recuperarSenhaBS.SendEmailNewPassword(userName);
        }

        public void NovaSenha(Usuario usuario)
        {
            recuperarSenhaBS.AtualizaSenha(usuario);
        }
    }
}
