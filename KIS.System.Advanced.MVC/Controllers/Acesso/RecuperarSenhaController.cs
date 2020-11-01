using KIS.System.Advanced.MVC.Support.Security;
using KIS.System.Advanced.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KIS.System.Advanced.MVC.Controllers.Acesso
{
    public class RecuperarSenhaController : Controller
    {
        private IRecuperarSenhaService _recuperarSenhaService;

        public RecuperarSenhaController(IRecuperarSenhaService recuperarSenhaService)
        {
            _recuperarSenhaService = recuperarSenhaService;
        }
        // GET: RecuperarSenha
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SendEmail(string userName)
        {
            var usuario =_recuperarSenhaService.SendEmailNewPassword(userName);
            string email = "";
            var emailSplit = usuario.EMAIL_USUARIO.Split();
            string user = usuario.EMAIL_USUARIO.Split('@')[0];
            string dominio = usuario.EMAIL_USUARIO.Split('@')[1];
            for (int i = 0; i < user.ToCharArray().Count(); i++)
            {
                if(i < 3 || i >= (user.ToCharArray().Count() - 2))
                {
                    email += user[i];
                }
                else
                {
                    email += 'x';
                }
            }
            email += "@"+ dominio;

            return Json(email);
        }
    }
}