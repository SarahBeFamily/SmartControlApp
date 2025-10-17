using Microsoft.AspNetCore.Components;

/// <summary>
/// Layout a Colonne (max 5 colonne)
/// </summary>

namespace SmartControl.Components.Elements
{
    public partial class SC_LayoutColumns
    {
        [Parameter] public string? Subtitle { get; set; }
        [Parameter] public string? CssClass { get; set; }
        [Parameter] public RenderFragment? ChildContent { get; set; }
    }
}