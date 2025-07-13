using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Manager
{
    public class Mitarbeiter : Person
    {

        public string MitarbeiterNummer { get; set; } // Automatisch eindeutige Nummer
        public string Abteilung { get; set; }
        public string AHVNummer { get; set; }
        public DateTime Eintrittsdatum { get; set; }
        public DateTime? Austrittsdatum { get; set; }
        public int Beschaeftigungsgrad { get; set; }
        public string Rolle { get; set; }
        public int Kaderstufe { get; set; }
        public int Lehrjahre { get; set; }
        public int AktuellesLehrjahr { get; set; } // Test fuer push

    }
}
