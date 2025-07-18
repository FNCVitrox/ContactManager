﻿using System;
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
            LoadView(new LogoDarkMode());
        }

        private void btnKundeHinzufuegen_Click(object sender, EventArgs e)
        {
            Form1 mainForm = this.FindForm() as Form1;//sucht Form1
            if (mainForm != null)//wenn Form1 gfunden wurde wird das if statement ausgeführt
            {
                mainForm.LoadView(new AddKunde()); // Wechsel zum AddKunde-View
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
                btnMitarbeiterHinzufuegen.BackColor = Color.FromArgb(41, 41, 41);
                btnKundeHinzufuegen.BackColor = Color.FromArgb(52, 52, 52);
                btnDatenbankSearch.BackColor = Color.FromArgb(41, 41, 41);
                isLightMode = false;
            }
        }

        private void btnMitarbeiterHinzufuegen_Click(object sender, EventArgs e)
        {
            Form1 mainForm = this.FindForm() as Form1;//sucht Form1
            if (mainForm != null)//wenn Form1 gfunden wurde wird das if statement ausgeführt
            {
                mainForm.LoadView(new AddMitarbeiter()); // Wechsel zum AddMitabeiter-View

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
                btnMitarbeiterHinzufuegen.BackColor = Color.FromArgb(52, 52, 52);
                btnKundeHinzufuegen.BackColor = Color.FromArgb(41, 41, 41);
                btnDatenbankSearch.BackColor = Color.FromArgb(41, 41, 41);
                isLightMode = false;
            }
        }

        private void btnDatenbankSearch_Click(object sender, EventArgs e)
        {
            Form1 mainForm = this.FindForm() as Form1;//sucht Form1
            if (mainForm != null)//wenn Form1 gfunden wurde wird das if statement ausgeführt
            {
                mainForm.LoadView(new Suchen()); // Wechsel zum Suchen-View

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
                btnMitarbeiterHinzufuegen.BackColor = Color.FromArgb(41, 41, 41);
                btnKundeHinzufuegen.BackColor = Color.FromArgb(41, 41, 41);
                btnDatenbankSearch.BackColor = Color.FromArgb(52, 52, 52);

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
                btnMitarbeiterHinzufuegen.ForeColor = Color.Black;
                btnKundeHinzufuegen.ForeColor = Color.Black;
                btnDatenbankSearch.ForeColor = Color.Black;
                btnLightmode.ForeColor = Color.Black;
                pictureBoxDatabaseDarkMode.Visible = false;
                pictureBoxDatabaseLightmodeMode.Visible = true;

                Form1 mainForm = this.FindForm() as Form1;//sucht Form1
                if (mainForm != null)//wenn Form1 gfunden wurde wird das if statement ausgeführt
                {
                    mainForm.LoadView(new LogoLightMode()); // Wechsel zum LogoLightMode-View

                }


            }
            else
            {
                panel1.BackColor = Color.FromArgb(52, 52, 52);
                panelNav.BackColor = Color.FromArgb(41, 41, 41);
                panelLogo.BackColor = Color.FromArgb(31, 31, 31);
                btnLightmode.Text = "    LightMode";
                btnLightmode.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
                isLightMode = false;
                btnMitarbeiterHinzufuegen.BackColor = Color.FromArgb(41, 41, 41);
                btnKundeHinzufuegen.BackColor = Color.FromArgb(41, 41, 41);
                btnDatenbankSearch.BackColor = Color.FromArgb(41, 41, 41);
                btnMitarbeiterHinzufuegen.ForeColor = Color.White;
                btnKundeHinzufuegen.ForeColor = Color.White;
                btnDatenbankSearch.ForeColor = Color.White;
                btnLightmode.ForeColor = Color.White;

                pictureBoxDatabaseDarkMode.Visible = true;
                pictureBoxDatabaseLightmodeMode.Visible = false;

                Form1 mainForm = this.FindForm() as Form1;//sucht Form1
                if (mainForm != null)//wenn Form1 gfunden wurde wird das if statement ausgeführt
                {
                    mainForm.LoadView(new LogoDarkMode()); // Wechsel zum LogoDarkMode-View
                }

            }
        }


        //picbox logo black
        private void pictureBoxDatabase_Click(object sender, EventArgs e)
        {
            Form1 mainForm = this.FindForm() as Form1;//sucht Form1
            if (mainForm != null)//wenn Form1 gfunden wurde wird das if statement ausgeführt
            {
                mainForm.LoadView(new LogoDarkMode()); // Wechsel zum DarkMode-View
            }
        }

        private void pictureBoxDatabaseLightmodeMode_Click(object sender, EventArgs e)
        {
            Form1 mainForm = this.FindForm() as Form1;//sucht Form1
            if (mainForm != null)//wenn Form1 gfunden wurde wird das if statement ausgeführt
            {
                mainForm.LoadView(new LogoLightMode()); // Wechsel zum LightMode-View
            }
        }

        private void pictureBoxLogoGrossLightMode_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
