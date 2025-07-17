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
    public partial class KundenBearbeiten : UserControl
    {
        private Kunde _kunde;

        public KundenBearbeiten(Kunde kunde)
        {
            InitializeComponent();
            _kunde = kunde;
            FelderFüllenKunde();
            cmbAnrede.DataSource = Enum.GetValues(typeof(Anrede));
            cmbGeschlecht.DataSource = Enum.GetValues(typeof(Geschlecht));
            cmbStatus.DataSource = Enum.GetValues(typeof(Status));

        }

        private void FelderFüllenKunde()
        {
            txtbVorname.Text = _kunde.Vorname;
            txtbNachname.Text = _kunde.Nachname;
            txtbTitel.Text = _kunde.Titel;
            txtbGeschaeftsnummer.Text = _kunde.TelefonGeschaeft;
            txtbMobilenummer.Text = _kunde.Mobiltelefon;
            txtbTelefonPrivat.Text = _kunde.TelefonPrivat;
            txtbEmail.Text = _kunde.Email;
            txtbWohnort.Text = _kunde.Wohnort;
            txtbNationalitaet.Text = _kunde.Nationalitaet;
            txtbAdresse.Text = _kunde.Adresse;
            txtbPLZ.Text = _kunde.Postleitzahl;
            txtbFirmenname.Text = _kunde.Firmenname;
            txtbFirmenkontakt.Text = _kunde.Firmenkontakt;
            txtbGeschaeftsadresse.Text = _kunde.Geschaeftsadresse;
            txtbKundentyp.Text = _kunde.Kundentyp;
            cmbAnrede.SelectedItem = _kunde.Anrede;
            cmbGeschlecht.SelectedItem = _kunde.Geschlecht;
            cmbStatus.SelectedItem = _kunde.Status;
            dtpGeburtsdatum.Value = _kunde.Geburtsdatum;
        }

        private void cmbAnrede_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBearbeiten_Click(object sender, EventArgs e)
        {
            txtbVorname.ReadOnly = false;
            txtbNachname.ReadOnly = false;
            txtbTitel.ReadOnly = false;
            txtbGeschaeftsnummer.ReadOnly = false;
            txtbMobilenummer.ReadOnly = false;
            txtbTelefonPrivat.ReadOnly = false;
            txtbEmail.ReadOnly = false;
            txtbWohnort.ReadOnly = false;
            txtbNationalitaet.ReadOnly = false;
            txtbAdresse.ReadOnly = false;
            txtbPLZ.ReadOnly = false;
            txtbFirmenname.ReadOnly = false;
            txtbFirmenkontakt.ReadOnly = false;
            txtbGeschaeftsadresse.ReadOnly = false;
            txtbKundentyp.ReadOnly = false;
            cmbAnrede.Enabled = true;
            cmbGeschlecht.Enabled = true;
            cmbStatus.Enabled = true;
            dtpGeburtsdatum.Enabled = true;

            btnBearbeiten.Enabled = false;
            btnSpeichern.Enabled = true;
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            _kunde.Anrede = (Anrede)cmbAnrede.SelectedItem;
            _kunde.Vorname = txtbVorname.Text;
            _kunde.Nachname = txtbNachname.Text;
            _kunde.Geschlecht = (Geschlecht)cmbGeschlecht.SelectedItem;
            _kunde.Status = (Status)cmbStatus.SelectedItem;
            _kunde.Geburtsdatum = dtpGeburtsdatum.Value;
            _kunde.Titel = txtbTitel.Text;
            _kunde.TelefonGeschaeft = txtbGeschaeftsnummer.Text;
            _kunde.Mobiltelefon = txtbMobilenummer.Text;
            _kunde.TelefonPrivat = txtbTelefonPrivat.Text;
            _kunde.Email = txtbEmail.Text;
            _kunde.Wohnort = txtbWohnort.Text;
            _kunde.Nationalitaet = txtbNationalitaet.Text;
            _kunde.Adresse = txtbAdresse.Text;
            _kunde.Postleitzahl = txtbPLZ.Text;
            _kunde.Firmenname = txtbFirmenname.Text;
            _kunde.Firmenkontakt = txtbFirmenkontakt.Text;
            _kunde.Geschaeftsadresse = txtbGeschaeftsadresse.Text;
            _kunde.Kundentyp = txtbKundentyp.Text;

            DataStore.Speichern();

            MessageBox.Show("Änderungen gespeichert.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Form1 mainForm = this.FindForm() as Form1;//sucht Form1
            if (mainForm != null)//wenn Form1 gfunden wurde wird das if statement ausgeführt
            {
                mainForm.LoadView(new Suchen()); // Wechsel zum Suchen-View
            }
        }

        private void btnLoeschen_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Diesen Kunden wirklich löschen?", "Bestätigen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                DataStore.KundenListe.Remove(_kunde);
                DataStore.Speichern();
                MessageBox.Show("Kunde wurde gelöscht.");

                Form1 mainForm = this.FindForm() as Form1;//sucht Form1
                if (mainForm != null)//wenn Form1 gfunden wurde wird das if statement ausgeführt
                {
                    mainForm.LoadView(new Suchen()); // Wechsel zum Suchen-View
                }

            }


        }
    }
}
