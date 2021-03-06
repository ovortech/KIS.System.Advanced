﻿using KIS.System.Advanced.MVC.Support;
using KIS.System.Advanced.MVC.Support.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KIS.System.Advanced.MVC.Controllers
{
    
    public class HomeController : CustomControllerBase<String>
    {
        // GET: Home
        [CustomAuthorize(IsPermission = AcessRole.ADMIN | AcessRole.VENDAS)]
        public ActionResult Index()
        {
            return View();
        }
    }
}