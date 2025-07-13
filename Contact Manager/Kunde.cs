using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Manager
{
    public class Kunde : Person
    {
        public string Firmenname { get; set; }
        public string Geschaeftsadresse { get; set; }
        public string Kundentyp { get; set; }
        public string Firmenkontakt { get; set; }
    }
}
