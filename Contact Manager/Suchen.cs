using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Manager
{
    public partial class Suchen : UserControl
    {
        public Suchen()
        {
            InitializeComponent();
        }
        private void Suchen_Load(object sender, EventArgs e)
        {
            AlleEinträgeLaden();
        }


        private void txtbSuchen_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbSuchen.Text))
            {
                AlleEinträgeLaden();
                return;
            }

            string suchtext = txtbSuchen.Text.Trim().ToLower();

            var mitarbeiterTreffer = DataStore.MitarbeiterListe
                .Where(m => m.Vorname.ToLower().Contains(suchtext) ||
                            m.Nachname.ToLower().Contains(suchtext));

            var kundenTreffer = DataStore.KundenListe
                .Where(k => k.Vorname.ToLower().Contains(suchtext) ||
                            k.Nachname.ToLower().Contains(suchtext));

            // Kombinieren in anonyme Objekte für DataGridView
            var resultate = mitarbeiterTreffer.Select(m => new
            {
                Vorname = m.Vorname,
                Nachname = m.Nachname,
                Geburtsdatum = m.Geburtsdatum.ToShortDateString(),
                Typ = "Mitarbeiter"
            })
            .Concat(kundenTreffer.Select(k => new
            {
                Vorname = k.Vorname,
                Nachname = k.Nachname,
                Geburtsdatum = k.Geburtsdatum.ToShortDateString(),
                Typ = "Kunde"
            })).ToList();

            dgvErgebnisse.DataSource = resultate;
        }

        private void AlleEinträgeLaden()
        {
            var alleMitarbeiter = DataStore.MitarbeiterListe.Select(m => new
            {
                Vorname = m.Vorname,
                Nachname = m.Nachname,
                Geburtsdatum = m.Geburtsdatum.ToShortDateString(),
                Typ = "Mitarbeiter"
            });

            var alleKunden = DataStore.KundenListe.Select(k => new
            {
                Vorname = k.Vorname,
                Nachname = k.Nachname,
                Geburtsdatum = k.Geburtsdatum.ToShortDateString(),
                Typ = "Kunde"
            });

            dgvErgebnisse.DataSource = alleMitarbeiter.Concat(alleKunden).ToList();
        }
    }
}
