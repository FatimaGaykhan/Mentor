using Mentor3.DataAccessLayer;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer("Server=localhost,1433;Database=mentor3;User Id=sa;Password=Salam123");
});
var app = builder.Build();

app.UseStaticFiles();
app.MapControllerRoute("default", "{controller=contact}/{action=index}/{id?}");

app.Run();
