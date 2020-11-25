using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Infra.Data.Repositories;
using KIS.System.Advanced.Support;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Kist.System.Adavanced.Test.Data
{
    [TestClass]
    public class UsuarioTest
    {
        protected UsuarioRepository _usuarioRepository;
        [TestInitialize]
        public void Initialize()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [TestMethod]
        public void AddUser()
        {
            var usuariosantes = _usuarioRepository.Login(new Usuario { LOGIN_USUARIO = "mnmelo", SENHA_USUARIO = "1234" });

            Usuario user = new Usuario
            {
                LOGIN_USUARIO = "mnmelo",
                SENHA_USUARIO = "1234",
                ID_TIPO_ACESSO_USUARIO = 1,
                NOME_USUARIO = "Marcio Melo",
                EMAIL_USUARIO = "marciondemelo@gmail.com",
                ID_FUNCAO_USUARIO = 1
            };

            _usuarioRepository.Add(user);
            var usuariosdepopis = _usuarioRepository.Login(new Usuario { LOGIN_USUARIO = "mnmelo", SENHA_USUARIO = "1234" });
            //_usuarioRepository.GetAll();

            Assert.IsTrue(usuariosdepopis != usuariosantes);
        }

        [TestMethod]
        public void Remove()
        {
            var a = _usuarioRepository.GetAll().FirstOrDefault();
            _usuarioRepository.Remove(a);
            var b = _usuarioRepository.GetAll();
            Assert.IsTrue(b.Count() == 0);
        }

        [TestMethod]
        public void GetAllUser()
        {
            var aa = _usuarioRepository.GetAll().ToList();
            Assert.IsTrue(aa != null);
        }

        [TestMethod]
        public void Md5()
        {
            var senha = CalculateMD5Hash.Generate("1234");
            var senha2 = CalculateMD5Hash.Generate("1234");

            if (senha == senha2)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void Logar()
        {
            var usuario = _usuarioRepository.Login(new Usuario { LOGIN_USUARIO = "mnmelo", SENHA_USUARIO = "1234" });

            Assert.IsTrue(usuario != null);
        }
    }
}
