using DevExpress.Blazor;
using SmartControl.Services;
using System.ComponentModel.DataAnnotations;

namespace SmartControl.Components.Pages
{
    public partial class Showcase
    {
        bool isXSmallScreen { get; set; }
        bool PopupVisible { get; set; } = false;
        string PopupClass { get; set; }
        string? SearchText { get; set; }
        bool ShowFilterRow { get; set; }
        DateTime DateTimeValue { get; set; } = DateTime.Now;
        string? Ticket { get; set; }
        private decimal Quantita { get; set; }
        bool Selezionato { get; set; }

        private string FlyoutText = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris sit amet metus vel
        nisi blandit tincidunt vel efficitur purus. Nunc nec turpis tempus, accumsan orci auctor,
        imperdiet mauris. Fusce id purus magna.";

        private List<FIR> FIRs { get; set; } = [];
        IEnumerable<Location> Locations { get; set; }
        Location Trasportatore { get; set; }
        IGrid GridFir;
        IEnumerable<SaleInfo> dataSource;


        protected ViewModel Model { get; set; } = new();

        protected override async Task OnInitializedAsync()
        {
            dataSource = await Sales.GetSalesAsync();
        }

        void OpenPopup()
        {
            PopupVisible = true;
        }

        void OpenPopupSmall()
        {
            PopupVisible = true;
            PopupClass = "small";
        }

        void OpenPopupMedium()
        {
            PopupVisible = true;
            PopupClass = "medium";
        }

        void OpenPopupBig()
        {
            PopupVisible = true;
            PopupClass = "big";
        }

        protected override void OnInitialized()
        {
            BuildFir();
            BuildLocation();
        }

        private void BuildFir()
        {
            var firTemplate = new List<FIR>
            {
                new FIR
                {
                    Ticket = "FIR-123",
                    DataRichiesta = DateTime.Now,
                    DataRitiro = DateTime.Now,
                    Qty = 1000,
                    Indirizzo = "Via Manzoni",
                    Trasportatore = "Bartolini",
                },
                new FIR
                {
                    Ticket = "FIR-124",
                    DataRichiesta = DateTime.Now,
                    DataRitiro = DateTime.Now,
                    Qty = 2000,
                    Indirizzo = "Viale della pace",
                    Trasportatore = "Bartolini",
                },
                new FIR
                {
                    Ticket = "FIR-125",
                    DataRichiesta = DateTime.Now,
                    DataRitiro = DateTime.Now,
                    Qty = 2500,
                    Indirizzo = "Viale della pace",
                    Trasportatore = "Bartolini",
                },
                new FIR
                {
                    Ticket = "FIR-123",
                    DataRichiesta = DateTime.Now,
                    DataRitiro = DateTime.Now,
                    Qty = 1000,
                    Indirizzo = "Via Manzoni",
                    Trasportatore = "Bartolini",
                },
                new FIR
                {
                    Ticket = "FIR-124",
                    DataRichiesta = DateTime.Now,
                    DataRitiro = DateTime.Now,
                    Qty = 2000,
                    Indirizzo = "Viale della pace",
                    Trasportatore = "Bartolini",
                },
                new FIR
                {
                    Ticket = "FIR-125",
                    DataRichiesta = DateTime.Now,
                    DataRitiro = DateTime.Now,
                    Qty = 2500,
                    Indirizzo = "Viale della pace",
                    Trasportatore = "Bartolini",
                },
                new FIR
                {
                    Ticket = "FIR-123",
                    DataRichiesta = DateTime.Now,
                    DataRitiro = DateTime.Now,
                    Qty = 1000,
                    Indirizzo = "Via Manzoni",
                    Trasportatore = "Bartolini",
                },
                new FIR
                {
                    Ticket = "FIR-124",
                    DataRichiesta = DateTime.Now,
                    DataRitiro = DateTime.Now,
                    Qty = 2000,
                    Indirizzo = "Viale della pace",
                    Trasportatore = "Bartolini",
                },
                new FIR
                {
                    Ticket = "FIR-125",
                    DataRichiesta = DateTime.Now,
                    DataRitiro = DateTime.Now,
                    Qty = 2500,
                    Indirizzo = "Viale della pace",
                    Trasportatore = "Bartolini",
                },
                new FIR
                {
                    Ticket = "FIR-123",
                    DataRichiesta = DateTime.Now,
                    DataRitiro = DateTime.Now,
                    Qty = 1000,
                    Indirizzo = "Via Manzoni",
                    Trasportatore = "Bartolini",
                },
                new FIR
                {
                    Ticket = "FIR-124",
                    DataRichiesta = DateTime.Now,
                    DataRitiro = DateTime.Now,
                    Qty = 2000,
                    Indirizzo = "Viale della pace",
                    Trasportatore = "Bartolini"
                },
                new FIR
                {
                    Ticket = "FIR-125",
                    DataRichiesta = DateTime.Now,
                    DataRitiro = DateTime.Now,
                    Qty = 2500,
                    Indirizzo = "Viale della pace",
                    Trasportatore = "Bartolini"
                },
                new FIR
                {
                    Ticket = "FIR-123",
                    DataRichiesta = DateTime.Now,
                    DataRitiro = DateTime.Now,
                    Qty = 1000,
                    Indirizzo = "Via Manzoni",
                    Trasportatore = "Bartolini"
                },
                new FIR
                {
                    Ticket = "FIR-124",
                    DataRichiesta = DateTime.Now,
                    DataRitiro = DateTime.Now,
                    Qty = 2000,
                    Indirizzo = "Viale della pace",
                    Trasportatore = "Bartolini"
                },
                new FIR
                {
                    Ticket = "FIR-125",
                    DataRichiesta = DateTime.Now,
                    DataRitiro = DateTime.Now,
                    Qty = 2500,
                    Indirizzo = "Viale della pace",
                    Trasportatore = "Bartolini"
                },
                new FIR
                {
                    Ticket = "FIR-123",
                    DataRichiesta = DateTime.Now,
                    DataRitiro = DateTime.Now,
                    Qty = 1000,
                    Indirizzo = "Via Manzoni",
                    Trasportatore = "Bartolini"
                },
                new FIR
                {
                    Ticket = "FIR-124",
                    DataRichiesta = DateTime.Now,
                    DataRitiro = DateTime.Now,
                    Qty = 2000,
                    Indirizzo = "Viale della pace",
                    Trasportatore = "Bartolini"
                },
                new FIR
                {
                    Ticket = "FIR-125",
                    DataRichiesta = DateTime.Now,
                    DataRitiro = DateTime.Now,
                    Qty = 2500,
                    Indirizzo = "Viale della pace",
                    Trasportatore = "Bartolini"
                }
            };

            for (int i = 0; i < 30; i++)
            {
                FIRs.AddRange(firTemplate);
            }
        }

        private void BuildLocation()
        {
            Locations = new List<Location>()
            {
                new Location() { RagioneSociale = "Bartolini", Citta = "Bergamo", Indirizzo = "Via Ugo Foscolo 4" },
                new Location() { RagioneSociale = "SDA", Citta = "Padova", Indirizzo = "Via Aprilia 4" },
                new Location() { RagioneSociale = "DHL", Citta = "Torino", Indirizzo = "Via Galvani 456" }
            };
        }

        public class FIR
        {
            public string Ticket { get; set; }
            public DateTime DataRichiesta { get; set; }
            public DateTime DataRitiro { get; set; }
            public int Qty { get; set; }
            public string Indirizzo { get; set; }
            public string Trasportatore { get; set; }
            public string? Stato { get; set; }
        }

        public class Location
        {
            public string RagioneSociale { get; set; }
            public string Indirizzo { get; set; }
            public string Citta { get; set; }
        }

        public string[] Anni = new string[] { "2021", "2020", "2019", "2018", "2017" };
        public string[] Sedi = new string[] { "Sede 1", "Sede 2", "Sede 3", "Sede 4", "Sede 5" };

        protected class ViewModel
        {
            [Required] public string? TestoObbligatorio { get; set; } = "Testo obbligatorio";

            public string? ReadOnlyText { get; set; } = "Sola lettura";
            public string? Facoltativo { get; set; }
            public IEnumerable<string> Ruoli { get; set; } = ["Admin", "BackOffice", "User", "Guest"];
            public IEnumerable<string> RuoliAttivi { get; set; } = ["Admin", "BackOffice"];
        }

    }

}
