using Ecommerce.Entity;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Full Name")]
        public string FullName { get; set; } =string.Empty;

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; } = string.Empty;

        [Required]
        [StringLength(10, ErrorMessage = "{0} alanı en az {2} karakter içermelidir.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Parolalarınız birbiriyle eşleşmiyor.")]
        [Display(Name = "Password")]
        public string ConfirmPassword { get; set; } = string.Empty;

    }
}
