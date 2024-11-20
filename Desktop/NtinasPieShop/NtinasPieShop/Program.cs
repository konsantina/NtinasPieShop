using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using NtinasPieShop.Models;
using NtinasPieShop.ViewModels;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IPieRepository, PieRepository>();

builder.Services.AddScoped<IShoppingCart, ShoppingCart>(sp => ShoppingCart.GetCart(sp));
builder.Services.AddScoped<ShoppingCartViewModel>();
builder.Services.AddSession();
builder.Services.AddHttpContextAccessor();  

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<NtinasPieShopDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("NtinasPieShopContextConnection")));

var app = builder.Build();

app.UseStaticFiles();
app.UseSession();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error"); // Default error page for production
    app.UseHsts();
}


// Default route for the application
app.MapDefaultControllerRoute(); //"{Controller=Home}/{action=Index}/{id?}"

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}");

DbInitializer.Seed(app);

// Run the application
app.Run();
