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
        public static List<Kunde> KundenListe { get; set; } = new List<Kunde>();
        public static string FilePathMitarbeiter { get; } = "mitarbeiter.json";
        public static string FilePathKunden { get; } = "kunden.json";

        public static void Laden()
        {
            if (File.Exists(FilePathMitarbeiter))
            {
                string jsonM = File.ReadAllText(FilePathMitarbeiter);
                MitarbeiterListe = JsonConvert.DeserializeObject<List<Mitarbeiter>>(jsonM) ?? new List<Mitarbeiter>();
            }
            if (File.Exists(FilePathKunden))
            {
                string jsonK = File.ReadAllText(FilePathKunden);
                KundenListe = JsonConvert.DeserializeObject<List<Kunde>>(jsonK) ?? new List<Kunde>();
            }
        }

        public static void Speichern()
        {
            string jsonM = JsonConvert.SerializeObject(MitarbeiterListe, Formatting.Indented);
            File.WriteAllText(FilePathMitarbeiter, jsonM);

            string jsonK = JsonConvert.SerializeObject(KundenListe, Formatting.Indented);
            File.WriteAllText(FilePathKunden, jsonK);
        }

        public static int NächsteMitarbeiterID()
        {
            return MitarbeiterListe.Any() ? MitarbeiterListe.Max(m => m.MitarbeiterNummer) + 1 : 1;
        }


    }
}
