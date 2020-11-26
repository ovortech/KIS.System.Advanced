using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.MVC.Support;
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
    public class DespesaController : CustomControllerBase<DespesaVM>
    {
        #region PROPRIEDADES / CONSTRUTOR

        private readonly IDespesaService _despesaService;
        private readonly ITipoDespesaService _tipoDespesaService;

        public DespesaController(IDespesaService despesaService, ITipoDespesaService tipoDespesaService)
        {
            _despesaService = despesaService;
            _tipoDespesaService = tipoDespesaService;
        }

        #endregion

        [CustomAuthorize(IsPermission = AcessRole.ADMIN)]
        public ActionResult Index()
        {
            var despesasVM = CarregaDependenciasDespesa();
            return View(despesasVM);
        }

        [CustomAuthorize(IsPermission = AcessRole.ADMIN)]
        public PartialViewResult AddOrEdit(int id)
        {
            if (id == 0)
                return PartialView(new DespesaVM());
            else
            {
                var despesa = _despesaService.Get(id);
                var despesaVM = AutoMapper.Mapper.Map<DespesaVM>(despesa);
                return PartialView(despesaVM);
            }
        }
        [HttpPost]
        [CustomAuthorize(IsPermission = AcessRole.ADMIN)]
        public JsonResult Save(DespesaVM despesaVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var despesa = AutoMapper.Mapper.Map<Despesa>(despesaVM);
                    despesa.ATIVO = true;
                    if (despesa.ID_DESPESA > 0)
                        _despesaService.Update(despesa);
                    else
                        _despesaService.Save(despesa);
                    return Json(new { isValid = true });
                }
                else
                {
                    return Json(new { isValid = false, model = despesaVM });
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        [CustomAuthorize(IsPermission = AcessRole.ADMIN)]
        public JsonResult Get(int idDespesa)
        {
            var despesa = _despesaService.Get(idDespesa);
            var despesaVM = AutoMapper.Mapper.Map<DespesaVM>(despesa);
            return Json(despesaVM, JsonRequestBehavior.AllowGet);
        }
        private List<DespesaVM> CarregaDependenciasDespesa()
        {
            var despesas = _despesaService.GetAllActive();
            var despesasVM = AutoMapper.Mapper.Map<List<DespesaVM>>(despesas);

            foreach (DespesaVM despesa in despesasVM)
            {
                var tipoDespesa = _tipoDespesaService.GetById(despesa.IdTipoDespesa);
                var tipoDespesaVM = AutoMapper.Mapper.Map<TipoDespesaVM>(tipoDespesa);
                despesa.TipoDespesa = tipoDespesaVM;
            }

            return despesasVM;
        }

    }
}