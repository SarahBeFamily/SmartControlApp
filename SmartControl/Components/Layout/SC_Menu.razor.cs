using Microsoft.AspNetCore.Components;
using System;
using SmartControl.Services;

/// <summary>
/// Menu nella sidebar
/// scegliere il gruppo di voci del menù
/// </summary>

namespace SmartControl.Components.Elements
{
	public partial class SC_Menu
	{
		[Parameter] public string Menu { get; set; } = "main";
    }
}