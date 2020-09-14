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
        private readonly ILoginService _loginService;

        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }
        // GET: Login
        public ActionResult Index()
        {
            var loginmodel = _loginService.Logar(new Login());

            var logins = Mapper.Map<List<LoginVM>>(loginmodel);
           
            return View(logins.FirstOrDefault());
        }

        [HttpPost]
        public ActionResult Logar(LoginVM loginVM)
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
    }
}
