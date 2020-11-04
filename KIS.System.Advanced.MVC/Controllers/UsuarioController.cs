using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.MVC.Support;
using KIS.System.Advanced.MVC.Support.Security;
using KIS.System.Advanced.MVC.ViewModels;
using KIS.System.Advanced.Services.Interfaces;

namespace KIS.System.Advanced.MVC.Controllers
{
    public class UsuarioController : CustomControllerBase<UsuarioVM>
    {
        #region PROPRIEDADES / CONSTRUTOR

        private readonly IUsuarioService _usuarioService;
        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        #endregion

        [CustomAuthorize(IsPermission = AcessRole.ADMIN)]
        public ActionResult Index()
        {
            var usuarios = _usuarioService.GetAll();
            var usuariosVM = AutoMapper.Mapper.Map<List<UsuarioVM>>(usuarios);
            return View(usuariosVM);
        }

        [CustomAuthorize(IsPermission = AcessRole.ADMIN)]
        public JsonResult Get(int idUsuario)
        {
            var usuario = _usuarioService.Get(idUsuario);
            var produtoVM = AutoMapper.Mapper.Map<UsuarioVM>(usuario);
            return Json(produtoVM, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [CustomAuthorize(IsPermission = AcessRole.ADMIN)]
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

        [CustomAuthorize(IsPermission = AcessRole.ADMIN | AcessRole.VENDAS)]
        public PartialViewResult AddOrEdit(int id)
        {
            var result = new UsuarioVM();
            return PartialView(result);
        }

        // POST: Usuario/Delete/5
        [HttpPost]
        [CustomAuthorize(IsPermission = AcessRole.ADMIN)]
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
