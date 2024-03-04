using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models
{
    public class UserViewModel
    {
        [Required]
        [Display(Name = "User Full Name")]
        public string? FullName { get; set; }

        [Required]
        [Display(Name = "User Name")]
        public string? UserName { get; set; }

        [Required]
        [Display(Name = "User Image")]
        public string? UserImage { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string? Email { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "{0} alanı en az {2} karakter içermelidir.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string? Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Parolalarınız birbiriyle eşleşmiyor.")]
        [Display(Name = "Password")]
        public string? ConfirmPassword { get; set;}
    }
}
