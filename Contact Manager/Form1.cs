using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Contact_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        public void LoadView(UserControl view)
        {
            panel1.Controls.Clear();
            view.Dock = DockStyle.Fill;
            panel1.Controls.Add(view);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //LoadView(new mainmenu());
            DataStore.Laden();  //Wichtig: beim Start Daten laden
        }

        private List<Mitarbeiter> mitarbeiterListe = new List<Mitarbeiter>();

        private void btnKundeHinzufuegen_Click(object sender, EventArgs e)
        {
            Form1 mainForm = this.FindForm() as Form1;//sucht Form1
            if (mainForm != null)//wenn Form1 gfunden wurde wird das if statement ausgeführt
            {
                mainForm.LoadView(new AddKunde()); // Wechsel zum Hinzufügen-View
            }
        }

        private void btnMitarbeiterHinzufuegen_Click(object sender, EventArgs e)
        {
            Form1 mainForm = this.FindForm() as Form1;//sucht Form1
            if (mainForm != null)//wenn Form1 gfunden wurde wird das if statement ausgeführt
            {
                mainForm.LoadView(new AddMitarbeiter()); // Wechsel zum Hinzufügen-View

            }
        }

        private void btnDatenbankSearch_Click(object sender, EventArgs e)
        {
            Form1 mainForm = this.FindForm() as Form1;//sucht Form1
            if (mainForm != null)//wenn Form1 gfunden wurde wird das if statement ausgeführt
            {
                mainForm.LoadView(new Suchen()); // Wechsel zum Hinzufügen-View

            }
        }
    }
}
