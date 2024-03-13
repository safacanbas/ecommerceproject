using Ecommerce.Entity;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; } = null!;

        [Required]
        [StringLength(10, ErrorMessage = "{0} alanı en az {2} karakter içermelidir.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; } = null!;
        public bool RememberMe { get; set; } = true;
    }
}
