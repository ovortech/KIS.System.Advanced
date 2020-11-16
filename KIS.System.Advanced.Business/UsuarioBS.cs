using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Domain.Interfaces;
using KIS.System.Advanced.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Business
{
    public class UsuarioBS
    {
        readonly IUsuarioRepository dbUsuario;
        public UsuarioBS()
        {
            dbUsuario = new UsuarioRepository();
        }

        public Usuario Logar(Usuario usuario)
        {
            try
            {
                var usuarioLogado = dbUsuario.Login(usuario);
                return usuarioLogado;
            }
            catch (EntityException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Usuario> GetAll()
        {
            try
            {
                return dbUsuario.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar usuários: {ex.Message}.");
            }
        }

        public List<Usuario> GetAllActive()
        {
            try
            {
                return dbUsuario.GetAllAtivos().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar usuários: {ex.Message}.");
            }
        }

        public List<Usuario> GetAllInactive()
        {
            try
            {
                return dbUsuario.GetAllInativos().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar usuários: {ex.Message}.");
            }
        }

        public void Save(Usuario usuario)
        {
            try
            {
                dbUsuario.Add(usuario);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao salvar usuário: {ex.Message}.");
            }
        }

        public Usuario Get(int idUsuario)
        {
            try
            {
                return dbUsuario.GetById(idUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar usuário: {ex.Message}.");
            }
        }

        public void Update(Usuario usuario)
        {
            try
            {
                dbUsuario.Update(usuario);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao atualizar os dados do usuário: {ex.Message}.");
            }
        }

        public void Delete(int idUsuario)
        {
            try
            {
                dbUsuario.RemoveLogic(idUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir o usuário: {ex.Message}.");
            }
        }

        internal Usuario GetByUserName(string userName)
        {
            var usuario = dbUsuario.GetByUserName(userName);
            return usuario;
        }
    }
}
