using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Manager
{
    public partial class AddMitarbeiter : UserControl
    {
        public AddMitarbeiter()
        {
            InitializeComponent();
            cmbAnrede.DataSource = Enum.GetValues(typeof(Anrede));
            cmbGeschlecht.DataSource = Enum.GetValues(typeof(Geschlecht));
            cmbStatus.DataSource = Enum.GetValues(typeof(Status));
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbAnrede_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbGeschlecht_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void txtbVorname_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            int neueMId = DataStore.NächsteMitarbeiterID();

            Mitarbeiter mitarbeiter = new Mitarbeiter
            {
                MitarbeiterNummer = neueMId,
                Anrede = (Anrede)cmbAnrede.SelectedItem,
                Vorname = txtbVorname.Text,
                Nachname = txtbNachname.Text,
                Geschlecht = (Geschlecht)cmbGeschlecht.SelectedItem,
                Status = (Status)cmbStatus.SelectedItem,
                AHVNummer = txtbAHV.Text,
                Eintrittsdatum = dtpEintrittsdatum.Value,
                Austrittsdatum = dtpaustrittsdatum.Visible ? dtpaustrittsdatum.Value : (DateTime?)null,
                Abteilung = txtbAbteilung.Text,
                Beschaeftigungsgrad = int.TryParse(txtbBeschaeftigungsgrad.Text, out int grad) ? grad : 0,
                //int.tryparse wandelt den string in einem int und ? grad : 0 macht wenn die eingabe nicht gültig ist wird der wert 0 gespeichert
                Rolle = txtbRolle.Text,
                Kaderstufe = int.TryParse(txtbKaderStufe.Text, out int kader) ? kader : 0,
                Lehrjahre = int.TryParse(txtbLehrjahre.Text, out int lehr) ? lehr : 0,
                AktuellesLehrjahr = int.TryParse(txtbAktuelleslehrjahr.Text, out int aktuell) ? aktuell : 0,
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

            };

            DataStore.MitarbeiterListe.Add(mitarbeiter);
            DataStore.Speichern();

            MessageBox.Show("Mitarbeiter gespeichert!");
            FormularLeeren();
        }
        private void FormularLeeren()
        {
            cmbAnrede.SelectedIndex = 0;
            txtbVorname.Clear();
            txtbNachname.Clear();
            cmbGeschlecht.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;
            txtbAHV.Clear();
            dtpEintrittsdatum.Value = DateTime.Now;
            dtpaustrittsdatum.Value = DateTime.Now;
            txtbAbteilung.Clear();
            txtbBeschaeftigungsgrad.Clear();
            txtbRolle.Clear();
            txtbKaderStufe.Clear();
            txtbLehrjahre.Clear();
            txtbAktuelleslehrjahr.Clear();
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
        }
        private void txtbNachname_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dtpaustrittsdatum.Visible = cbxAustrittsdatum.Checked;
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            lblLehrjahre.Visible = cbxLehrling.Checked;
            lblAktuelleslehrjahr.Visible = cbxLehrling.Checked;
            txtbLehrjahre.Visible = cbxLehrling.Checked;
            txtbAktuelleslehrjahr.Visible = cbxLehrling.Checked;
        }
    }
}

