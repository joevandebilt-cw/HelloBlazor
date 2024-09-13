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

        public string EmployeeImage
        {
            get
            {
                if (Employee?.ImageContent == null) return null!;
                return $"data:image/{Path.GetExtension(Employee.ImageName)!.Replace(".", "")};base64,{Convert.ToBase64String(Employee.ImageContent)}";
            }
        }
    }
}