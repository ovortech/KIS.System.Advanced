using AutoMapper;
using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.MVC.Support;
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

        [HttpPost]
        public ActionResult Logar(LoginVM loginVM)
        {
            try
            {
                //if (!ModelState.IsValid)
                //{
                //    return View(loginVM);
                //}

                var usuario = AutoMapper.Mapper.Map<Usuario>(loginVM);
                _usuarioService.Logar(usuario);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
