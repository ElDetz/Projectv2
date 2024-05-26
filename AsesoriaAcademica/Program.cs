using AsesoriaAcademica.Models;
using AsesoriaAcademica.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.DependencyEF();
//{
//    optionsBuilder.
//    UseSqlServer("server=DESKTOP-BTD8DEL;database=GestionAsesoriaAcademica;Integrated Security=True;Encrypt=False");

//});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
