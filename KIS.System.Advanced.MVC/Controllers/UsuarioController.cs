using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.MVC.Support.Security;
using KIS.System.Advanced.MVC.ViewModels;
using KIS.System.Advanced.Services.Interfaces;

namespace KIS.System.Advanced.MVC.Controllers
{
    public class UsuarioController : Controller
    {
        #region PROPRIEDADES / CONSTRUTOR

        private readonly IUsuarioService _usuarioService;
        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        #endregion

        [CustomAuthorize(Roles = "ADMIN, VENDAS")]
        public ActionResult Index()
        {
            var usuarios = _usuarioService.GetAll();
            var usuariosVM = AutoMapper.Mapper.Map<List<UsuarioVM>>(usuarios);
            return View(usuariosVM);
        }

        [CustomAuthorize(Roles = "ADMIN, VENDAS")]
        public JsonResult Get(int idUsuario)
        {
            var usuario = _usuarioService.Get(idUsuario);
            var produtoVM = AutoMapper.Mapper.Map<UsuarioVM>(usuario);
            return Json(produtoVM, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [CustomAuthorize(Roles = "ADMIN, VENDAS")]
        public ActionResult Save(UsuarioVM usuarioVM)
        {
            try
            {
                var usuario = AutoMapper.Mapper.Map<Usuario>(usuarioVM);
                usuario.SENHA_USUARIO = string.Empty;
                if (usuario.ID_USUARIO > 0)
                    _usuarioService.Update(usuario);
                else
                    _usuarioService.Save(usuario);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                throw;
            }
        }

        // POST: Usuario/Delete/5
        [HttpPost]
        [CustomAuthorize(Roles = "ADMIN, VENDAS")]
        public ActionResult Delete(int idUsuario)
        {
            try
            {
                _usuarioService.Delete(idUsuario);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
