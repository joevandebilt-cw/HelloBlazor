using BethanysPieShop.HRM.Api;
using BethanysPieShop.HRM.Components;
using BethanysPieShop.HRM.Data;
using BethanysPieShop.HRM.Repositories;
using BethanysPieShop.HRM.Services;
using BethanysPieShop.HRM.Shared.Contracts.Repositories;
using BethanysPieShop.HRM.Shared.Contracts.Services;
using BethanysPieShop.HRM.State;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents(); ;

builder.Services.AddDbContextFactory<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration["ConnectionStrings:DBConnectionString"])
);

//Data services
builder.Services.AddScoped<ICountryDataService, CountryDataService>();
builder.Services.AddScoped<IEmployeeDataService, EmployeeDataService>();
builder.Services.AddScoped<IJobCategoryDataService, JobCategoryDataService>();
builder.Services.AddScoped<ITimeRegistrationDataService, TimeRegistrationDataService>();

//Repositories
builder.Services.AddScoped<ICountryRepository, CountryRepository>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IJobCategoryRepository, JobCategoryRepository>();
builder.Services.AddScoped<ITimeRegistrationRepository, TimeRegistrationRepository>();

//App State
builder.Services.AddScoped<ApplicationState>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{
    app.UseWebAssemblyDebugging();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(BethanysPieShop.HRM.Client._Imports).Assembly);

//APIs
app.AddEmployeeApi();

app.Run();
