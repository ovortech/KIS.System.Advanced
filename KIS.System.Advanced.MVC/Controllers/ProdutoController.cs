﻿using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.MVC.Support;
using KIS.System.Advanced.MVC.Support.Security;
using KIS.System.Advanced.MVC.ViewModels;
using KIS.System.Advanced.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KIS.System.Advanced.MVC.Controllers
{
    public class ProdutoController : CustomControllerBase
    {
        #region PROPRIEDADES / CONSTRUTOR

        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        #endregion

        [CustomAuthorize(IsPermission = AcessRole.ADMIN | AcessRole.VENDAS)]
        public ActionResult Index()
        {
            var produtos = _produtoService.GetAll();
            var produtosVM = AutoMapper.Mapper.Map<List<ProdutoVM>>(produtos);
            return View(produtosVM);
        }

        [CustomAuthorize(IsPermission = AcessRole.ADMIN | AcessRole.VENDAS)]
        public JsonResult Get(int idProduto)
        {
            var produto = _produtoService.Get(idProduto);
            var produtoVM = AutoMapper.Mapper.Map<ProdutoVM>(produto);
            return Json(produtoVM, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [CustomAuthorize(IsPermission = AcessRole.ADMIN | AcessRole.VENDAS)]
        public ActionResult Save(ProdutoVM produtoVM)
        {
            try
            {
                var produto = AutoMapper.Mapper.Map<Produto>(produtoVM);
                if (produto.ID_PRODUTO > 0)
                    _produtoService.Update(produto);
                else
                    _produtoService.Save(produto);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                throw;
            }
        }

        // POST: Produto/Delete/5
        [HttpPost]
        [CustomAuthorize(IsPermission = AcessRole.ADMIN | AcessRole.VENDAS)]
        public ActionResult Delete(int idProduto)
        {
            try
            {
                _produtoService.Delete(idProduto);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
