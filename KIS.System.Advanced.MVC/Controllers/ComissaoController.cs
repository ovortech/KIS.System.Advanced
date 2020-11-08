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
    public class ComissaoController : CustomControllerBase<ComissaoVM>
    {
        // GET: Comissao
        [CustomAuthorize(IsPermission = Support.AcessRole.ADMIN | AcessRole.VENDAS)]
        public ActionResult Index()
        {
            List<ComissaoVM> comissaoVM = new List<ComissaoVM>()
            {
                new ComissaoVM{
                    Id = 1,
                    TipoVenda = "Produto",
                    NomeProduto = "produto 1",
                    DataVenda = DateTime.Now,
                    Descricao = "produto para tipos de produtos produtados produtivamente",
                    Quantidade = 2,
                    ValorVenda = 15.90,
                    ValorCustoUnitario = 5.90,
                    ValorLucro = 0,
                    PercComissao = 5,
                    Pago = false
                },
                new ComissaoVM{
                    Id = 2,
                    TipoVenda = "Serviço",
                    NomeProduto = "Serviço 1",
                    DataVenda = DateTime.Now,
                    Descricao = "Serviço para tipos de serviços serviçados serviçadamente",
                    Quantidade = 1,
                    ValorVenda = 350.00,
                    ValorCustoUnitario = 0,
                    ValorLucro = 0,
                    PercComissao = 10,
                    Pago = false
                },
                new ComissaoVM{
                    Id = 3,
                    TipoVenda = "Produto",
                    NomeProduto = "produto 2",
                    DataVenda = DateTime.Now,
                    Descricao = "produto 2 para  2 tipos de produtos  2 produtados produtivamente",
                    Quantidade = 3,
                    ValorVenda = 35.00,
                    ValorCustoUnitario = 7.90,
                    ValorLucro = 0,
                    PercComissao = 5,
                    Pago = false
                }
            };
            return View(comissaoVM);
        }


        [CustomAuthorize(IsPermission = AcessRole.ADMIN | AcessRole.VENDAS)]
        public PartialViewResult AddOrEdit(int id)
        {
            var result = new ComissaoVM();
            return PartialView(result);
        }

    }
}