using BethanysPieShop.HRM.Services;
using BethanysPieShop.HRM.Services.Interfaces;
using BethanysPieShop.HRM.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.QuickGrid;
using Microsoft.AspNetCore.Components.Web.Virtualization;

namespace BethanysPieShop.HRM.Components.Pages
{
    public partial class EmployeeDetail
    {
        [Parameter]
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; } = new();
        public List<TimeRegistration> TimeRegistrations { get; set; } = new();

        public float ItemHeight = 50;
        public string badgeColour
        {
            get
            {
                return (Employee!.IsOnHoliday ? "primary" : "secondary");
			}
        }

        protected IQueryable<TimeRegistration> itemsQueryable;
        protected int queryableCount = 0;
        public PaginationState pagination = new PaginationState { ItemsPerPage = 10 };

		[Inject]
		public required IEmployeeDataService employeeDataService { get; set; }

        [Inject]
        public required ITimeRegistrationDataService timeRegistrationDataService { get; set; }

        public async ValueTask<ItemsProviderResult<TimeRegistration>> LoadTimeRegistrations(ItemsProviderRequest request)
        {
            int totalNumberOfTimeRegistrations = await timeRegistrationDataService.GetTimeRegistrationCountForEmployeeId(EmployeeId);

            var numberOfTimeRegistrations = Math.Min(request.Count, totalNumberOfTimeRegistrations - request.StartIndex);
            var listItems = await timeRegistrationDataService.GetPagesTimeRegistrationsForEmployee(EmployeeId, numberOfTimeRegistrations, request.StartIndex);

            return new ItemsProviderResult<TimeRegistration>(listItems, totalNumberOfTimeRegistrations);
        }

		protected override async Task OnInitializedAsync()
		{
		    Employee = await employeeDataService.GetEmployeeDetails(EmployeeId);
            TimeRegistrations = (await timeRegistrationDataService.GetTimeRegistrationsForEmployee(EmployeeId)).ToList();

            itemsQueryable = (await timeRegistrationDataService.GetTimeRegistrationsForEmployee(EmployeeId)).AsQueryable();
            queryableCount = itemsQueryable.Count();
        }

        private void ChangeHolidayState()
        {
            Employee.IsOnHoliday = !Employee.IsOnHoliday;
        }
    }
}
