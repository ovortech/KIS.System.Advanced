using KIS.System.Advanced.MVC.Support;
using KIS.System.Advanced.MVC.Support.Security;
using KIS.System.Advanced.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KIS.System.Advanced.MVC.Controllers
{
    public class ClienteController : CustomControllerBase<ClienteVM>
    {
        // GET: Cliente
        [CustomAuthorize(IsPermission = AcessRole.ADMIN | AcessRole.VENDAS)]
        public ActionResult Index()
        {         
            return View();
        }


        [CustomAuthorize(IsPermission = AcessRole.ADMIN | AcessRole.VENDAS)]
        public PartialViewResult AddOrEdit(int id)
        {
            var result = new ClienteVM();
            return PartialView(result);
        }

    }
}