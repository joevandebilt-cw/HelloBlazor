using BethanysPieShop.HRM.Client.Widgets;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BethanysPieShop.HRM.Client.Pages
{
    public partial class Home
    {
        [Inject]
        public IJSRuntime JsRunTime { get; set; }
        public List<Type> Widgets { get; set; } = new List<Type>() { typeof(EmployeeCountWidget), typeof(InboxWidget) };

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await JsRunTime.InvokeVoidAsync("LoadEvent");
        }
    }
}
