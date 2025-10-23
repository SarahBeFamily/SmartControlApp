using Microsoft.AspNetCore.Components;

/// <summary>
/// Badge di stato per tabella. Scegliere tra i colori: gray, green, red, orange, yellow e black
/// </summary>

namespace SmartControl.Components.Elements.Tables
{
	public partial class SCBadge
	{
		[Parameter] public required string Label { get; set; }
		[Parameter] public string? Color { get; set; }
		[Parameter] public bool ColorGray { get; set; } = false;
		[Parameter] public bool ColorGreen { get; set; } = false;
		[Parameter] public bool ColorRed { get; set; } = false;
		[Parameter] public bool ColorYellow { get; set; } = false;
		[Parameter] public bool ColorOrange { get; set; } = false;
		[Parameter] public bool ColorBlack { get; set; } = false;
	}
}