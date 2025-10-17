namespace SmartControl.Services
{
    public static class MenuItems
    {
        private static readonly Lazy<List<MenuItemGroup>> menuItemGroups = new(() =>
        {
            List<MenuItemGroup> groups = [
                new MenuItemGroup("Dashboard", "icon-nav icon-dashboard", "images/Dashboard.svg", "/dashboard"),
                new MenuItemGroup("Story Telling", "icon-nav icon-play-circle", "images/play-circle.svg", "#"),
                new MenuItemGroup("Analisi di bilancio", "icon-nav icon-pie-chart", "images/pie-chart.svg", "#",
                     [
                        new("Voce sottomenù", "", "", "/voce"),
                        new("Voce sottomenù", "", "", "/voce"),
                     ]),
                new MenuItemGroup("Controllo di gestione", "icon-nav icon-trending-up", "images/trending-up.svg", "#",
                     [
						new("KPI personalizzati", "", "",  "/voce"),
						new("Direct costing", "", "", "/voce"),
                        new("Full costing", "", "",  "/voce"),
                        new MenuItemGroup("Budget diretto", "", "",  "#",
                            [
                                new("Analisi del budget diretto", "", "", "/voce"),
								new("Dettaglio del budget diretto", "", "", "/voce"),
								new("Confronto tra budget diretti", "", "", "/voce"),
                                new("Confronto con intelligence", "", "",  "/voce")
							]),
                        new("Report personalizzati", "", "", "/voce"),
                        new("Plus", "", "",  "/voce"),
                     ]),
                new MenuItemGroup("Finanza", "icon-nav icon-finance", "images/finance.svg", "#",
                    [
						new("Voce sottomenù", "", "", "/voce"),
						new("Voce sottomenù", "", "", "/voce"),
					 ]),
                new MenuItemGroup("Risorse umane", "icon-nav icon-users", "images/users.svg", "#"),
                new MenuItemGroup("Vendite", "icon-nav icon-shopping-cart", "images/shopping-cart.svg", "#"),
                new MenuItemGroup("Produzione", "icon-nav icon-tool", "images/tool.svg", "#"),
                new MenuItemGroup("Flussi personalizzati", "icon-nav icon-git-pull-request", "images/git-pull-request.svg", "#"),

            ];
            return groups;

		});
        public static List<MenuItemGroup> Groups { get { return menuItemGroups.Value; } }
	}
}