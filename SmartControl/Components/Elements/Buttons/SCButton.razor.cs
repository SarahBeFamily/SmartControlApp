using Microsoft.AspNetCore.Components;
using System;
using Microsoft.JSInterop;
using System.Threading.Tasks;
using Microsoft.JSInterop.Implementation;

namespace SmartControl.Components.Elements.Buttons
{
	public partial class SCButton
	{
		[Parameter] public string? Text { get; set; }
		[Parameter] public string? CssClass { get; set; }
        [Parameter] public string? Icon { get; set; }
        [Parameter] public string? Url { get; set; }
        [Parameter] public bool Flyout { get; set; } = false;
        [Parameter] public bool SubmitFormOnClick { get; set; } = false;
        [Parameter] public required string RenderStyle { get; set; }
		[Parameter] public EventCallback OnClick { get; set; }

    }

	
}