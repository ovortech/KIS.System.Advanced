using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.WebParts;
using System.ComponentModel.DataAnnotations;

namespace KIS.System.Advanced.MVC.ViewModels
{
    public class ProdutoVM
    {
        public int IdProduto { get; set; }
        [Required]
        [Display(Name ="Nome do Produto")]
        public string NomeProduto { get; set; }
        public Boolean IsServico { get; set; }
        [Required]
        [Display(Name = "Valor do Produto")]
        public float ValorProduto { get; set; }
    }
}