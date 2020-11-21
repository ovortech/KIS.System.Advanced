using System.ComponentModel.DataAnnotations;

namespace KIS.System.Advanced.MVC.ViewModels
{
    public class ClienteVM
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Nome Cliente")]
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
    }
}