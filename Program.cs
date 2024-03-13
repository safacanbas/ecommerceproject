using Ecommerce.Data.Abstract;
using Ecommerce.Data.Concrete;
using Ecommerce.Data.Concrete.EfCore;
using Ecommerce.Entity;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ProductContext>(options => { options.UseSqlite(builder.Configuration["ConnectionStrings:Sql_connection"]); });

builder.Services.AddIdentity<User, Role>().AddEntityFrameworkStores<ProductContext>().AddDefaultTokenProviders();

builder.Services.AddScoped<IProductRepository, EfProductRepository>();
builder.Services.AddScoped<ICommentRepository, EfCommentRepository>();
builder.Services.AddScoped<IUserRepository, EfUserRepository>();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie();

builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireUppercase = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequiredLength = 6;
});

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.UseAuthorization();

SeedData.TestVerileri(app);
app.MapControllerRoute(
    name: "profile",
    pattern: "Profile/{name}",
    defaults: new { controller = "Users", action = "Profile" });

app.MapControllerRoute(
    name: "product_detail",
    pattern: "Product/productDetail/{url}",
    defaults: new {controller = "Product", action = "productDetail" });

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
