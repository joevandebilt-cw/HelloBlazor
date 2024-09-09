using BethanysPieShop.HRM.Services.Interfaces;
using BethanysPieShop.HRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShop.HRM.Components.Pages
{
	public partial class EmployeeOverview
    {
        public List<Employee> Employees { get; set; } = default!;

        [Inject]
		public IEmployeeDataService? employeeDataService { get; set; }

		protected async override Task OnInitializedAsync()
        {
            Employees =  (await employeeDataService.GetAllEmployees()).ToList();
        }
    }
}
