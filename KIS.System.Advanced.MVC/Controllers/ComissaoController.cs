﻿using KIS.System.Advanced.MVC.Support.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KIS.System.Advanced.MVC.Controllers
{
    public class ComissaoController : Controller
    {
        // GET: Comissao
        [CustomAuthorize(Roles = "ADMIN, VENDAS")]
        public ActionResult Index()
        {
            return View();
        }
    }
}