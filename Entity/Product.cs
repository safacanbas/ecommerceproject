using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Entity
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? Image { get; set; }
        public string? Description { get; set; }
        public string? Size { get; set; }
        public string? Color { get; set; }
        public int Piece { get; set; }
        public double Price { get; set; }
        public bool IsActive { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}