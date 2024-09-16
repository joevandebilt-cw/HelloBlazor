using BethanysPieShop.HRM.Shared.Contracts.Services;
using BethanysPieShop.HRM.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BethanysPieShop.HRM.Client.Pages
{
    public partial class EmployeeOverview
    {
        public List<Employee> Employees { get; set; } = default!;
        private Employee? _selectedEmployee;

        private string Title = "Employee overview";
        private string Description = "employee overview";

        [Inject]
        public required IEmployeeDataService EmployeeDataService { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Employees = (await EmployeeDataService.GetAllEmployees()).ToList();
        }

        public void ShowQuickViewPopup(Employee selectedEmployee)
        {
            _selectedEmployee = selectedEmployee;
        }
    }
}
