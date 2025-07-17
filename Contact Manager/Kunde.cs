using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Contact_Manager
{
    public class Kunde : Person
    {
        [JsonProperty(Order = 16)]
        public string Firmenname { get; set; }

        [JsonProperty(Order = 17)]
        public string Geschaeftsadresse { get; set; }

        [JsonProperty(Order = 18)]
        public string Kundentyp { get; set; }

        [JsonProperty(Order = 19)]
        public string Firmenkontakt { get; set; }
        [JsonProperty(Order = 20)]
        public int Kundennummer { get; set; } // Automatisch eindeutige Nummer
    }
}
