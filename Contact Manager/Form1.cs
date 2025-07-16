using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

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
            DataStore.Laden();  //Wichtig: beim Start Daten laden
        }

        private void btnKundeHinzufuegen_Click(object sender, EventArgs e)
        {
            Form1 mainForm = this.FindForm() as Form1;//sucht Form1
            if (mainForm != null)//wenn Form1 gfunden wurde wird das if statement ausgeführt
            {
                mainForm.LoadView(new AddKunde()); // Wechsel zum Hinzufügen-View
            }


            if (isLightMode)
            {
                btnMitarbeiterHinzufuegen.BackColor = Color.Gainsboro;
                btnKundeHinzufuegen.BackColor = Color.Gainsboro;
                btnDatenbankSearch.BackColor = Color.Gainsboro;
                btnKundeHinzufuegen.BackColor = Color.FromArgb(180, 180, 180);
                isLightMode = true;
            }
            else
            {
                btnMitarbeiterHinzufuegen.BackColor = Color.FromArgb(51, 51, 76);
                btnKundeHinzufuegen.BackColor = Color.FromArgb(70, 70, 100);
                btnDatenbankSearch.BackColor = Color.FromArgb(51, 51, 76);
                isLightMode = false;
            }
        }

        private void btnMitarbeiterHinzufuegen_Click(object sender, EventArgs e)
        {
            Form1 mainForm = this.FindForm() as Form1;//sucht Form1
            if (mainForm != null)//wenn Form1 gfunden wurde wird das if statement ausgeführt
            {
                mainForm.LoadView(new AddMitarbeiter()); // Wechsel zum Hinzufügen-View

            }
            if (isLightMode)
            {
                
                btnMitarbeiterHinzufuegen.BackColor = Color.Gainsboro;
                btnKundeHinzufuegen.BackColor = Color.Gainsboro;
                btnDatenbankSearch.BackColor = Color.Gainsboro;
                btnMitarbeiterHinzufuegen.BackColor = Color.FromArgb(180, 180, 180);
                isLightMode = true;
            }
            else
            {
                btnMitarbeiterHinzufuegen.BackColor = Color.FromArgb(70, 70, 100);
                btnKundeHinzufuegen.BackColor = Color.FromArgb(51, 51, 76);
                btnDatenbankSearch.BackColor = Color.FromArgb(51, 51, 76);
                isLightMode = false;
            }
        }


        private void btnDatenbankSearch_Click(object sender, EventArgs e)
        {
            Form1 mainForm = this.FindForm() as Form1;//sucht Form1
            if (mainForm != null)//wenn Form1 gfunden wurde wird das if statement ausgeführt
            {
                mainForm.LoadView(new Suchen()); // Wechsel zum Hinzufügen-View

            }
            if (isLightMode)
            {
                btnMitarbeiterHinzufuegen.BackColor = Color.Gainsboro;
                btnKundeHinzufuegen.BackColor = Color.Gainsboro;
                btnDatenbankSearch.BackColor = Color.Gainsboro;
                btnDatenbankSearch.BackColor = Color.FromArgb(180, 180, 180);
                isLightMode = true;
            }
            else
            {
                btnMitarbeiterHinzufuegen.BackColor = Color.FromArgb(51, 51, 76);
                btnKundeHinzufuegen.BackColor = Color.FromArgb(51, 51, 76);
                btnDatenbankSearch.BackColor = Color.FromArgb(70, 70, 100);

                isLightMode = false;
            }
        }

        private bool isLightMode = false;
        private void btnLightmode_Click(object sender, EventArgs e)
        {
            if (!isLightMode)
            {
                panel1.BackColor = Color.White;
                panelNav.BackColor = Color.Gainsboro;
                panelLogo.BackColor = Color.Silver;
                btnLightmode.Text = "    DarkMode";
                btnLightmode.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
                isLightMode = true;
                btnMitarbeiterHinzufuegen.BackColor = Color.Gainsboro;
                btnKundeHinzufuegen.BackColor = Color.Gainsboro;
                btnDatenbankSearch.BackColor = Color.Gainsboro;
            }
            else
            {
                panel1.BackColor = Color.FromArgb(46, 51, 73);
                panelNav.BackColor = Color.FromArgb(51, 51, 76);
                panelLogo.BackColor = Color.FromArgb(39, 39, 58);
                btnLightmode.Text = "    LightMode";
                btnLightmode.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
                isLightMode = false;
                btnMitarbeiterHinzufuegen.BackColor = Color.FromArgb(51, 51, 76);
                btnKundeHinzufuegen.BackColor = Color.FromArgb(51, 51, 76);
                btnDatenbankSearch.BackColor = Color.FromArgb(51, 51, 76);
            }

        }

    }
}
