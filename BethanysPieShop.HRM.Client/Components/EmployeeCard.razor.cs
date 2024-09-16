using BethanysPieShop.HRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShop.HRM.Client.Components
{
    public partial class EmployeeCard
    {
        [Parameter]
        public Employee Employee { get; set; } = default!;

        [Parameter]
        public EventCallback<Employee> EmployeeQuickViewClicked { get; set; }
    }
}