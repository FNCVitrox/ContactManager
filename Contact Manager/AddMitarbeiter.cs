using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
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
            Mitarbeiter mitarbeiter = new Mitarbeiter
            {
           


            };
            List<Mitarbeiter> liste = new List<Mitarbeiter>();

            

            MessageBox.Show("Mitarbeiter gespeichert!");
        }
        // 3. Zur Liste hinzufügen
        // mitarbeiterListe.Add(mitarbeiter);

        // 4. Optional: Feedback geben
        // MessageBox.Show("Mitarbeiter erfolgreich gespeichert.");

        // 5. Eingabefelder zurücksetzen (optional)
        // LeereFormular();

        private void txtbNachname_TextChanged(object sender, EventArgs e)
        {

        }

   
    }
}

