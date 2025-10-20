using Microsoft.AspNetCore.Components;
using System;
using Microsoft.JSInterop;

namespace SmartControl.Components.Elements.Buttons
{
	public partial class SCButton
	{
		[Parameter] public string? Text { get; set; }
		[Parameter] public string? CssClass { get; set; }
        [Parameter] public string? Icon { get; set; }
		[Parameter] public bool Flyout { get; set; } = false;
		[Parameter] public required string RenderStyle { get; set; }
		[Parameter] public EventCallback OnClick { get; set; }

    }
}