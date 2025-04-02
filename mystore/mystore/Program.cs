using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using mystore.Models;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var provider = builder.Services.BuildServiceProvider();
var configuration = provider.GetRequiredService<IConfiguration>();
builder.Services.AddDbContext<EmployeeDBContext>(item => item.UseSqlServer(configuration.GetConnectionString("dbcs123")));


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
//app.Use(async (context1, next) =>
//{
//    await context1.Response.WriteAsync("hello this is from content1");
//    await next(context1);
//});
//app.Use(async (context1, next) =>
//{
//    await context1.Response.WriteAsync("hello this is from content2");
//    await next(context1);
//});
app.MapControllerRoute(
    name: "default",
    pattern: "YouAreEl/{controller=Mypage}/{action=home}/{id?}");

app.Run();
