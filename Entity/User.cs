using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Entity
{
    public class User : IdentityUser
    {
        public string? FullName { get; set; }
        public string? UserImage { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}