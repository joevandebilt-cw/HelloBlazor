using BethanysPieShop.HRM.Services;
using BethanysPieShop.HRM.Services.Interfaces;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShop.HRM.Components.Widgets
{
    public partial class EmployeeCountWidget
    {
        [Inject]
        public required IEmployeeDataService employeeDataService { get; set; }

        public int EmployeeCounter { get; set; }

        protected override async Task OnInitializedAsync()
        {
            EmployeeCounter = (await employeeDataService.GetAllEmployees()).Count();
        }
    }
}
