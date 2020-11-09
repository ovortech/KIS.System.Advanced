using KIS.System.Advanced.MVC.Support;
using KIS.System.Advanced.MVC.Support.Security;
using KIS.System.Advanced.MVC.ViewModels;
using KIS.System.Advanced.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading;

namespace KIS.System.Advanced.MVC.Controllers
{
    public class ComissaoController : CustomControllerBase<ComissaoVM>
    {
        #region PROPRIEDADES / CONSTRUTOR

        private readonly IComissaoService _comissaoService;

        public ComissaoController(IComissaoService comissaoService)
        {
            _comissaoService = comissaoService;
        }

        #endregion
        // GET: Comissao
        [CustomAuthorize(IsPermission = Support.AcessRole.ADMIN | AcessRole.VENDAS)]
        public ActionResult Index()
        {
            List<ComissaoVM> comissaoVM = new List<ComissaoVM>();
            comissaoVM = AutoMapper.Mapper.Map<List<ComissaoVM>>(_comissaoService.GetDto());

            return View(comissaoVM);
        }


        [CustomAuthorize(IsPermission = AcessRole.ADMIN | AcessRole.VENDAS)]
        [HttpPost]
        public JsonResult Save(ComissaoVM comissaoVM)
        {            
            var comissao = AutoMapper.Mapper.Map<KIS.System.Advanced.Domain.Entities.Comissao>(comissaoVM);
            _comissaoService.Save(comissao);
            return Json(new { IsValide = false });
        }

    }
}