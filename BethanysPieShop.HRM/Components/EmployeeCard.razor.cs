﻿using BethanysPieShop.HRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShop.HRM.Components
{
    public partial class EmployeeCard
    {
        [Parameter]
        public Employee Employee { get; set; } = default!;

        [Parameter]
        public EventCallback<Employee> EmployeeQuickViewClicked { get; set; }

        protected override void OnInitialized()
        {
            //if (string.IsNullOrEmpty(Employee.LastName))
            //{
            //    throw new Exception("Last name can't be empty");
            //}
        }


    }
}
