using BethanysPieShop.HRM.Contracts.Services;
using BethanysPieShop.HRM.Services;
using BethanysPieShop.HRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShop.HRM.Components.Pages
{
    public partial class EmployeeOverview
    {
        public List<Employee> Employees { get; set; } = default!;
        private Employee? _selectedEmployee;

        private string Title = "Employee overview";
        private string Description = "employee overview";

        [Inject]
        public IEmployeeDataService? EmployeeDataService { get; set; }

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
