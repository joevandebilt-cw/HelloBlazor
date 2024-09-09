using BethanysPieShop.HRM.Components;
using BethanysPieShop.HRM.Contracts.Repositories;
using BethanysPieShop.HRM.Contracts.Services;
using BethanysPieShop.HRM.Data;
using BethanysPieShop.HRM.Repositories;
using BethanysPieShop.HRM.Services;
using BethanysPieShop.HRM.State;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContextFactory<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration["ConnectionStrings:DBConnectionString"]
        ));


builder.Services.AddScoped<IEmployeeDataService, EmployeeDataService>();
builder.Services.AddScoped<ITimeRegistrationDataService, TimeRegistrationDataService>();


builder.Services.AddScoped<ITimeRegistrationRepository, TimeRegistrationRepository>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();

builder.Services.AddScoped<ApplicationState>();


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
    .AddInteractiveServerRenderMode(); ;

app.Run();
