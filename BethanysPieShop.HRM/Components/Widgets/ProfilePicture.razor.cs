using Microsoft.AspNetCore.Components;

namespace BethanysPieShop.HRM.Components.Widgets
{
    public partial class ProfilePicture
    {
        [Parameter]
        public RenderFragment? ChildContent { get; set; }
    }
}
