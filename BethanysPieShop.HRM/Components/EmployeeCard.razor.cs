using BethanysPieShop.HRM.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Drawing;

namespace BethanysPieShop.HRM.Components
{
    public partial class EmployeeCard
    {
        [Parameter]
        public Employee Employee { get; set; } = default!;

        [Parameter]
        public EventCallback<Employee> EmployeeQuickViewClicked { get; set; }

        public string EmployeeImage 
        { 
            get
            {
                if (Employee?.ImageContent == null) return null!;
                return $"data:image/{Path.GetExtension(Employee.ImageName)!.Replace(".","")};base64,{Convert.ToBase64String(Employee.ImageContent)}";
            }
        }

        protected override void OnInitialized()
        {
        }


    }
}
