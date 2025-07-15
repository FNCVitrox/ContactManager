using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Newtonsoft.Json;

namespace Contact_Manager
{
    public enum Geschlecht
    {
        Männlich,
        Weiblich
    }

    public enum Status
    {
        Aktiv,
        Passiv
    }

    public enum Anrede
    {
        Herr,
        Frau
    }
    public abstract class Person
    {
        // Persoenliche Daten
        [JsonProperty(Order = 1)]
        public Anrede Anrede { get; set; }

        [JsonProperty(Order = 2)]
        public string Vorname { get; set; }

        [JsonProperty(Order = 3)]
        public string Nachname { get; set; }

        [JsonProperty(Order = 4)]
        public DateTime Geburtsdatum { get; set; }

        [JsonProperty(Order = 5)]
        public Geschlecht Geschlecht { get; set; }

        [JsonProperty(Order = 6)]
        public string Titel { get; set; }

        // Kontaktinformationen
        [JsonProperty(Order = 7)]
        public string TelefonGeschaeft { get; set; }

        [JsonProperty(Order = 8)]
        public string Mobiltelefon { get; set; }

        [JsonProperty(Order = 9)]
        public string TelefonPrivat { get; set; }

        [JsonProperty(Order = 10)]
        public string Email { get; set; }

        [JsonProperty(Order = 11)]
        public Status Status { get; set; }

        // Adressdaten
        [JsonProperty(Order = 12)]
        public string Wohnort { get; set; }

        [JsonProperty(Order = 13)]
        public string Nationalitaet { get; set; }

        [JsonProperty(Order = 14)]
        public string Adresse { get; set; }

        [JsonProperty(Order = 15)]
        public string Postleitzahl { get; set; }
    }
}
