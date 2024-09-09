using BethanysPieShop.HRM.Components;
using BethanysPieShop.HRM.Data;
using BethanysPieShop.HRM.Repositories;
using BethanysPieShop.HRM.Repositories.Interfaces;
using BethanysPieShop.HRM.Services;
using BethanysPieShop.HRM.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContextFactory<AppDbContext>(options => 
    options.UseSqlServer(
        builder.Configuration["ConnectionStrings:DBConnectionString"]
    )
);
//Repositories
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();

//Services
builder.Services.AddScoped<IEmployeeDataService, EmployeeDataService>();

//Build
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
