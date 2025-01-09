using ScopedService.ServiceContracts;
using ScopedService.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IShoppingCartService, ShoppingCartService>();
var app = builder.Build();
app.UseRouting();
app.MapControllers();

app.Run();
