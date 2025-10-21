namespace SmartControl.Services
{
    public static class MenuSettingsItems
    {
		private static readonly Lazy<List<MenuItemGroup>> menuItemGroups = new(() =>
		{
		List<MenuItemGroup> settingGroups = [
            // Etichetta | url | LongDescription | icona css | icona svg | Sottomenu (opzionale) | item Class (opzionale)
			new MenuItemGroup("Funzioni da analista", "#", "", "icon-nav icon-edit-3", "Assets/images/SidebarMenu/edit-3.svg",
				[
					new("Voce sottomenù", "/voce"),
                    new("Voce sottomenù", "/voce"),
                ]),
			new MenuItemGroup("Parametri di sistema", "#", "", "icon-nav icon-settings", "Assets/images/SidebarMenu/settings.svg",
				[
                    new("Voce sottomenù","/voce"),
                    new("Voce sottomenù", "/voce"),
                ])
            ];
            return settingGroups;
        });
		public static List<MenuItemGroup> Groups { get { return menuItemGroups.Value; } }
	}
}