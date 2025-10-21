namespace SmartControl.Services
{
    public static class MenuItems
    {
        private static readonly Lazy<List<MenuItemGroup>> menuItemGroups = new(() =>
        {
            List<MenuItemGroup> groups = [
                // Ho cambiato l'ordine delle voci del menu per una migliroe gestione, inserendo prima i dati obbligatori
                // Etichetta | url | LongDescription | icona css | icona svg | Sottomenu (opzionale) | item Class (opzionale)
                new MenuItemGroup("Dashboard", "/dashboard", "", "icon-nav icon-dashboard", "Assets/images/Icon/SidebarMenu/Dashboard.svg"),
                new MenuItemGroup("Story Telling", "/showcase", "", "icon-nav icon-play-circle", "Assets/images/Icon/SidebarMenu/play-circle.svg"),
                new MenuItemGroup("Analisi di bilancio", "#", "", "icon-nav icon-pie-chart", "Assets/images/Icon/SidebarMenu/pie-chart.svg",
                     [
                        new("Voce sottomenù", "/voce"),
                        new("Voce sottomenù", "/voce"),
                     ]),
                new MenuItemGroup("Controllo di gestione", "#", "", "icon-nav icon-trending-up", "Assets/images/Icon/SidebarMenu/trending-up.svg",
                     [
						new("KPI personalizzati",  "/voce"),
						new("Direct costing", "/voce"),
                        new("Full costing", "/voce"),
                        new MenuItemGroup("Budget diretto", "#", "",  "", "",
                            [
                                new("Analisi del budget diretto", "/voce"),
								new("Dettaglio del budget diretto", "/voce"),
								new("Confronto tra budget diretti", "/voce"),
                                new("Confronto con intelligence", "/voce")
							]),
                        new("Report personalizzati", "/voce"),
                        new("Plus", "/voce"),
                     ]),
                new MenuItemGroup("Finanza", "#", "", "icon-nav icon-finance", "Assets/images/Icon/SidebarMenu/finance.svg",
                    [
						new("Voce sottomenù", "/voce"),
						new("Voce sottomenù", "/voce"),
					 ]),
                new MenuItemGroup("Risorse umane", "#", "", "icon-nav icon-users", "Assets/images/Icon/SidebarMenu/users.svg"),
                new MenuItemGroup("Vendite", "#", "", "icon-nav icon-shopping-cart", "Assets/images/Icon/SidebarMenu/shopping-cart.svg"),
                new MenuItemGroup("Produzione", "#", "", "icon-nav icon-tool", "Assets/images/Icon/SidebarMenu/tool.svg"),
                new MenuItemGroup("Flussi personalizzati", "#", "", "icon-nav icon-git-pull-request", "Assets/images/Icon/SidebarMenu/git-pull-request.svg"),

            ];
            return groups;

		});
        public static List<MenuItemGroup> Groups { get { return menuItemGroups.Value; } }
	}
}