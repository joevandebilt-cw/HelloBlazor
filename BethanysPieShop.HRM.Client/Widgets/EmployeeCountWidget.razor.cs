namespace BethanysPieShop.HRM.Client.Widgets
{
    public partial class EmployeeCountWidget
    {
        public int EmployeeCounter { get; set; }

        protected override void OnInitialized()
        {
            EmployeeCounter = 3;
        }
    }
}
