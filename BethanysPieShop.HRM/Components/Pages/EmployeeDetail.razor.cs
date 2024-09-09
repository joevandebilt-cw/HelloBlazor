using BethanysPieShop.HRM.Services;
using BethanysPieShop.HRM.Services.Interfaces;
using BethanysPieShop.HRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShop.HRM.Components.Pages
{
    public partial class EmployeeDetail
    {
        [Parameter]
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; } = new Employee();
        public string badgeColour;

		[Inject]
		public IEmployeeDataService? employeeDataService { get; set; }

		protected override async Task OnInitializedAsync()
		{
		    Employee = await employeeDataService.GetEmployeeDetails(EmployeeId);
            badgeColour = (Employee!.IsOnHoliday ? "primary" : "secondary");
        }

        private void ChangeHolidayState()
        {
            Employee.IsOnHoliday = !Employee.IsOnHoliday;
            badgeColour = (Employee!.IsOnHoliday ? "primary" : "secondary");
        }
    }
}
