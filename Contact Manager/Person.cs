using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        public Anrede Anrede { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public DateTime Geburtsdatum { get; set; }
        public Geschlecht Geschlecht { get; set; }
        public string Titel { get; set; }

        // Kontaktinformationen
        public string TelefonGeschaeft { get; set; }
        public string Mobiltelefon { get; set; }
        public string TelefonPrivat { get; set; }
        public string Email { get; set; }
        public Status Status { get; set; }

        // Adressdaten
        public string Wohnort { get; set; }
        public string Nationalitaet { get; set; }
        public string Adresse { get; set; }
        public string Postleitzahl { get; set; }
    }
}
