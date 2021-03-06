﻿using KIS.System.Advanced.Domain.Dto;
using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Domain.Interfaces;
using KIS.System.Advanced.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KIS.System.Advanced.Infra.Data.Repositories
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(ProjetoDataContext db = null) : base(db)
        {

        }

        public Usuario Login(Usuario usuario)
        {
            var result = (from user in Db.Usuarios
                          join funcao in Db.Funcoes
                             on user.ID_FUNCAO_USUARIO equals funcao.ID_FUNCAO
                          join tipoAcesso in Db.TipoAcessos
                             on user.ID_TIPO_ACESSO_USUARIO equals tipoAcesso.ID_TIPO_ACESSO
                          where user.LOGIN_USUARIO.ToLower() == usuario.LOGIN_USUARIO.ToLower() && user.SENHA_USUARIO == usuario.SENHA_USUARIO
                          select new
                          {
                              ID_USUARIO = user.ID_USUARIO,
                              LOGIN_USUARIO = user.LOGIN_USUARIO,
                              SENHA_USUARIO = user.SENHA_USUARIO,
                              NOME_USUARIO = user.NOME_USUARIO,
                              ID_TIPO_ACESSO_USUARIO = user.ID_TIPO_ACESSO_USUARIO,
                              EMAIL_USUARIO = user.EMAIL_USUARIO,
                              ID_FUNCAO_USUARIO = user.ID_FUNCAO_USUARIO,
                              TipoAcesso = tipoAcesso,
                              Funcao = funcao
                          }).FirstOrDefault();

            if (result == null)
                return null;

            Usuario userLogado = new Usuario
            {
                ID_USUARIO = result.ID_USUARIO,
                LOGIN_USUARIO = result.LOGIN_USUARIO,
                SENHA_USUARIO = result.SENHA_USUARIO,
                NOME_USUARIO = result.NOME_USUARIO,
                ID_TIPO_ACESSO_USUARIO = result.ID_TIPO_ACESSO_USUARIO,
                EMAIL_USUARIO = result.EMAIL_USUARIO,
                ID_FUNCAO_USUARIO = result.ID_FUNCAO_USUARIO,
                Funcao = result.Funcao,
                TipoAcessos = result.TipoAcesso

            };

            return userLogado;
        }

        public Usuario GetByUserName(string userName)
        {
            var usuario = Db.Usuarios.Where(x => x.LOGIN_USUARIO.ToLower() == userName.ToLower()).FirstOrDefault();
            return usuario;
        }

    }
}
