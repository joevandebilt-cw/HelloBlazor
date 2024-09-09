using BethanysPieShop.HRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShop.HRM.Components.Widgets
{
    public partial class EmployeeCard
    {
        [Parameter]
        public Employee Employee { get; set; } = default!;

		protected override void OnInitialized()
		{
			if (string.IsNullOrWhiteSpace(Employee.LastName))
			{
				throw new Exception("Last name cannot be empty");
			}
		}
	}
}