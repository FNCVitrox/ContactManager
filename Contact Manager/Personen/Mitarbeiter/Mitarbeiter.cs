using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Contact_Manager
{
    public class Mitarbeiter : Person
    {
        [JsonProperty(Order = 16)]
        public string MitarbeiterNummer { get; set; } // Automatisch eindeutige Nummer

        [JsonProperty(Order = 17)]
        public string Abteilung { get; set; }

        [JsonProperty(Order = 18)]
        public string AHVNummer { get; set; }

        [JsonProperty(Order = 19)]
        public DateTime Eintrittsdatum { get; set; }

        [JsonProperty(Order = 20)]
        public DateTime? Austrittsdatum { get; set; }

        [JsonProperty(Order = 21)]
        public int Beschaeftigungsgrad { get; set; }

        [JsonProperty(Order = 22)]
        public string Rolle { get; set; }

        [JsonProperty(Order = 23)]
        public int Kaderstufe { get; set; }

        [JsonProperty(Order = 24)]
        public int Lehrjahre { get; set; }

        [JsonProperty(Order = 25)]
        public int AktuellesLehrjahr { get; set; }

    }
}
