using BethanysPieShop.HRM.Data;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShop.HRM.Components.Widgets
{
    public partial class InboxWidget
    {
        [Inject]
		public required AppState AppState { get; set; }

		public int MessageCount { get; set; } = 0;

        protected override void OnInitialized()
        {
            MessageCount = AppState.NumberOfMessages;
        }
    }
}
