using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Infra.Data.Repositories;
using System;
using KIS.System.Advanced.Support.Email;
using System.Text;

namespace KIS.System.Advanced.Business
{
    public class RecuperarSenhaBS
    {
        private RecuperarSenhaRepository _dbRecuperarSenha;

        public RecuperarSenhaBS()
        {
            _dbRecuperarSenha = new RecuperarSenhaRepository();
        }

        public Usuario ValidateToken(string token)
        {
            try
            {
                var user = _dbRecuperarSenha.ValidateToken(token);
                return user;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public Usuario SendEmailNewPassword(string userName, string urlDomain)
        {
            try
            {
                UsuarioBS usuarioBS = new UsuarioBS();
                Usuario usuario = usuarioBS.GetByUserName(userName);
                Guid token = Guid.NewGuid();

                RecuperarSenha recuperarSenha = new RecuperarSenha
                {
                    ID_USUARIO = usuario.ID_USUARIO,
                    PRIVATE_TOKEN = token.ToString(),
                    ALTERADO_SENHA = false,
                };

                _dbRecuperarSenha.Add(recuperarSenha);

                StringBuilder body = new StringBuilder();



                body.AppendLine($"<p>Olá { usuario.NOME_USUARIO }</p>");
                body.AppendLine($"<p>Acesse o link abaixo ou copie e cole esse url no navegador {urlDomain}/AlterarSenha/?token={token} </p>");
                body.AppendLine($"<a href=\"{urlDomain}/AlterarSenha/?token={token}\" >Alterar Senha</a>");
                body.AppendLine("");

                EmailManagement.Send("seguranca@chaveirokis.com.br", usuario.EMAIL_USUARIO, "Reupera senha | KIS", body.ToString());

                return usuario;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AtualizaSenha(Usuario usuario)
        {
            try
            {
                UsuarioRepository usuarioRepository = new UsuarioRepository();
                usuarioRepository.Update(usuario);

                _dbRecuperarSenha.CloseTokens(usuario.ID_USUARIO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Save(RecuperarSenha recuperarSenha)
        {
            try
            {
                _dbRecuperarSenha.Add(recuperarSenha);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(RecuperarSenha recuperarSenha)
        {
            try
            {
                _dbRecuperarSenha.Update(recuperarSenha);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
