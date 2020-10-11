using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.MVC.Support.Security;
using KIS.System.Advanced.MVC.ViewModels;
using KIS.System.Advanced.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KIS.System.Advanced.MVC.Controllers
{
    public class ProdutoController : Controller
    {
        private IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        // GET: Produto
        [CustomAuthorize(Roles = "ADMIN, VENDAS")]
        public ActionResult Index()
        {
            var produtos = _produtoService.GetAll();
            var produtosVM = AutoMapper.Mapper.Map<List<ProdutoVM>>(produtos);
            return View(produtosVM);
        }

        // GET: Produto/Details/5
        [CustomAuthorize(Roles = "ADMIN, VENDAS")]
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Produto/Create
        [CustomAuthorize(Roles = "ADMIN, VENDAS")]
        public ActionResult Get(ProdutoVM produtoVM)
        {
            var produto = _produtoService.Get(produtoVM.IdProduto);
            return Json(produto);
        }

        // POST: Produto/Create
        [HttpPost]
        [CustomAuthorize(Roles = "ADMIN, VENDAS")]
        public RedirectToRouteResult Create(ProdutoVM produtoVM)
        {
            try
            {
                var produto = AutoMapper.Mapper.Map<Produto>(produtoVM);
                _produtoService.Save(produto);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                throw;
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
