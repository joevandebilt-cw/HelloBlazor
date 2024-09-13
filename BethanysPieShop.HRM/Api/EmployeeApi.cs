using BethanysPieShop.HRM.Shared.Contracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.HRM.Api
{
    public static class EmployeeApi
    {
        private const string _area = "employee";
        public static void AddEmployeeApi(this WebApplication app)
        {
            app.MapGet("/api/employee", async (IEmployeeDataService employeeDataService) => await employeeDataService.GetAllEmployees());

            app.MapGet("/api/employee/{employeeId}", async (IEmployeeDataService employeeDataService, [FromRoute]int employeeId) => await employeeDataService.GetEmployeeDetails(employeeId));
        }

    }
}
