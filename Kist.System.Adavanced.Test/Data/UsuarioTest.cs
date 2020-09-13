using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Infra.Data.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
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
            var sss = _usuarioRepository.BuscarPorNome("mar");
            var aaa = sss.ToList();
            var usuariosantes = _usuarioRepository.GetAll();
            Usuario user = new Usuario
            {
                Nome = "Gomes Gomes",
                Email = "gomes@gmail.com",
                CargoId = 1,
                Sexo = "M",
                Ativo = true
            };

            _usuarioRepository.Add(user);
            var usuariosdepopis = _usuarioRepository.GetAll();

            Assert.IsTrue(usuariosantes.Count() < usuariosdepopis.Count());
        }


        [TestMethod]
        public void GetAllUser()
        {
            var aa = _usuarioRepository.GetAll().ToList();
            Assert.IsTrue(aa != null);
        }
    }
}
