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
using System.Data;

namespace KIS.System.Advanced.MVC.Controllers
{
    public class ComissaoController : CustomControllerBase<ComissaoVM>
    {
        #region PROPRIEDADES / CONSTRUTOR

        private readonly IComissaoService _comissaoService;
        private readonly IVendedorService _vendedorService;
        private static List<VendedorVM> vendedores { get; set; }
        public ComissaoController(IComissaoService comissaoService, IVendedorService vendedorService)
        {
            _comissaoService = comissaoService;
            _vendedorService = vendedorService;
        }

        #endregion
        // GET: Comissao
        //[CustomAuthorize(IsPermission = Support.AcessRole.ADMIN)]
        //public ActionResult Index()
        //{

        //    return View(new List<ComissaoVM>());
        //}

        [CustomAuthorize(IsPermission = Support.AcessRole.ADMIN | AcessRole.VENDAS)]
        [HttpGet]
        public ActionResult Index(ComissaoVM comissoes)
        {
            ViewBag.hoje = DateTime.Now.Date;
            ViewBag.Vendedores = vendedores = AutoMapper.Mapper.Map<List<VendedorVM>>(_vendedorService.GetAllActive());
            return View(comissoes ?? new ComissaoVM());
        }


        [CustomAuthorize(IsPermission = AcessRole.ADMIN | AcessRole.VENDAS)]
        [HttpPost]
        public PartialViewResult FiltraComissao(int idVendedor, String dataInicio, String dataFim)
        {
            DateTime dtInicio = dataInicio.ParseDateTimeBrToUs();
            DateTime dtFim = dataFim.ParseDateTimeBrToUs();
            List<ComissaoVM> comissoes = new List<ComissaoVM>();
            if (idVendedor != 0)
            {
                comissoes = AutoMapper.Mapper.Map<List<ComissaoVM>>(_comissaoService.GetDto(idVendedor, dtInicio, dtFim));
            }
            return PartialView(comissoes);
        }


        [CustomAuthorize(IsPermission = AcessRole.ADMIN)]
        [HttpPost]
        public JsonResult Save(ComissaoVM comissaoVM)
        {
            try
            {
                var comissao = AutoMapper.Mapper.Map<KIS.System.Advanced.Domain.Entities.Comissao>(comissaoVM);
                comissao.DATA_PAGAMENTO_COMISSAO = comissao.DATA_PAGAMENTO_COMISSAO == DateTime.MinValue ? null : comissao.DATA_PAGAMENTO_COMISSAO;
                _comissaoService.Save(comissao);
                return Json(new { IsValide = true });
            }
            catch (Exception)
            {
                return Json(new { IsValide = false });
            }
        }

    }
}