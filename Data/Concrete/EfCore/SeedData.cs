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

                if (!context.Users.Any())
                {
                    context.Users.AddRange(
                        new User { Name = "safacanbas", FullName = "Safa Can BAŞ", Email = "info@safacanbas.com", Password = "123456789", UserImage = "userImage.jpg"},
                        new User { Name = "çakılefendi", FullName = "Çakıl Efendi", Email = "info@cakilefendi.com", Password = "987654321", UserImage = "userImage_1.jpg" },
                        new User { Name = "eymentürk", FullName = "Eymen Türk", Email = "info@eymentürk.com", Password = "159753", UserImage = "userImage_2.jpg" }
                    );
                    context.SaveChanges();
                }

                if (!context.Products.Any())
                {
                    context.Products.AddRange(
                        new Product
                        {
                            ProductName = "Lufian Todillo Erkek Sweatshirt Siyah",
                            Image = "product_1/1.jpeg",
                            ImageDetail_1 = "product_1/2.jpeg",
                            ImageDetail_2 = "product_1/3.jpeg",
                            Description = "Kampanya fiyatından satılmak üzere 100 adetten fazla stok sunulmuştur.\r\nİncelemiş olduğunuz ürünün satış fiyatını satıcı belirlemektedir.\r\nBir ürün, birden fazla satıcı tarafından satılabilir. Birden fazla satıcı tarafından satışa sunulan ürünlerin satıcıları ürün için belirledikleri fiyata, satıcı puanlarına, teslimat statülerine, ürünlerdeki promosyonlara, kargonun bedava olup olmamasına ve ürünlerin hızlı teslimat ile teslim edilip edilememesine, ürünlerin stok ve kategorileri bilgilerine göre sıralanmaktadır.\r\nBu üründen en fazla 10 adet sipariş verilebilir.Belirlenen bu limit kurumsal siparişlerde geçerli olmayıp, kurumsal siparişler için farklı limitler belirlenebilmektedir.\r\n15 gün içinde ücretsiz iade. Detaylı bilgi için tıklayın.",
                            Materials = "60% cotton",
                            Dimensions = "110 x 33 x 100 cm",
                            Size = "S",
                            Color = "Red",
                            Piece = 1,
                            Price = 1600.64,
                            IsActive = true,
                            UserId = 1,
                            Url = "Lufian-Todillo-Erkek-Sweatshirt-Siyah",
                            Comments = new List<Comment>
                            {
                                new Comment
                                {
                                    Text = "Güzel. Çok beğendim.",
                                    PublishedOn = DateTime.Now,
                                    ProductId = 1,
                                    UserId = 1
                                }
                            }
                        },
                        new Product
                        {
                            ProductName = "Lufian Star Erkek Sweatshirt Açık Gri",
                            Image = "product_2/1.jpeg",
                            ImageDetail_1 = "product_2/2.jpeg",
                            ImageDetail_2 = "product_2/3.jpeg",
                            Description = "Kampanya fiyatından satılmak üzere 100 adetten fazla stok sunulmuştur.\r\nİncelemiş olduğunuz ürünün satış fiyatını satıcı belirlemektedir.\r\nBir ürün, birden fazla satıcı tarafından satılabilir. Birden fazla satıcı tarafından satışa sunulan ürünlerin satıcıları ürün için belirledikleri fiyata, satıcı puanlarına, teslimat statülerine, ürünlerdeki promosyonlara, kargonun bedava olup olmamasına ve ürünlerin hızlı teslimat ile teslim edilip edilememesine, ürünlerin stok ve kategorileri bilgilerine göre sıralanmaktadır.\r\nBu üründen en fazla 10 adet sipariş verilebilir.Belirlenen bu limit kurumsal siparişlerde geçerli olmayıp, kurumsal siparişler için farklı limitler belirlenebilmektedir.\r\n15 gün içinde ücretsiz iade. Detaylı bilgi için tıklayın.",
                            Materials = "60% cotton",
                            Dimensions = "110 x 33 x 100 cm",
                            Size = "L",
                            Color = "Blue",
                            Piece = 5,
                            Price = 3500.31,
                            IsActive = true,
                            UserId = 1,
                            Url = "Lufian-Star-Erkek-Sweatshirt-Acik-Gri",
                            Comments = new List<Comment>
                            {
                                new Comment{
                                    Text = "Güzel. Çok beğendim.",
                                    PublishedOn = DateTime.Now.AddDays(-7),
                                    ProductId = 1,
                                    UserId = 1
                                }
                            }
                        },
                        new Product
                        {
                            ProductName = "Lufian Lowe Erkek Sweatshirt Siyah",
                            Image = "product_3/1.jpeg",
                            ImageDetail_1 = "product_3/2.jpeg",
                            ImageDetail_2 = "product_3/3.jpeg",
                            Description = "Kampanya fiyatından satılmak üzere 100 adetten fazla stok sunulmuştur.\r\nİncelemiş olduğunuz ürünün satış fiyatını satıcı belirlemektedir.\r\nBir ürün, birden fazla satıcı tarafından satılabilir. Birden fazla satıcı tarafından satışa sunulan ürünlerin satıcıları ürün için belirledikleri fiyata, satıcı puanlarına, teslimat statülerine, ürünlerdeki promosyonlara, kargonun bedava olup olmamasına ve ürünlerin hızlı teslimat ile teslim edilip edilememesine, ürünlerin stok ve kategorileri bilgilerine göre sıralanmaktadır.\r\nBu üründen en fazla 10 adet sipariş verilebilir.Belirlenen bu limit kurumsal siparişlerde geçerli olmayıp, kurumsal siparişler için farklı limitler belirlenebilmektedir.\r\n15 gün içinde ücretsiz iade. Detaylı bilgi için tıklayın.",
                            Materials = "60% cotton",
                            Dimensions = "110 x 33 x 100 cm",
                            Size = "L",
                            Color = "Blue",
                            Piece = 5,
                            Price = 2548.50,
                            IsActive = true,
                            UserId = 1,
                            Url = "Lufian-Lowe-Erkek-Sweatshirt-Siyah"
,                            Comments = new List<Comment>
                            {
                                new Comment{
                                    Text = "Güzel. Çok beğendim.",
                                    PublishedOn = DateTime.Now.AddDays(-7),
                                    ProductId = 1,
                                    UserId = 1
                                }
                            }
                        },
                        new Product
                        {
                            ProductName = "Lufian Fınn Modern Grafik T- Shirt Beyaz",
                            Image = "product_4/1.jpeg",
                            ImageDetail_1 = "product_4/2.jpeg",
                            ImageDetail_2 = "product_4/3.jpeg",
                            Description = "Kampanya fiyatından satılmak üzere 100 adetten fazla stok sunulmuştur.\r\nİncelemiş olduğunuz ürünün satış fiyatını satıcı belirlemektedir.\r\nBir ürün, birden fazla satıcı tarafından satılabilir. Birden fazla satıcı tarafından satışa sunulan ürünlerin satıcıları ürün için belirledikleri fiyata, satıcı puanlarına, teslimat statülerine, ürünlerdeki promosyonlara, kargonun bedava olup olmamasına ve ürünlerin hızlı teslimat ile teslim edilip edilememesine, ürünlerin stok ve kategorileri bilgilerine göre sıralanmaktadır.\r\nBu üründen en fazla 10 adet sipariş verilebilir.Belirlenen bu limit kurumsal siparişlerde geçerli olmayıp, kurumsal siparişler için farklı limitler belirlenebilmektedir.\r\n15 gün içinde ücretsiz iade. Detaylı bilgi için tıklayın.",
                            Materials = "60% cotton",
                            Dimensions = "110 x 33 x 100 cm",
                            Size = "L",
                            Color = "Blue",
                            Piece = 5,
                            Price = 757.00,
                            IsActive = true,
                            UserId = 1,
                            Url = "Lufian-Finn-Modern-Grafik-T-Shirt-Beyaz",
                            Comments = new List<Comment>
                            {
                                new Comment{
                                    Text = "Güzel. Çok beğendim.",
                                    PublishedOn = DateTime.Now.AddDays(-7),
                                    ProductId = 1,
                                    UserId = 1
                                }
                            }
                        },
                        new Product
                        {
                            ProductName = "Mavi Logo Baskılı Lacivert Tişört Oversize / Geniş Kesim",
                            Image = "product_5/1.jpeg",
                            ImageDetail_1 = "product_5/2.jpeg",
                            ImageDetail_2 = "product_5/3.jpeg",
                            Description = "Kampanya fiyatından satılmak üzere 100 adetten fazla stok sunulmuştur.\r\nİncelemiş olduğunuz ürünün satış fiyatını satıcı belirlemektedir.\r\nBir ürün, birden fazla satıcı tarafından satılabilir. Birden fazla satıcı tarafından satışa sunulan ürünlerin satıcıları ürün için belirledikleri fiyata, satıcı puanlarına, teslimat statülerine, ürünlerdeki promosyonlara, kargonun bedava olup olmamasına ve ürünlerin hızlı teslimat ile teslim edilip edilememesine, ürünlerin stok ve kategorileri bilgilerine göre sıralanmaktadır.\r\nBu üründen en fazla 10 adet sipariş verilebilir.Belirlenen bu limit kurumsal siparişlerde geçerli olmayıp, kurumsal siparişler için farklı limitler belirlenebilmektedir.\r\n15 gün içinde ücretsiz iade. Detaylı bilgi için tıklayın.",
                            Materials = "60% cotton",
                            Dimensions = "110 x 33 x 100 cm",
                            Size = "L",
                            Color = "Blue",
                            Piece = 5,
                            Price = 344.75,
                            IsActive = true,
                            UserId = 1,
                            Url = "Mavi-Logo-Baskili-Lacivert-Tisort-Oversize-Genis-Kesim",
                            Comments = new List<Comment>
                            {
                                new Comment{
                                    Text = "Güzel. Çok beğendim.",
                                    PublishedOn = DateTime.Now.AddDays(-7),
                                    ProductId = 1,
                                    UserId = 1
                                }
                            }
                        },
                        new Product
                        {
                            ProductName = "Mavi Logo Baskılı Kapüşonlu Kırmızı Sweatshirt",
                            Image = "product_6/1.jpeg",
                            ImageDetail_1 = "product_6/2.jpeg",
                            ImageDetail_2 = "product_6/3.jpeg",
                            Description = "Kampanya fiyatından satılmak üzere 100 adetten fazla stok sunulmuştur.\r\nİncelemiş olduğunuz ürünün satış fiyatını satıcı belirlemektedir.\r\nBir ürün, birden fazla satıcı tarafından satılabilir. Birden fazla satıcı tarafından satışa sunulan ürünlerin satıcıları ürün için belirledikleri fiyata, satıcı puanlarına, teslimat statülerine, ürünlerdeki promosyonlara, kargonun bedava olup olmamasına ve ürünlerin hızlı teslimat ile teslim edilip edilememesine, ürünlerin stok ve kategorileri bilgilerine göre sıralanmaktadır.\r\nBu üründen en fazla 10 adet sipariş verilebilir.Belirlenen bu limit kurumsal siparişlerde geçerli olmayıp, kurumsal siparişler için farklı limitler belirlenebilmektedir.\r\n15 gün içinde ücretsiz iade. Detaylı bilgi için tıklayın.",
                            Materials = "60% cotton",
                            Dimensions = "110 x 33 x 100 cm",
                            Size = "L",
                            Color = "Blue",
                            Piece = 5,
                            Price = 933.20,
                            IsActive = true,
                            UserId = 1,
                            Url = "Mavi-Logo-Baskili-Kapuonlu-Kirmizi-Sweatshirt",
                            Comments = new List<Comment>
                            {
                                new Comment{
                                    Text = "Güzel. Çok beğendim.",
                                    PublishedOn = DateTime.Now.AddDays(-7),
                                    ProductId = 1,
                                    UserId = 1
                                }
                            }
                        },
                        new Product
                        {
                            ProductName = "Mavi Victoria Simsiyah Gold Icon Jean Pantolon",
                            Image = "product_7/1.jpeg",
                            ImageDetail_1 = "product_7/2.jpeg",
                            ImageDetail_2 = "product_7/3.jpeg",
                            Description = "Kampanya fiyatından satılmak üzere 100 adetten fazla stok sunulmuştur.\r\nİncelemiş olduğunuz ürünün satış fiyatını satıcı belirlemektedir.\r\nBir ürün, birden fazla satıcı tarafından satılabilir. Birden fazla satıcı tarafından satışa sunulan ürünlerin satıcıları ürün için belirledikleri fiyata, satıcı puanlarına, teslimat statülerine, ürünlerdeki promosyonlara, kargonun bedava olup olmamasına ve ürünlerin hızlı teslimat ile teslim edilip edilememesine, ürünlerin stok ve kategorileri bilgilerine göre sıralanmaktadır.\r\nBu üründen en fazla 10 adet sipariş verilebilir.Belirlenen bu limit kurumsal siparişlerde geçerli olmayıp, kurumsal siparişler için farklı limitler belirlenebilmektedir.\r\n15 gün içinde ücretsiz iade. Detaylı bilgi için tıklayın.",
                            Materials = "60% cotton",
                            Dimensions = "110 x 33 x 100 cm",
                            Size = "L",
                            Color = "Blue",
                            Piece = 5,
                            Price = 524.66,
                            IsActive = true,
                            UserId = 1,
                            Url = "Mavi-Victoria-Simsiyah-Gold-Icon-Jean-Pantolon",
                            Comments = new List<Comment>
                            {
                                new Comment{
                                    Text = "Güzel. Çok beğendim.",
                                    PublishedOn = DateTime.Now.AddDays(-7),
                                    ProductId = 1,
                                    UserId = 1
                                }
                            }
                        },
                        new Product
                        {
                            ProductName = "Mavi Star Kolej Indigo Si Jean Pantolon",
                            Image = "product_8/1.jpeg",
                            ImageDetail_1 = "product_8/2.jpeg",
                            ImageDetail_2 = "product_8/3.jpeg",
                            Description = "Kampanya fiyatından satılmak üzere 100 adetten fazla stok sunulmuştur.\r\nİncelemiş olduğunuz ürünün satış fiyatını satıcı belirlemektedir.\r\nBir ürün, birden fazla satıcı tarafından satılabilir. Birden fazla satıcı tarafından satışa sunulan ürünlerin satıcıları ürün için belirledikleri fiyata, satıcı puanlarına, teslimat statülerine, ürünlerdeki promosyonlara, kargonun bedava olup olmamasına ve ürünlerin hızlı teslimat ile teslim edilip edilememesine, ürünlerin stok ve kategorileri bilgilerine göre sıralanmaktadır.\r\nBu üründen en fazla 10 adet sipariş verilebilir.Belirlenen bu limit kurumsal siparişlerde geçerli olmayıp, kurumsal siparişler için farklı limitler belirlenebilmektedir.\r\n15 gün içinde ücretsiz iade. Detaylı bilgi için tıklayın.",
                            Materials = "60% cotton",
                            Dimensions = "110 x 33 x 100 cm",
                            Size = "L",
                            Color = "Blue",
                            Piece = 5,
                            Price = 1833.96,
                            IsActive = true,
                            UserId = 1,
                            Url = "Mavi-Star-Kolej-Indigo-Si-Jean-Pantolon",
                            Comments = new List<Comment>
                            {
                                new Comment{
                                    Text = "Güzel. Çok beğendim.",
                                    PublishedOn = DateTime.Now.AddDays(-7),
                                    ProductId = 1,
                                    UserId = 1
                                }
                            }
                        },
                        new Product
                        {
                            ProductName = "Mavi Logo Baskılı Çizgili Tişört Regular Fit / Normal Kesim",
                            Image = "product_9/1.jpeg",
                            ImageDetail_1 = "product_9/2.jpeg",
                            ImageDetail_2 = "product_9/3.jpeg",
                            Description = "Kampanya fiyatından satılmak üzere 100 adetten fazla stok sunulmuştur.\r\nİncelemiş olduğunuz ürünün satış fiyatını satıcı belirlemektedir.\r\nBir ürün, birden fazla satıcı tarafından satılabilir. Birden fazla satıcı tarafından satışa sunulan ürünlerin satıcıları ürün için belirledikleri fiyata, satıcı puanlarına, teslimat statülerine, ürünlerdeki promosyonlara, kargonun bedava olup olmamasına ve ürünlerin hızlı teslimat ile teslim edilip edilememesine, ürünlerin stok ve kategorileri bilgilerine göre sıralanmaktadır.\r\nBu üründen en fazla 10 adet sipariş verilebilir.Belirlenen bu limit kurumsal siparişlerde geçerli olmayıp, kurumsal siparişler için farklı limitler belirlenebilmektedir.\r\n15 gün içinde ücretsiz iade. Detaylı bilgi için tıklayın.",
                            Materials = "60% cotton",
                            Dimensions = "110 x 33 x 100 cm",
                            Size = "L",
                            Color = "Blue",
                            Piece = 5,
                            Price = 7575.00,
                            IsActive = true,
                            UserId = 1,
                            Url = "Mavi-Logo-Baskili-Cizgili-Tisort-Regular-Fit-Normal-Kesim",
                            Comments = new List<Comment>
                            {
                                new Comment{
                                    Text = "Güzel. Çok beğendim.",
                                    PublishedOn = DateTime.Now.AddDays(-7),
                                    ProductId = 1,
                                    UserId = 1
                                }
                            }
                        },
                        new Product
                        {
                            ProductName = "Lufian Tommy Erkek Deri Sneaker Ayakkabı Siyah",
                            Image = "product_10/1.jpeg",
                            ImageDetail_1 = "product_10/2.jpeg",
                            ImageDetail_2 = "product_10/3.jpeg",
                            Description = "Kampanya fiyatından satılmak üzere 100 adetten fazla stok sunulmuştur.\r\nİncelemiş olduğunuz ürünün satış fiyatını satıcı belirlemektedir.\r\nBir ürün, birden fazla satıcı tarafından satılabilir. Birden fazla satıcı tarafından satışa sunulan ürünlerin satıcıları ürün için belirledikleri fiyata, satıcı puanlarına, teslimat statülerine, ürünlerdeki promosyonlara, kargonun bedava olup olmamasına ve ürünlerin hızlı teslimat ile teslim edilip edilememesine, ürünlerin stok ve kategorileri bilgilerine göre sıralanmaktadır.\r\nBu üründen en fazla 10 adet sipariş verilebilir.Belirlenen bu limit kurumsal siparişlerde geçerli olmayıp, kurumsal siparişler için farklı limitler belirlenebilmektedir.\r\n15 gün içinde ücretsiz iade. Detaylı bilgi için tıklayın.",
                            Materials = "60% cotton",
                            Dimensions = "110 x 33 x 100 cm",
                            Size = "L",
                            Color = "Blue",
                            Piece = 5,
                            Price = 2557.85,
                            IsActive = true,
                            UserId = 1,
                            Url = "Lufian-Tommy-Erkek-Deri-Sneaker-Ayakkabi-Siyah",
                            Comments = new List<Comment>
                            {
                                new Comment{
                                    Text = "Güzel. Çok beğendim.",
                                    PublishedOn = DateTime.Now.AddDays(-7),
                                    ProductId = 1,
                                    UserId = 1
                                }
                            }
                        },
                        new Product
                        {
                            ProductName = "Lufian Jeremy Erkek Eşofman Altı Siyah",
                            Image = "product_11/1.jpeg",
                            ImageDetail_1 = "product_11/2.jpeg",
                            ImageDetail_2 = "product_11/3.jpeg",
                            Description = "Kampanya fiyatından satılmak üzere 100 adetten fazla stok sunulmuştur.\r\nİncelemiş olduğunuz ürünün satış fiyatını satıcı belirlemektedir.\r\nBir ürün, birden fazla satıcı tarafından satılabilir. Birden fazla satıcı tarafından satışa sunulan ürünlerin satıcıları ürün için belirledikleri fiyata, satıcı puanlarına, teslimat statülerine, ürünlerdeki promosyonlara, kargonun bedava olup olmamasına ve ürünlerin hızlı teslimat ile teslim edilip edilememesine, ürünlerin stok ve kategorileri bilgilerine göre sıralanmaktadır.\r\nBu üründen en fazla 10 adet sipariş verilebilir.Belirlenen bu limit kurumsal siparişlerde geçerli olmayıp, kurumsal siparişler için farklı limitler belirlenebilmektedir.\r\n15 gün içinde ücretsiz iade. Detaylı bilgi için tıklayın.",
                            Materials = "60% cotton",
                            Dimensions = "110 x 33 x 100 cm",
                            Size = "L",
                            Color = "Blue",
                            Piece = 5,
                            Price = 6345.16,
                            IsActive = true,
                            UserId = 1,
                            Url = "Lufian-Jeremy-Erkek-Esofman-Alti-Siyah",
                            Comments = new List<Comment>
                            {
                                new Comment{
                                    Text = "Güzel. Çok beğendim.",
                                    PublishedOn = DateTime.Now.AddDays(-7),
                                    ProductId = 1,
                                    UserId = 1
                                }
                            }
                        },
                        new Product
                        {
                            ProductName = "Lufian Alexander Erkek Sweatshirt Siyah",
                            Image = "product_12/1.jpeg",
                            ImageDetail_1 = "product_12/2.jpeg",
                            ImageDetail_2 = "product_12/3.jpeg",
                            Description = "Kampanya fiyatından satılmak üzere 100 adetten fazla stok sunulmuştur.\r\nİncelemiş olduğunuz ürünün satış fiyatını satıcı belirlemektedir.\r\nBir ürün, birden fazla satıcı tarafından satılabilir. Birden fazla satıcı tarafından satışa sunulan ürünlerin satıcıları ürün için belirledikleri fiyata, satıcı puanlarına, teslimat statülerine, ürünlerdeki promosyonlara, kargonun bedava olup olmamasına ve ürünlerin hızlı teslimat ile teslim edilip edilememesine, ürünlerin stok ve kategorileri bilgilerine göre sıralanmaktadır.\r\nBu üründen en fazla 10 adet sipariş verilebilir.Belirlenen bu limit kurumsal siparişlerde geçerli olmayıp, kurumsal siparişler için farklı limitler belirlenebilmektedir.\r\n15 gün içinde ücretsiz iade. Detaylı bilgi için tıklayın.",
                            Materials = "60% cotton",
                            Dimensions = "110 x 33 x 100 cm",
                            Size = "L",
                            Color = "Blue",
                            Piece = 5,
                            Price = 6543.16,
                            IsActive = true,
                            UserId = 1,
                            Url = "Lufian-Alexander-Erkek-Sweatshirt-Siyah",
                            Comments = new List<Comment>
                            {
                                new Comment{
                                    Text = "Güzel. Çok beğendim.",
                                    PublishedOn = DateTime.Now.AddDays(-7),
                                    ProductId = 1,
                                    UserId = 1
                                }
                            }
                        },
                        new Product
                        {
                            ProductName = "Lufian Star Erkek Sweatshirt Antrasit",
                            Image = "product_13/1.jpeg",
                            ImageDetail_1 = "product_13/2.jpeg",
                            ImageDetail_2 = "product_13/3.jpeg",
                            Description = "Kampanya fiyatından satılmak üzere 100 adetten fazla stok sunulmuştur.\r\nİncelemiş olduğunuz ürünün satış fiyatını satıcı belirlemektedir.\r\nBir ürün, birden fazla satıcı tarafından satılabilir. Birden fazla satıcı tarafından satışa sunulan ürünlerin satıcıları ürün için belirledikleri fiyata, satıcı puanlarına, teslimat statülerine, ürünlerdeki promosyonlara, kargonun bedava olup olmamasına ve ürünlerin hızlı teslimat ile teslim edilip edilememesine, ürünlerin stok ve kategorileri bilgilerine göre sıralanmaktadır.\r\nBu üründen en fazla 10 adet sipariş verilebilir.Belirlenen bu limit kurumsal siparişlerde geçerli olmayıp, kurumsal siparişler için farklı limitler belirlenebilmektedir.\r\n15 gün içinde ücretsiz iade. Detaylı bilgi için tıklayın.",
                            Materials = "60% cotton",
                            Dimensions = "110 x 33 x 100 cm",
                            Size = "L",
                            Color = "Blue",
                            Piece = 5,
                            Price = 1853.49,
                            IsActive = true,
                            UserId = 1,
                            Url = "Lufian-Star-Erkek-Sweatshirt-Antrasit",
                            Comments = new List<Comment>
                            {
                                new Comment{
                                    Text = "Güzel. Çok beğendim.",
                                    PublishedOn = DateTime.Now.AddDays(-7),
                                    ProductId = 1,
                                    UserId = 1
                                }
                            }
                        },
                        new Product
                        {
                            ProductName = "Lufian Laggero Triko Spor Ayakkabı Siyah",
                            Image = "product_14/1.jpeg",
                            ImageDetail_1 = "product_14/2.jpeg",
                            ImageDetail_2 = "product_14/3.jpeg",
                            Description = "Kampanya fiyatından satılmak üzere 100 adetten fazla stok sunulmuştur.\r\nİncelemiş olduğunuz ürünün satış fiyatını satıcı belirlemektedir.\r\nBir ürün, birden fazla satıcı tarafından satılabilir. Birden fazla satıcı tarafından satışa sunulan ürünlerin satıcıları ürün için belirledikleri fiyata, satıcı puanlarına, teslimat statülerine, ürünlerdeki promosyonlara, kargonun bedava olup olmamasına ve ürünlerin hızlı teslimat ile teslim edilip edilememesine, ürünlerin stok ve kategorileri bilgilerine göre sıralanmaktadır.\r\nBu üründen en fazla 10 adet sipariş verilebilir.Belirlenen bu limit kurumsal siparişlerde geçerli olmayıp, kurumsal siparişler için farklı limitler belirlenebilmektedir.\r\n15 gün içinde ücretsiz iade. Detaylı bilgi için tıklayın.",
                            Materials = "60% cotton",
                            Dimensions = "110 x 33 x 100 cm",
                            Size = "L",
                            Color = "Blue",
                            Piece = 5,
                            Price = 5584.79,
                            IsActive = true,
                            UserId = 1,
                            Url = "Lufian-Laggero-Triko-Spor-Ayakkabi-Siyah",
                            Comments = new List<Comment>
                            {
                                new Comment{
                                    Text = "Güzel. Çok beğendim.",
                                    PublishedOn = DateTime.Now.AddDays(-7),
                                    ProductId = 1,
                                    UserId = 1
                                }
                            }
                        },
                        new Product
                        {
                            ProductName = "Lufian Nora Smart Erkek Polo Tişört Siyah",
                            Image = "product_15/1.jpeg",
                            ImageDetail_1 = "product_15/2.jpeg",
                            ImageDetail_2 = "product_15/3.jpeg",
                            Description = "Kampanya fiyatından satılmak üzere 100 adetten fazla stok sunulmuştur.\r\nİncelemiş olduğunuz ürünün satış fiyatını satıcı belirlemektedir.\r\nBir ürün, birden fazla satıcı tarafından satılabilir. Birden fazla satıcı tarafından satışa sunulan ürünlerin satıcıları ürün için belirledikleri fiyata, satıcı puanlarına, teslimat statülerine, ürünlerdeki promosyonlara, kargonun bedava olup olmamasına ve ürünlerin hızlı teslimat ile teslim edilip edilememesine, ürünlerin stok ve kategorileri bilgilerine göre sıralanmaktadır.\r\nBu üründen en fazla 10 adet sipariş verilebilir.Belirlenen bu limit kurumsal siparişlerde geçerli olmayıp, kurumsal siparişler için farklı limitler belirlenebilmektedir.\r\n15 gün içinde ücretsiz iade. Detaylı bilgi için tıklayın.",
                            Materials = "60% cotton",
                            Dimensions = "110 x 33 x 100 cm",
                            Size = "L",
                            Color = "Blue",
                            Piece = 5,
                            Price = 8436.85,
                            IsActive = true,
                            UserId = 1,
                            Url = "Lufian-Nora-Smart-Erkek-Polo-Tisort-Siyah",
                            Comments = new List<Comment>
                            {
                                new Comment{
                                    Text = "Güzel. Çok beğendim.",
                                    PublishedOn = DateTime.Now.AddDays(-7),
                                    ProductId = 1,
                                    UserId = 1
                                }
                            }
                        },
                        new Product
                        {
                            ProductName = "Mavi Kapüşonlu Gri Ceket Oversize / Geniş Kesim",
                            Image = "product_16/1.jpeg",
                            ImageDetail_1 = "product_16/2.jpeg",
                            ImageDetail_2 = "product_16/3.jpeg",
                            Description = "Kampanya fiyatından satılmak üzere 100 adetten fazla stok sunulmuştur.\r\nİncelemiş olduğunuz ürünün satış fiyatını satıcı belirlemektedir.\r\nBir ürün, birden fazla satıcı tarafından satılabilir. Birden fazla satıcı tarafından satışa sunulan ürünlerin satıcıları ürün için belirledikleri fiyata, satıcı puanlarına, teslimat statülerine, ürünlerdeki promosyonlara, kargonun bedava olup olmamasına ve ürünlerin hızlı teslimat ile teslim edilip edilememesine, ürünlerin stok ve kategorileri bilgilerine göre sıralanmaktadır.\r\nBu üründen en fazla 10 adet sipariş verilebilir.Belirlenen bu limit kurumsal siparişlerde geçerli olmayıp, kurumsal siparişler için farklı limitler belirlenebilmektedir.\r\n15 gün içinde ücretsiz iade. Detaylı bilgi için tıklayın.",
                            Materials = "60% cotton",
                            Dimensions = "110 x 33 x 100 cm",
                            Size = "L",
                            Color = "Blue",
                            Piece = 5,
                            Price = 2958.64,
                            IsActive = true,
                            UserId = 1,
                            Url = "Mavi-Kapuonlu-Gri-Ceket-Oversize-Genis-Kesim",
                            Comments = new List<Comment>
                            {
                                new Comment{
                                    Text = "Güzel. Çok beğendim.",
                                    PublishedOn = DateTime.Now.AddDays(-7),
                                    ProductId = 1,
                                    UserId = 1
                                }
                            }
                        },
                        new Product
                        {
                            ProductName = "Mavi Serenay Gold Shape Indigo Si Jean Pantolon",
                            Image = "product_17/1.jpeg",
                            ImageDetail_1 = "product_17/2.jpeg",
                            ImageDetail_2 = "product_17/3.jpeg",
                            Description = "Kampanya fiyatından satılmak üzere 100 adetten fazla stok sunulmuştur.\r\nİncelemiş olduğunuz ürünün satış fiyatını satıcı belirlemektedir.\r\nBir ürün, birden fazla satıcı tarafından satılabilir. Birden fazla satıcı tarafından satışa sunulan ürünlerin satıcıları ürün için belirledikleri fiyata, satıcı puanlarına, teslimat statülerine, ürünlerdeki promosyonlara, kargonun bedava olup olmamasına ve ürünlerin hızlı teslimat ile teslim edilip edilememesine, ürünlerin stok ve kategorileri bilgilerine göre sıralanmaktadır.\r\nBu üründen en fazla 10 adet sipariş verilebilir.Belirlenen bu limit kurumsal siparişlerde geçerli olmayıp, kurumsal siparişler için farklı limitler belirlenebilmektedir.\r\n15 gün içinde ücretsiz iade. Detaylı bilgi için tıklayın.",
                            Materials = "60% cotton",
                            Dimensions = "110 x 33 x 100 cm",
                            Size = "L",
                            Color = "Blue",
                            Piece = 5,
                            Price = 5758.64,
                            IsActive = true,
                            UserId = 1,
                            Url = "Mavi-Serenay-Gold-Shape-Indigo-Si-Jean-Pantolon",
                            Comments = new List<Comment>
                            {
                                new Comment{
                                    Text = "Güzel. Çok beğendim.",
                                    PublishedOn = DateTime.Now.AddDays(-7),
                                    ProductId = 1,
                                    UserId = 1
                                }
                            }
                        },
                        new Product
                        {
                            ProductName = "Mavi Kapüşonlu Siyah Şişme Mont ",
                            Image = "product_18/1.jpeg",
                            ImageDetail_1 = "product_18/2.jpeg",
                            ImageDetail_2 = "product_18/3.jpeg",
                            Description = "Kampanya fiyatından satılmak üzere 100 adetten fazla stok sunulmuştur.\r\nİncelemiş olduğunuz ürünün satış fiyatını satıcı belirlemektedir.\r\nBir ürün, birden fazla satıcı tarafından satılabilir. Birden fazla satıcı tarafından satışa sunulan ürünlerin satıcıları ürün için belirledikleri fiyata, satıcı puanlarına, teslimat statülerine, ürünlerdeki promosyonlara, kargonun bedava olup olmamasına ve ürünlerin hızlı teslimat ile teslim edilip edilememesine, ürünlerin stok ve kategorileri bilgilerine göre sıralanmaktadır.\r\nBu üründen en fazla 10 adet sipariş verilebilir.Belirlenen bu limit kurumsal siparişlerde geçerli olmayıp, kurumsal siparişler için farklı limitler belirlenebilmektedir.\r\n15 gün içinde ücretsiz iade. Detaylı bilgi için tıklayın.",
                            Materials = "60% cotton",
                            Dimensions = "110 x 33 x 100 cm",
                            Size = "L",
                            Color = "Blue",
                            Piece = 5,
                            Price = 2748.64,
                            IsActive = true,
                            UserId = 1,
                            Url = "Mavi-Kapuonlu-Siyah-Sisme-Mont",
                            Comments = new List<Comment>
                            {
                                new Comment{
                                    Text = "Güzel. Çok beğendim.",
                                    PublishedOn = DateTime.Now.AddDays(-7),
                                    ProductId = 1,
                                    UserId = 1
                                }
                            }
                        },
                        new Product
                        {
                            ProductName = "Lufian Vera Kadin Örme Sweatshirt Siyah",
                            Image = "product_19/1.jpeg",
                            ImageDetail_1 = "product_19/2.jpeg",
                            ImageDetail_2 = "product_19/3.jpeg",
                            Description = "Kampanya fiyatından satılmak üzere 100 adetten fazla stok sunulmuştur.\r\nİncelemiş olduğunuz ürünün satış fiyatını satıcı belirlemektedir.\r\nBir ürün, birden fazla satıcı tarafından satılabilir. Birden fazla satıcı tarafından satışa sunulan ürünlerin satıcıları ürün için belirledikleri fiyata, satıcı puanlarına, teslimat statülerine, ürünlerdeki promosyonlara, kargonun bedava olup olmamasına ve ürünlerin hızlı teslimat ile teslim edilip edilememesine, ürünlerin stok ve kategorileri bilgilerine göre sıralanmaktadır.\r\nBu üründen en fazla 10 adet sipariş verilebilir.Belirlenen bu limit kurumsal siparişlerde geçerli olmayıp, kurumsal siparişler için farklı limitler belirlenebilmektedir.\r\n15 gün içinde ücretsiz iade. Detaylı bilgi için tıklayın.",
                            Materials = "60% cotton",
                            Dimensions = "110 x 33 x 100 cm",
                            Size = "L",
                            Color = "Blue",
                            Piece = 5,
                            Price = 558.64,
                            IsActive = true,
                            UserId = 1,
                            Url = "Lufian-Vera-Kadin-Orme-Sweatshirt-Siyah",
                            Comments = new List<Comment>
                            {
                                new Comment{
                                    Text = "Güzel. Çok beğendim.",
                                    PublishedOn = DateTime.Now.AddDays(-7),
                                    ProductId = 1,
                                    UserId = 1
                                }
                            }
                        },
                        new Product
                        {
                            ProductName = "Lufian Ujin Kadin Örme Sweatshirt Siyah",
                            Image = "product_20/1.jpeg",
                            ImageDetail_1 = "product_20/2.jpeg",
                            ImageDetail_2 = "product_20/3.jpeg",
                            Description = "Kampanya fiyatından satılmak üzere 100 adetten fazla stok sunulmuştur.\r\nİncelemiş olduğunuz ürünün satış fiyatını satıcı belirlemektedir.\r\nBir ürün, birden fazla satıcı tarafından satılabilir. Birden fazla satıcı tarafından satışa sunulan ürünlerin satıcıları ürün için belirledikleri fiyata, satıcı puanlarına, teslimat statülerine, ürünlerdeki promosyonlara, kargonun bedava olup olmamasına ve ürünlerin hızlı teslimat ile teslim edilip edilememesine, ürünlerin stok ve kategorileri bilgilerine göre sıralanmaktadır.\r\nBu üründen en fazla 10 adet sipariş verilebilir.Belirlenen bu limit kurumsal siparişlerde geçerli olmayıp, kurumsal siparişler için farklı limitler belirlenebilmektedir.\r\n15 gün içinde ücretsiz iade. Detaylı bilgi için tıklayın.",
                            Materials = "60% cotton",
                            Dimensions = "110 x 33 x 100 cm",
                            Size = "L",
                            Color = "Blue",
                            Piece = 5,
                            Price = 9858.64,
                            IsActive = true,
                            UserId = 1,
                            Url = "Lufian-Ujin-Kadin-Orme-Sweatshirt-Siyah",
                            Comments = new List<Comment>
                            {
                                new Comment{
                                    Text = "Güzel. Çok beğendim.",
                                    PublishedOn = DateTime.Now.AddDays(-7),
                                    ProductId = 1,
                                    UserId = 1
                                }
                            }
                        },
                        new Product
                        {
                            ProductName = "Lufian Edward Spor Polo Erkek Tişört Beyaz",
                            Image = "product_21/1.jpeg",
                            ImageDetail_1 = "product_21/2.jpeg",
                            ImageDetail_2 = "product_21/3.jpeg",
                            Description = "Kampanya fiyatından satılmak üzere 100 adetten fazla stok sunulmuştur.\r\nİncelemiş olduğunuz ürünün satış fiyatını satıcı belirlemektedir.\r\nBir ürün, birden fazla satıcı tarafından satılabilir. Birden fazla satıcı tarafından satışa sunulan ürünlerin satıcıları ürün için belirledikleri fiyata, satıcı puanlarına, teslimat statülerine, ürünlerdeki promosyonlara, kargonun bedava olup olmamasına ve ürünlerin hızlı teslimat ile teslim edilip edilememesine, ürünlerin stok ve kategorileri bilgilerine göre sıralanmaktadır.\r\nBu üründen en fazla 10 adet sipariş verilebilir.Belirlenen bu limit kurumsal siparişlerde geçerli olmayıp, kurumsal siparişler için farklı limitler belirlenebilmektedir.\r\n15 gün içinde ücretsiz iade. Detaylı bilgi için tıklayın.",
                            Materials = "60% cotton",
                            Dimensions = "110 x 33 x 100 cm",
                            Size = "L",
                            Color = "Blue",
                            Piece = 5,
                            Price = 4788.64,
                            IsActive = true,
                            UserId = 1,
                            Url = "Lufian-Edward-Spor-Polo-Erkek-Tisort-Beyaz",
                            Comments = new List<Comment>
                            {
                                new Comment{
                                    Text = "Güzel. Çok beğendim.",
                                    PublishedOn = DateTime.Now.AddDays(-7),
                                    ProductId = 1,
                                    UserId = 1
                                }
                            }
                        },
                        new Product
                        {
                            ProductName = "Lufian Never Erkek Sweatshirt Lacivert",
                            Image = "product_22/1.jpeg",
                            ImageDetail_1 = "product_22/2.jpeg",
                            ImageDetail_2 = "product_22/3.jpeg",
                            Description = "Kampanya fiyatından satılmak üzere 100 adetten fazla stok sunulmuştur.\r\nİncelemiş olduğunuz ürünün satış fiyatını satıcı belirlemektedir.\r\nBir ürün, birden fazla satıcı tarafından satılabilir. Birden fazla satıcı tarafından satışa sunulan ürünlerin satıcıları ürün için belirledikleri fiyata, satıcı puanlarına, teslimat statülerine, ürünlerdeki promosyonlara, kargonun bedava olup olmamasına ve ürünlerin hızlı teslimat ile teslim edilip edilememesine, ürünlerin stok ve kategorileri bilgilerine göre sıralanmaktadır.\r\nBu üründen en fazla 10 adet sipariş verilebilir.Belirlenen bu limit kurumsal siparişlerde geçerli olmayıp, kurumsal siparişler için farklı limitler belirlenebilmektedir.\r\n15 gün içinde ücretsiz iade. Detaylı bilgi için tıklayın.",
                            Materials = "60% cotton",
                            Dimensions = "110 x 33 x 100 cm",
                            Size = "L",
                            Color = "Blue",
                            Piece = 5,
                            Price = 4548.64,
                            IsActive = true,
                            UserId = 1,
                            Url = "Lufian-Never-Erkek-Sweatshirt-Lacivert",
                            Comments = new List<Comment>
                            {
                                new Comment{
                                    Text = "Güzel. Çok beğendim.",
                                    PublishedOn = DateTime.Now.AddDays(-7),
                                    ProductId = 1,
                                    UserId = 1
                                }
                            }
                        },
                        new Product
                        {
                            ProductName = "Lufian Paul Sneaker Beyaz",
                            Image = "product_23/1.jpeg",
                            ImageDetail_1 = "product_23/2.jpeg",
                            ImageDetail_2 = "product_23/3.jpeg",
                            Description = "Kampanya fiyatından satılmak üzere 100 adetten fazla stok sunulmuştur.\r\nİncelemiş olduğunuz ürünün satış fiyatını satıcı belirlemektedir.\r\nBir ürün, birden fazla satıcı tarafından satılabilir. Birden fazla satıcı tarafından satışa sunulan ürünlerin satıcıları ürün için belirledikleri fiyata, satıcı puanlarına, teslimat statülerine, ürünlerdeki promosyonlara, kargonun bedava olup olmamasına ve ürünlerin hızlı teslimat ile teslim edilip edilememesine, ürünlerin stok ve kategorileri bilgilerine göre sıralanmaktadır.\r\nBu üründen en fazla 10 adet sipariş verilebilir.Belirlenen bu limit kurumsal siparişlerde geçerli olmayıp, kurumsal siparişler için farklı limitler belirlenebilmektedir.\r\n15 gün içinde ücretsiz iade. Detaylı bilgi için tıklayın.",
                            Materials = "60% cotton",
                            Dimensions = "110 x 33 x 100 cm",
                            Size = "L",
                            Color = "Blue",
                            Piece = 5,
                            Price = 658.64,
                            IsActive = true,
                            UserId = 1,
                            Url = "Lufian-Paul-Sneaker-Beyaz",
                            Comments = new List<Comment>
                            {
                                new Comment{
                                    Text = "Güzel. Çok beğendim.",
                                    PublishedOn = DateTime.Now.AddDays(-7),
                                    ProductId = 1,
                                    UserId = 1
                                }
                            }
                        },
                        new Product
                        {
                            ProductName = "Lufian Jeremy Erkek Eşofman Altı Lacivert",
                            Image = "product_24/1.jpeg",
                            ImageDetail_1 = "product_24/2.jpeg",
                            ImageDetail_2 = "product_24/3.jpeg",
                            Description = "Kampanya fiyatından satılmak üzere 100 adetten fazla stok sunulmuştur.\r\nİncelemiş olduğunuz ürünün satış fiyatını satıcı belirlemektedir.\r\nBir ürün, birden fazla satıcı tarafından satılabilir. Birden fazla satıcı tarafından satışa sunulan ürünlerin satıcıları ürün için belirledikleri fiyata, satıcı puanlarına, teslimat statülerine, ürünlerdeki promosyonlara, kargonun bedava olup olmamasına ve ürünlerin hızlı teslimat ile teslim edilip edilememesine, ürünlerin stok ve kategorileri bilgilerine göre sıralanmaktadır.\r\nBu üründen en fazla 10 adet sipariş verilebilir.Belirlenen bu limit kurumsal siparişlerde geçerli olmayıp, kurumsal siparişler için farklı limitler belirlenebilmektedir.\r\n15 gün içinde ücretsiz iade. Detaylı bilgi için tıklayın.",
                            Materials = "60% cotton",
                            Dimensions = "110 x 33 x 100 cm",
                            Size = "L",
                            Color = "Blue",
                            Piece = 5,
                            Price = 8549.64,
                            IsActive = true,
                            UserId = 1,
                            Url = "Lufian-Jeremy-Erkek-Esofman-Alti-Lacivert",
                            Comments = new List<Comment>
                            {
                                new Comment{
                                    Text = "Güzel. Çok beğendim.",
                                    PublishedOn = DateTime.Now.AddDays(-7),
                                    ProductId = 1,
                                    UserId = 1
                                }
                            }
                        }
                    );
                    context.SaveChanges();
                }

            }
        }
    }
}