using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Contact_Manager
{
    public partial class AddMitarbeiter : UserControl
    {
        private bool IsChecked = true;
        private readonly string filePath = "mitarbeiter.json";
        
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


            Mitarbeiter mitarbeiter = new Mitarbeiter
            {
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
            List<Mitarbeiter> liste = new List<Mitarbeiter>();

            if (File.Exists(filePath))
            {
                string existingJson = File.ReadAllText(filePath);
                liste = JsonConvert.DeserializeObject<List<Mitarbeiter>>(existingJson) ?? new List<Mitarbeiter>();
            }

            liste.Add(mitarbeiter);

            string json = JsonConvert.SerializeObject(liste, Formatting.Indented);
            File.WriteAllText(filePath, json);

            MessageBox.Show("Mitarbeiter gespeichert!");

            FormularLeeren();


           
        }

        private void FormularLeeren()
        {
         
            cmbAnrede.SelectedIndex = -1;
            txtbVorname.Clear();
            txtbNachname.Clear();
            cmbGeschlecht.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
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

        private void AddMitarbeiter_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            dtpaustrittsdatum.Visible = cbxAustrittsdatum.Checked;

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            lblLehrjahre.Visible = cbxLehrling.Checked;
            lblAktuelleslehrjahr.Visible = cbxLehrling.Checked;
            txtbLehrjahre.Visible = cbxLehrling.Checked;
            txtbAktuelleslehrjahr.Visible = cbxLehrling.Checked;
        }

        private void BtnZurueck_Click(object sender, EventArgs e)
        {
            Form1 mainForm = this.FindForm() as Form1;//sucht Form1
            if (mainForm != null)//wenn Form1 gfunden wurde wird das if statement ausgeführt
            {
                mainForm.LoadView(new Hinzufügen()); // Wechsel zum Hinzufügen-View
            }
        }
    }
}

