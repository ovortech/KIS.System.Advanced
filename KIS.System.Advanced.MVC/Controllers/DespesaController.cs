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
            var despesaVM = CarregaDependenciasDespesa();
            return View(despesaVM);
        }


        [CustomAuthorize(IsPermission = AcessRole.ADMIN)]
        public PartialViewResult AddOrEdit(int id)
        {
            var result = new DespesaVM();
            return PartialView(result);
        }

        private DespesaVM CarregaDependenciasDespesa()
        {
            var despesa = new DespesaVM();

            var tipoDespesas = _tipoDespesaService.GetAllActive();
            var tipoDespesasVM = AutoMapper.Mapper.Map<List<TipoDespesaVM>>(tipoDespesas);
            despesa.TiposDespesa = tipoDespesasVM;

            var despesas = _despesaService.GetAllActive();
            var despesasVM = AutoMapper.Mapper.Map<List<DespesaVM>>(despesas);
            despesa.Despesas = despesasVM;

            return despesa;
        }

    }
}