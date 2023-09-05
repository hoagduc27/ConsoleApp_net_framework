using System;
using asp_mvc.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);
////ghi nhat ky
//builder.Logging.ClearProviders();
//builder.Logging.AddConsole();
// Add services to the container.
builder.Services.AddDbContext<Context>(options =>
    options.UseSqlServer("Data Source=HOAGDUC27\\SQLEXPRESS;Initial Catalog=asp_net_core_mvc_db;Persist Security Info=True;User ID=sa;Password=123456;TrustServerCertificate=true;"));
builder.Services.AddControllersWithViews();

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=NhanVien" +
             "}/{action=Index}");

app.Run();
