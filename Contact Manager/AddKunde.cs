using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Contact_Manager
{
    public partial class AddKunde : UserControl
    {
        

        public AddKunde()
        {
            InitializeComponent();
            cmbAnrede.DataSource = Enum.GetValues(typeof(Anrede));
            cmbGeschlecht.DataSource = Enum.GetValues(typeof(Geschlecht));
            cmbStatus.DataSource = Enum.GetValues(typeof(Status));
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            int neueKId = DataStore.NächsteKundenID();


            Kunde kunde = new Kunde
            {
                Kundennummer = neueKId,
                Anrede = (Anrede)cmbAnrede.SelectedItem,
                Vorname = txtbVorname.Text,
                Nachname = txtbNachname.Text,
                Geschlecht = (Geschlecht)cmbGeschlecht.SelectedItem,
                Status = (Status)cmbStatus.SelectedItem,
                Geburtsdatum = dtpGeburtsdatum.Value,
                Titel = txtbTitel.Text,
                TelefonGeschaeft = txtbGeschaeftsnummer.Text,
                Mobiltelefon = txtbMobilenummer.Text,
                TelefonPrivat = txtbTelefonPrivat.Text,
                Email = txtbEmail.Text,
                Wohnort = txtbWohnort.Text,
                Nationalitaet = txtbNationalitaet.Text,
                Adresse = txtbAdresse.Text,
                Postleitzahl = txtbPLZ.Text,
                Firmenname = txtbFirmenname.Text,
                Firmenkontakt = txtbFirmenkontakt.Text,
                Geschaeftsadresse = txtbGeschaeftsadresse.Text,
                Kundentyp = txtbKundentyp.Text
            };
            List<Kunde> liste = new List<Kunde>();

            DataStore.KundenListe.Add(kunde);
            DataStore.Speichern();

            MessageBox.Show("Kunde gespeichert!");

            FormularLeeren();
        }

        private void FormularLeeren()
        {
            cmbAnrede.SelectedIndex = 0;
            txtbVorname.Clear();
            txtbNachname.Clear();
            cmbGeschlecht.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;
            dtpGeburtsdatum.Value = DateTime.Now;
            txtbTitel.Clear();
            txtbGeschaeftsnummer.Clear();
            txtbMobilenummer.Clear();
            txtbTelefonPrivat.Clear();
            txtbEmail.Clear();
            txtbWohnort.Clear();
            txtbNationalitaet.Clear();
            txtbAdresse.Clear();
            txtbPLZ.Clear();
            txtbFirmenname.Clear();
            txtbFirmenkontakt.Clear();
            txtbGeschaeftsadresse.Clear();
            txtbKundentyp.Clear();

        }
    }
}
