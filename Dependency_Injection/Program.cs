using Dependency_Injection.Services;

var builder = WebApplication.CreateBuilder(args);

//register the message service
builder.Services.AddScoped<IMessageService, SimpleMessageService>();

builder.Services.AddControllersWithViews();

var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();
app.MapControllers();
app.Run();
