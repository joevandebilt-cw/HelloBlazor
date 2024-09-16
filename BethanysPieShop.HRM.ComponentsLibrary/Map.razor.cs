using BethanysPieShop.HRM.Shared.Model;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BethanysPieShop.HRM.ComponentsLibrary
{
    public partial class Map
    {
        public string elementId { get; set; } = $"map-{Guid.NewGuid()}";

        [Parameter]
        public IList<Marker> Markers { get; set; }

        [Parameter]
        public double Zoom { get; set; }

        [Inject]
        public IJSRuntime JSRuntime { get; set; }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await JSRuntime.InvokeVoidAsync("deliveryMap.showOrUpdate", elementId, Markers);
        }
    }
}
