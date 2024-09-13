using BethanysPieShop.HRM.Client.Widgets;

namespace BethanysPieShop.HRM.Client.Pages
{
    public partial class Home
    {
        public List<Type> Widgets { get; set; } = new List<Type>() { typeof(EmployeeCountWidget), typeof(InboxWidget) };
    }
}
