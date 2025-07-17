using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Manager
{
    
    public partial class MitarbeiterBearbeiten : UserControl
    {
        private Mitarbeiter _mitarbeiter;
        public MitarbeiterBearbeiten(Mitarbeiter mitarbeiter)
        {
            InitializeComponent();
            _mitarbeiter = mitarbeiter;
            FelderFüllenMitarbeiter();
            cmbAnrede.DataSource = Enum.GetValues(typeof(Anrede));
            cmbGeschlecht.DataSource = Enum.GetValues(typeof(Geschlecht));
            cmbStatus.DataSource = Enum.GetValues(typeof(Status));
        }

        private void FelderFüllenMitarbeiter()
        {
            cmbAnrede.SelectedItem = _mitarbeiter.Anrede;
            txtbVorname.Text = _mitarbeiter.Vorname;
            txtbNachname.Text = _mitarbeiter.Nachname;
            cmbGeschlecht.SelectedItem = _mitarbeiter.Geschlecht;
            cmbStatus.SelectedItem = _mitarbeiter.Status;
            txtbAHV.Text = _mitarbeiter.AHVNummer;
            dtpEintrittsdatum.Value = _mitarbeiter.Eintrittsdatum;

            if (_mitarbeiter.Austrittsdatum.HasValue)
            {
                dtpaustrittsdatum.Value = _mitarbeiter.Austrittsdatum.Value;
                dtpaustrittsdatum.Visible = true;
            }
            else
            {
                dtpaustrittsdatum.Visible = false;
            }

            txtbAbteilung.Text = _mitarbeiter.Abteilung;
            txtbBeschaeftigungsgrad.Text = _mitarbeiter.Beschaeftigungsgrad.ToString();
            txtbRolle.Text = _mitarbeiter.Rolle;
            txtbKaderStufe.Text = _mitarbeiter.Kaderstufe.ToString();
            txtbLehrjahre.Text = _mitarbeiter.Lehrjahre.ToString();
            txtbAktuelleslehrjahr.Text = _mitarbeiter.AktuellesLehrjahr.ToString();
            dtpGeburtsdatum.Value = _mitarbeiter.Geburtsdatum;
            txtbTitel.Text = _mitarbeiter.Titel;
            txtbGeschaeftsnummer.Text = _mitarbeiter.TelefonGeschaeft;
            txtbMobilenummer.Text = _mitarbeiter.Mobiltelefon;
            txtbTelefonPrivat.Text = _mitarbeiter.TelefonPrivat;
            txtbEmail.Text = _mitarbeiter.Email;
            txtbWohnort.Text = _mitarbeiter.Wohnort;
            txtbNationalitaet.Text = _mitarbeiter.Nationalitaet;
            txtbAdresse.Text = _mitarbeiter.Adresse;
            txtbPLZ.Text = _mitarbeiter.Postleitzahl;
        }

        private void cbxAustrittsdatum_CheckedChanged(object sender, EventArgs e)
        {
            dtpaustrittsdatum.Visible = cbxAustrittsdatum.Checked;
            dtpaustrittsdatum.Enabled = true;

        }

        private void cbxLehrling_CheckedChanged(object sender, EventArgs e)
        {
            lblLehrjahre.Visible = cbxLehrling.Checked;
            lblAktuelleslehrjahr.Visible = cbxLehrling.Checked;
            txtbLehrjahre.Visible = cbxLehrling.Checked;
            txtbAktuelleslehrjahr.Visible = cbxLehrling.Checked;
            txtbLehrjahre.ReadOnly = false;
            txtbAktuelleslehrjahr.ReadOnly = false;
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
            txtbAbteilung.ReadOnly = false;
            txtbAHV.ReadOnly = false;
            dtpEintrittsdatum.Enabled = true;
            txtbBeschaeftigungsgrad.ReadOnly = false;
            txtbRolle.ReadOnly = false;
            txtbKaderStufe.ReadOnly = false;


            cbxAustrittsdatum.Enabled = true;
            cbxLehrling.Enabled = true;

            cmbAnrede.Enabled = true;
            cmbGeschlecht.Enabled = true;
            cmbStatus.Enabled = true;
            dtpGeburtsdatum.Enabled = true;

            btnBearbeiten.Enabled = false;
            btnSpeichern.Enabled = true;
        }


        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            _mitarbeiter.Anrede = (Anrede)cmbAnrede.SelectedItem;
            _mitarbeiter.Vorname = txtbVorname.Text;
            _mitarbeiter.Nachname = txtbNachname.Text;
            _mitarbeiter.Geschlecht = (Geschlecht)cmbGeschlecht.SelectedItem;
            _mitarbeiter.Status = (Status)cmbStatus.SelectedItem;
            _mitarbeiter.AHVNummer = txtbAHV.Text;
            _mitarbeiter.Eintrittsdatum = dtpEintrittsdatum.Value;
            _mitarbeiter.Austrittsdatum = dtpaustrittsdatum.Visible ? dtpaustrittsdatum.Value : (DateTime?)null;
            _mitarbeiter.Abteilung = txtbAbteilung.Text;
            _mitarbeiter.Beschaeftigungsgrad = int.TryParse(txtbBeschaeftigungsgrad.Text, out int grad) ? grad : 0;
            _mitarbeiter.Rolle = txtbRolle.Text;
            _mitarbeiter.Kaderstufe = int.TryParse(txtbKaderStufe.Text, out int kader) ? kader : 0;
            _mitarbeiter.Lehrjahre = int.TryParse(txtbLehrjahre.Text, out int lehr) ? lehr : 0;
            _mitarbeiter.AktuellesLehrjahr = int.TryParse(txtbAktuelleslehrjahr.Text, out int aktuell) ? aktuell : 0;
            _mitarbeiter.Geburtsdatum = dtpGeburtsdatum.Value;
            _mitarbeiter.Titel = txtbTitel.Text;
            _mitarbeiter.TelefonGeschaeft = txtbGeschaeftsnummer.Text;
            _mitarbeiter.Mobiltelefon = txtbMobilenummer.Text;
            _mitarbeiter.TelefonPrivat = txtbTelefonPrivat.Text;
            _mitarbeiter.Email = txtbEmail.Text;
            _mitarbeiter.Wohnort = txtbWohnort.Text;
            _mitarbeiter.Nationalitaet = txtbNationalitaet.Text;
            _mitarbeiter.Adresse = txtbAdresse.Text;
            _mitarbeiter.Postleitzahl = txtbPLZ.Text;

            DataStore.Speichern();

            MessageBox.Show("Änderungen gespeichert.", "Gespeichert", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Form1 mainForm = this.FindForm() as Form1;//sucht Form1
            if (mainForm != null)//wenn Form1 gfunden wurde wird das if statement ausgeführt
            {
                mainForm.LoadView(new Suchen()); // Wechsel zum Hinzufügen-View
            }
        }

        private void btnLoeschen_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Diesen Mitarbeiter wirklich löschen?", "Bestätigen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                DataStore.MitarbeiterListe.Remove(_mitarbeiter);
                DataStore.Speichern();
                MessageBox.Show("Mitarbeiter wurde gelöscht.");

                Form1 mainForm = this.FindForm() as Form1;//sucht Form1
                if (mainForm != null)//wenn Form1 gfunden wurde wird das if statement ausgeführt
                {
                    mainForm.LoadView(new Suchen()); // Wechsel zum Hinzufügen-View
                }

            }
        }
    }
}
