using BethanysPieShop.HRM.Shared.Contracts.Services;
using BethanysPieShop.HRM.Shared.Domain;
using BethanysPieShop.HRM.Shared.Model;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web.Virtualization;

namespace BethanysPieShop.HRM.Client.Pages
{
    public partial class EmployeeDetail
    {
        [Parameter]
        public int EmployeeId { get; set; }

        [Inject]
        public IEmployeeDataService? EmployeeDataService { get; set; }

        //[Inject]
        //public ITimeRegistrationDataService? TimeRegistrationDataService { get; set; }

        public List<TimeRegistration> TimeRegistrations { get; set; } = [];

        public Employee Employee { get; set; } = new Employee();

        public List<Marker> MapMarkers { get; set; } = new();



        protected async override Task OnInitializedAsync()
        {
            Employee = await EmployeeDataService.GetEmployeeDetails(EmployeeId);
            //TimeRegistrations = await TimeRegistrationDataService.GetTimeRegistrationsForEmployee(EmployeeId);

            if (Employee.Longitude.HasValue && Employee.Latitude.HasValue)
            {
                MapMarkers.Add(new()
                {
                    Description = $"{Employee.FirstName} {Employee.LastName}",
                    X = Employee.Longitude.Value,
                    Y = Employee.Latitude.Value,
                    ShowPopup = false
                });
            }
        }

        private void ChangeHolidayState()
        {
            Employee.IsOnHoliday = !Employee.IsOnHoliday;
        }

        //public async ValueTask<ItemsProviderResult<TimeRegistration>> LoadTimeRegistrations(ItemsProviderRequest request)
        //{
        //    //int totalNumberOfTimeRegistrations = await TimeRegistrationDataService.GetTimeRegistrationCountForEmployeeId(EmployeeId);

        //    //var numberOfTimeRegistrations = Math.Min(request.Count, totalNumberOfTimeRegistrations - request.StartIndex);
        //    //var listItems = await TimeRegistrationDataService.GetPagedTimeRegistrationsForEmployee(EmployeeId, numberOfTimeRegistrations, request.StartIndex);

        //    return new ItemsProviderResult<TimeRegistration>(listItems, totalNumberOfTimeRegistrations);
        //}
    }
}
