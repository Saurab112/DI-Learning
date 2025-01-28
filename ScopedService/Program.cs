using ScopedService.ServiceContracts;
using ScopedService.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IShoppingCartService, ShoppingCartService>();
builder.Services.AddScoped<IEmailNotificationService, EmailNotificationService>();
builder.Services.AddScoped<ILogger<ShoppingCartService>, Logger<ShoppingCartService>>(); // Logger for ShoppingCartService
var app = builder.Build();
app.UseRouting();
app.MapControllers();

app.Run();
