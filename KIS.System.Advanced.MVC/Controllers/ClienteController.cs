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
    public class ClienteController : CustomControllerBase<ClienteVM>
    {
        #region PROPRIEDADES / CONSTRUTOR

        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        #endregion

        [CustomAuthorize(IsPermission = AcessRole.ADMIN | AcessRole.VENDAS)]
        public ActionResult Index()
        {
            var clientes = _clienteService.GetAllActive();
            var clientesVM = AutoMapper.Mapper.Map<List<ClienteVM>>(clientes);
            return View(clientesVM);
        }

        [CustomAuthorize(IsPermission = AcessRole.ADMIN | AcessRole.VENDAS)]
        public JsonResult Get(int idCliente)
        {
            var cliente = _clienteService.Get(idCliente);
            var clienteVM = AutoMapper.Mapper.Map<ClienteVM>(cliente);
            return Json(clienteVM, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [CustomAuthorize(IsPermission = AcessRole.ADMIN | AcessRole.VENDAS)]
        public JsonResult Save(ClienteVM clienteVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var cliente = AutoMapper.Mapper.Map<Cliente>(clienteVM);
                    cliente.ATIVO = true;
                    if (cliente.ID_CLIENTE > 0)
                        _clienteService.Update(cliente);
                    else
                        _clienteService.Save(cliente);
                    return Json(new { isValid = true });
                }
                else
                {
                    return Json(new { isValid = false, model = clienteVM });
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        [CustomAuthorize(IsPermission = AcessRole.ADMIN | AcessRole.VENDAS)]
        public PartialViewResult AddOrEdit(int id)
        {
            if (id == 0)
                return PartialView(new ClienteVM());
            else
            {
                var cliente = _clienteService.Get(id);
                var clienteVM = AutoMapper.Mapper.Map<ClienteVM>(cliente);
                return PartialView(clienteVM);
            }
        }

        [HttpPost]
        [CustomAuthorize(IsPermission = AcessRole.ADMIN | AcessRole.VENDAS)]
        public ActionResult Delete(int idCliente)
        {
            try
            {
                _clienteService.Delete(idCliente);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}