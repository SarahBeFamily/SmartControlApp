using Microsoft.AspNetCore.Components;
using System;
using SmartControl.Services;

/// <summary>
/// Top menù con icone nell'header
/// </summary>

namespace SmartControl.Components.Elements.Menu
{
    public partial class SCTopMenu
    {
        [Parameter] public string Menu { get; set; } = "top";

        private static readonly Lazy<List<MenuItemGroup>> menuItemGroups = new(() =>
        {
            List<MenuItemGroup> settingGroups = [
                // Etichetta | url | LongDescription | icona css | icona svg | Sottomenu (opzionale) | item Class (opzionale)
                new("Assistente", "#", "", "icon-nav icon-assistente", "Assets/images/Icon/TopMenu/assistente.svg"),
                new("Frame", "#", "", "icon-nav icon-frame", "Assets/images/Icon/TopMenu/Frame-menu.svg"),
                new("Mail", "#", "", "icon-nav icon-mail", "Assets/images/Icon/TopMenu/mail.svg"),
                new("Notifiche", "#", "", "icon-nav icon-alert-triangle", "Assets/images/Icon/TopMenu/alert-triangle.svg", null, "notifiche"),
            ];
            return settingGroups;
        });
        public static List<MenuItemGroup> Groups { get { return menuItemGroups.Value; } }
    }
}