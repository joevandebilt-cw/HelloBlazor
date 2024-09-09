using BethanysPieShop.HRM.Data;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShop.HRM.Components.Widgets
{
	public partial class InboxCounter
	{
		[Inject]
		public required AppState AppState { get; set; }

		protected int MessageCount = 0;

		protected override void OnInitialized()
		{
			MessageCount = AppState.NumberOfMessages;
		}
	}
}
