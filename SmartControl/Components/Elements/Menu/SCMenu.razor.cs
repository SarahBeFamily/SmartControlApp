using Microsoft.AspNetCore.Components;
using System;
using SmartControl.Services;

/// <summary>
/// Menu nella sidebar
/// scegliere il gruppo di voci del menù
/// </summary>

namespace SmartControl.Components.Elements.Menu
{
	public partial class SCMenu
	{
		[Parameter] public string Menu { get; set; } = "main";
    }
}