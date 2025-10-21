using Microsoft.AspNetCore.Components;

namespace SmartControl.Components.Elements.Users
{
    public partial class SCUsernameRoleData
    {
        [Parameter]
        public string NomeUtente { get; set; }

        [Parameter]
        public string RuoloUtente { get; set; }
    }
}
