using BethanysPieShop.HRM.Client.Services;
using BethanysPieShop.HRM.Shared.Contracts.Services;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
});

builder.Services.AddBlazoredLocalStorage();

builder.Services.AddScoped<IEmployeeDataService, EmployeeDataService>();

await builder.Build().RunAsync();
