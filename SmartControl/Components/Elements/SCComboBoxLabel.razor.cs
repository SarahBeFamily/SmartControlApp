using Microsoft.AspNetCore.Components;

/// <summary>
/// Contenitore per un combobox, aggiunge la label con icona. La classe "anno" inserita nel tag <ISysComboBoxLabel> è il nome della classe css che verrà applicata al contenitore. Quest'ultima renderà il componente con larghezza massima 175px
/// </summary>

namespace SmartControl.Components.Elements
{
	public partial class SCComboBoxLabel
	{
		[Parameter] public string? Label { get; set; }
		[Parameter] public string? CssClass { get; set; }
		[Parameter] public string? Icon { get; set; } = null;
		[Parameter] public RenderFragment? ChildContent { get; set; }
	}
}