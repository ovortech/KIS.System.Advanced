using KIS.System.Advanced.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KIS.System.Advanced.MVC.Controllers.Acesso
{
    public class AlterarSenhaController : Controller
    {
        private IRecuperarSenhaService _recuperarSenhaService;

        public AlterarSenhaController(IRecuperarSenhaService recuperarSenhaService)
        {
            _recuperarSenhaService = recuperarSenhaService;
        }
        // GET: AlterarSenha        
        public ActionResult Index(string token)
        {
            var usuario = _recuperarSenhaService.ValidateToken(token);
            ViewBag.token = token;
            return View(usuario);
        }

        public JsonResult NovaSenha(string token, string senha1, string senha2)
        {
            var usuario = _recuperarSenhaService.ValidateToken(token);
            if (usuario == null)
                return Json("Erro ao validar usuario");

            if (senha1 != senha2)
                return Json("senha errad");
            else
            {
                usuario.SENHA_USUARIO = senha1;
                _recuperarSenhaService.NovaSenha(usuario);
            }

            return Json("sucesso");
        }

    }
}