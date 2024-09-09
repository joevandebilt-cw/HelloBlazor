using BethanysPieShop.HRM.Components.Widgets;

namespace BethanysPieShop.HRM.Components.Pages
{
    public partial class Home
    {
        public List<Type> Widgets { get; set; } = new List<Type>()
        {
            typeof(EmployeeCountWidget),
            typeof(InboxWidget),
        };
    }
}
