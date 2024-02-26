using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Entity
{
    public class User
    {
        public int UserId { get; set; }
        public string? UserImage { get; set; }
        public string? Name { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}