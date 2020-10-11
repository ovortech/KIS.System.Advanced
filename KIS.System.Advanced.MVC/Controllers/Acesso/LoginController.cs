using AutoMapper;
using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.MVC.Support;
using KIS.System.Advanced.MVC.Support.Security;
using KIS.System.Advanced.MVC.ViewModels;
using KIS.System.Advanced.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KIS.System.Advanced.MVC.Controllers.Acesso
{
    public class LoginController : Controller
    {
        private readonly IUsuarioService _usuarioService;

        public LoginController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        //é nois o/
        [HttpPost]
        public JsonResult Logar(LoginVM loginVM)
        {
            try
            {
                //if (!ModelState.IsValid)
                //{
                //    return View(loginVM);
                //}

                var usuarioLogado = _usuarioService.Logar(AutoMapper.Mapper.Map<Usuario>(loginVM));
                SessionPersister.User = new CustomPrincipal(usuarioLogado);
                return Json("Sucesso");
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }

        //é nois o/
        [HttpGet]
        public RedirectToRouteResult Deslogar()
        {
            SessionPersister.Deslogar();
            return RedirectToAction("Index", "Home");
        }
    }
}
