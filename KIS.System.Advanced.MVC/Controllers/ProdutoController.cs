using KIS.System.Advanced.MVC.Support.Security;
using KIS.System.Advanced.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KIS.System.Advanced.MVC.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        [CustomAuthorize(Roles = "ADMIN, VENDAS")]
        public ActionResult Index()
        {
            return View();
        }

        // GET: Produto/Details/5
        [CustomAuthorize(Roles = "ADMIN, VENDAS")]
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Produto/Create
        [CustomAuthorize(Roles = "ADMIN, VENDAS")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Produto/Create
        [HttpPost]
        [CustomAuthorize(Roles = "ADMIN, VENDAS")]
        public ActionResult Create(ProdutoVM produtoVM)
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

        // GET: Produto/Edit/5
        [CustomAuthorize(Roles = "ADMIN, VENDAS")]
        public ActionResult Edit(ProdutoVM produtoVM)
        {
            return View();
        }

        // POST: Produto/Edit/5
        [HttpPost]
        [CustomAuthorize(Roles = "ADMIN, VENDAS")]
        public ActionResult Edit(int id, ProdutoVM produtoVM)
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

        // GET: Produto/Delete/5
        [CustomAuthorize(Roles = "ADMIN, VENDAS")]
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Produto/Delete/5
        [HttpPost]
        [CustomAuthorize(Roles = "ADMIN, VENDAS")]
        public ActionResult Delete(int id, ProdutoVM produtoVM)
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
