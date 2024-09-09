using BethanysPieShop.HRM.Services;
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

    protected override void OnInitialized()
        {
            Employee = MockDataService.Employees.Single(e => e.EmployeeId == EmployeeId);
            badgeColour = (Employee!.IsOnHoliday ? "primary" : "secondary");
        }

        private void ChangeHolidayState()
        {
            Employee.IsOnHoliday = !Employee.IsOnHoliday;
            badgeColour = (Employee!.IsOnHoliday ? "primary" : "secondary");
        }
    }
}
