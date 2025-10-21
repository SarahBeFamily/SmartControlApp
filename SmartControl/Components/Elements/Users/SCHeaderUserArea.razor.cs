using Microsoft.AspNetCore.Components;

namespace SmartControl.Components.Elements.Users
{
    public partial class SCHeaderUserArea : ComponentBase
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }
    }
}
