using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Manager
{
    public class KontaktView
    {
        public string Typ { get; set; } // "Mitarbeiter" oder "Kunde"
        public string Nummer { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Email { get; set; }
    }


}
