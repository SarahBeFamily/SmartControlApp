namespace SmartControl.Services
{
    public static class MenuTopItems
    {
		private static readonly Lazy<List<MenuItemGroup>> menuItemGroups = new(() =>
		{
		List<MenuItemGroup> settingGroups = [

			new("Assistente", "#", "", "icon-nav icon-assistente", "Assets/images/Icon/TopMenu/assistente.svg"),
			new("Frame", "#", "", "icon-nav icon-frame-1", "Assets/images/Icon/TopMenu/Frame-1.svg"),
            new("Mail", "#", "", "icon-nav icon-mail", "Assets/images/Icon/TopMenu/mail.svg"),
            new("Notifiche", "#", "", "icon-nav icon-alert-triangle", "Assets/images/Icon/TopMenu/alert-triangle.svg"),
            ];
            return settingGroups;
        });
		public static List<MenuItemGroup> Groups { get { return menuItemGroups.Value; } }
	}
}