namespace SmartControl.Services
{
    public static class MenuSettingsItems
    {
		private static readonly Lazy<List<MenuItemGroup>> menuItemGroups = new(() =>
		{
		List<MenuItemGroup> settingGroups = [
			new MenuItemGroup("Funzioni da analista", "icon-nav icon-edit-3", "images/edit-3.svg", "#",
				[
					new("Voce sottomenù", "", "", "/voce"),
                    new("Voce sottomenù", "", "", "/voce"),
                ]),
			new MenuItemGroup("Parametri di sistema", "icon-nav icon-settings", "images/settings.svg", "#",
				[
                    new("Voce sottomenù", "", "", "/voce"),
                    new("Voce sottomenù", "", "", "/voce"),
                ])
            ];
            return settingGroups;
        });
		public static List<MenuItemGroup> Groups { get { return menuItemGroups.Value; } }
	}
}