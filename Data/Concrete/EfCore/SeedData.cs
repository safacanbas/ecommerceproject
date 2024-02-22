using Ecommerce.Entity;
using Microsoft.EntityFrameworkCore;


namespace Ecommerce.Data.Concrete.EfCore
{
    public static class SeedData
    {
        public static void TestVerileriniDoldur(IApplicationBuilder app)
        {
            var context = app.ApplicationServices.CreateScope().ServiceProvider.GetService<ProductContext>();

            if (context != null)
            {
                if (context.Database.GetPendingMigrations().Any())
                {
                    context.Database.Migrate();
                }

                if (!context.Products.Any())
                {
                    context.Products.AddRange(
                        new Product
                        {
                            ProductName = "Lightweight Jacket",
                            Description = "Nulla eget sem vitae eros pharetra viverra. Nam vitae luctus ligula. Mauris consequat ornare feugiat.",
                            Size = "M",
                            Color = "Red",
                            Piece = 1,
                            Price = 5.49,
                            IsActive = true,
                            UserId = 1,
                            Comments = context.Comments.Take(3).ToList()
                        },
                        new Product
                        {
                            ProductName = "Esprit Ruffle Shirt",
                            Description = "ürün açıklaması",
                            Size = "L",
                            Color = "Blue",
                            Piece = 5,
                            Price = 15.86,
                            IsActive = true,
                            UserId = 1,
                            Comments = context.Comments.Take(3).ToList()
                        }
                    );
                    context.SaveChanges();
                }
                if (!context.Users.Any())
                {
                    context.Users.AddRange(
                        new User { UserName = "Safa Can BAŞ" },
                        new User { UserName = "Demet Yar" },
                        new User { UserName = "Fatih Dert" },
                        new User { UserName = "Karaman Salan" }
                    );
                    context.SaveChanges();
                }
                if (!context.Comments.Any())
                {
                    context.Comments.AddRange(
                        new Comment
                        {
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam nec hendrerit libero, eu efficitur ex. Vestibulum eu pulvinar sem. Nam eget pharetra diam, id lobortis leo. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Integer posuere ultricies convallis. Sed convallis faucibus dui molestie malesuada. Aenean ultricies risus nec sem faucibus dignissim. Curabitur ut metus rutrum, luctus diam sed, venenatis sem. Nulla facilisi.",
                            PublishedOn = DateTime.Now.AddDays(-7),
                            ProductId = 1,
                            UserId = 1
                        }
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}