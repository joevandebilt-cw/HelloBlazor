﻿using BethanysPieShop.HRM.Shared.Contracts.Services;
using BethanysPieShop.HRM.Shared.Domain;
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
        private float itemHeight = 50;
        protected IQueryable<TimeRegistration>? itemsQueryable;

        protected async override Task OnInitializedAsync()
        {
            Employee = await EmployeeDataService.GetEmployeeDetails(EmployeeId);
            //TimeRegistrations = await TimeRegistrationDataService.GetTimeRegistrationsForEmployee(EmployeeId);
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
