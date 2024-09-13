using BethanysPieShop.HRM.Shared.Contracts.Services;
using BethanysPieShop.HRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShop.HRM.Client.Pages
{
    public partial class EmployeeAdd
    {
        [SupplyParameterFromForm]
        public Employee Employee { get; set; }
        protected string Message { get; set; }
        protected bool IsSaved { get; set; } = false;

        [Inject]
        public required IEmployeeDataService employeeDataService { get; set; }

        protected override void OnInitialized()
        {
            Employee ??= new();
        }

        private async Task OnSubmit()
        {
            await employeeDataService.AddEmployee(Employee);
            Message = $"{Employee.FirstName} {Employee.LastName} has been saved to the HRM";
            IsSaved = true;
        }
    }
}
