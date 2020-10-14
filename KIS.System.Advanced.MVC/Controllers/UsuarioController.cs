using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KIS.System.Advanced.MVC.Support;
using KIS.System.Advanced.MVC.Support.Security;
using KIS.System.Advanced.MVC.ViewModels;

namespace KIS.System.Advanced.MVC.Controllers
{
    public class UsuarioController : CustomControllerBase
    {
        //protected UsuarioService _usuarioService;
        //public UsuarioController()
        //{
        //    _usuarioService = new UsuarioService();
        //}

        // GET: Usuario
        [CustomAuthorize(IsPermission = AcessRole.ADMIN | AcessRole.VENDAS)]
        public ActionResult Index()
        {
            var usuarios = new List<UsuarioVM> 
            {
                new UsuarioVM { IdUsuario = 1, Email = "teste@user1.com", FuncaoUsuario = FuncaoUsuario.Gerente, Nome = "Everton1", TipoAcessos = TipoAcesso.Admin, Login = "everton1" },
                new UsuarioVM { IdUsuario = 2, Email = "teste@user2.com", FuncaoUsuario = FuncaoUsuario.Vendedor, Nome = "Everton2", TipoAcessos = TipoAcesso.Vendas, Login = "everton2" }
            };
            return View(usuarios);
        }

        // GET: Usuario/Details/5
        [CustomAuthorize(IsPermission = AcessRole.ADMIN | AcessRole.VENDAS)]
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Usuario/Create
        [CustomAuthorize(IsPermission = AcessRole.ADMIN | AcessRole.VENDAS)]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usuario/Create
        [HttpPost]
        [CustomAuthorize(IsPermission = AcessRole.ADMIN | AcessRole.VENDAS)]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuario/Edit/5
        [CustomAuthorize(IsPermission = AcessRole.ADMIN | AcessRole.VENDAS)]
        public ActionResult Edit(int id)
        {
            var usuario = new UsuarioVM { IdUsuario = id, Email = "teste@user1.com", FuncaoUsuario = FuncaoUsuario.Gerente, Nome = "Everton1", TipoAcessos = TipoAcesso.Admin, Login = "everton1" };
            return PartialView(usuario);
        }

        // POST: Usuario/Edit/5
        [HttpPost]
        [CustomAuthorize(IsPermission = AcessRole.ADMIN | AcessRole.VENDAS)]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuario/Delete/5
        [CustomAuthorize(IsPermission = AcessRole.ADMIN | AcessRole.VENDAS)]
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Usuario/Delete/5
        [HttpPost]
        [CustomAuthorize(IsPermission = Support.AcessRole.ADMIN | AcessRole.VENDAS)]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
