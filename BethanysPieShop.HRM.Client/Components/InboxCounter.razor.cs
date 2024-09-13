namespace BethanysPieShop.HRM.Client.Components
{
    public partial class InboxCounter
    {

        private int MessageCount;

        protected override void OnInitialized()
        {
            MessageCount = new Random().Next(10);
        }

    }
}
