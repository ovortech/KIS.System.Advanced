using System.ComponentModel.DataAnnotations;

namespace KIS.System.Advanced.MVC.ViewModels
{
    public class LoginVM
    {
        [Required]
        [Display(Name ="Usuario")]
        public string UserName { get; set; }

        [StringLength(20, ErrorMessage = "A {0} precisa ter pelo menos {2} catacteres", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name ="Senha")]
        [Required]
        public string Password { get; set; }
    }
}