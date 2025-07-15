using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Contact_Manager
{
    public static class DataStore
    {
        public static List<Mitarbeiter> MitarbeiterListe { get; set; } = new List<Mitarbeiter>();
        public static string FilePath { get; } = "mitarbeiter.json";

        public static void Laden()
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                MitarbeiterListe = JsonConvert.DeserializeObject<List<Mitarbeiter>>(json) ?? new List<Mitarbeiter>();
            }
        }

        public static void Speichern()
        {
            string json = JsonConvert.SerializeObject(MitarbeiterListe, Formatting.Indented);
            File.WriteAllText(FilePath, json);
        }

        public static int NächsteMitarbeiterID()
        {
            return MitarbeiterListe.Any() ? MitarbeiterListe.Max(m => m.MitarbeiterNummer) + 1 : 1;
        }
    }
}
