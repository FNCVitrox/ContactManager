namespace Contact_Manager
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelNav = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLightmode = new System.Windows.Forms.Button();
            this.btnDatenbankSearch = new System.Windows.Forms.Button();
            this.btnKundeHinzufuegen = new System.Windows.Forms.Button();
            this.btnMitarbeiterHinzufuegen = new System.Windows.Forms.Button();
            this.pictureBoxDatabaseDarkMode = new System.Windows.Forms.PictureBox();
            this.pictureBoxDatabaseLightmodeMode = new System.Windows.Forms.PictureBox();
            this.panelNav.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDatabaseDarkMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDatabaseLightmodeMode)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.panelNav.Controls.Add(this.btnLightmode);
            this.panelNav.Controls.Add(this.btnDatenbankSearch);
            this.panelNav.Controls.Add(this.btnKundeHinzufuegen);
            this.panelNav.Controls.Add(this.btnMitarbeiterHinzufuegen);
            this.panelNav.Controls.Add(this.panelLogo);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNav.Location = new System.Drawing.Point(0, 0);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(440, 1024);
            this.panelNav.TabIndex = 1;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panelLogo.Controls.Add(this.pictureBoxDatabaseDarkMode);
            this.panelLogo.Controls.Add(this.pictureBoxDatabaseLightmodeMode);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(440, 160);
            this.panelLogo.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.panel1.Location = new System.Drawing.Point(435, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 1024);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnLightmode
            // 
            this.btnLightmode.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLightmode.FlatAppearance.BorderSize = 0;
            this.btnLightmode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLightmode.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLightmode.ForeColor = System.Drawing.Color.White;
            this.btnLightmode.Image = global::Contact_Manager.Properties.Resources.moon_half_visible_face_on_light_and_half_on_darkness;
            this.btnLightmode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLightmode.Location = new System.Drawing.Point(0, 520);
            this.btnLightmode.Name = "btnLightmode";
            this.btnLightmode.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnLightmode.Size = new System.Drawing.Size(440, 120);
            this.btnLightmode.TabIndex = 6;
            this.btnLightmode.Text = "    LightMode";
            this.btnLightmode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLightmode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLightmode.UseVisualStyleBackColor = true;
            this.btnLightmode.Click += new System.EventHandler(this.btnLightmode_Click);
            // 
            // btnDatenbankSearch
            // 
            this.btnDatenbankSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDatenbankSearch.FlatAppearance.BorderSize = 0;
            this.btnDatenbankSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatenbankSearch.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatenbankSearch.ForeColor = System.Drawing.Color.White;
            this.btnDatenbankSearch.Image = global::Contact_Manager.Properties.Resources.suche_1;
            this.btnDatenbankSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatenbankSearch.Location = new System.Drawing.Point(0, 400);
            this.btnDatenbankSearch.Name = "btnDatenbankSearch";
            this.btnDatenbankSearch.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnDatenbankSearch.Size = new System.Drawing.Size(440, 120);
            this.btnDatenbankSearch.TabIndex = 5;
            this.btnDatenbankSearch.Text = "    Datenbank Durchsuchen";
            this.btnDatenbankSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatenbankSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDatenbankSearch.UseVisualStyleBackColor = true;
            this.btnDatenbankSearch.Click += new System.EventHandler(this.btnDatenbankSearch_Click);
            // 
            // btnKundeHinzufuegen
            // 
            this.btnKundeHinzufuegen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKundeHinzufuegen.FlatAppearance.BorderSize = 0;
            this.btnKundeHinzufuegen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKundeHinzufuegen.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKundeHinzufuegen.ForeColor = System.Drawing.Color.White;
            this.btnKundeHinzufuegen.Image = global::Contact_Manager.Properties.Resources.nutzer_hinzufugen;
            this.btnKundeHinzufuegen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKundeHinzufuegen.Location = new System.Drawing.Point(0, 280);
            this.btnKundeHinzufuegen.Name = "btnKundeHinzufuegen";
            this.btnKundeHinzufuegen.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnKundeHinzufuegen.Size = new System.Drawing.Size(440, 120);
            this.btnKundeHinzufuegen.TabIndex = 4;
            this.btnKundeHinzufuegen.Text = "    Kunden Hinzufügen";
            this.btnKundeHinzufuegen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKundeHinzufuegen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKundeHinzufuegen.UseVisualStyleBackColor = true;
            this.btnKundeHinzufuegen.Click += new System.EventHandler(this.btnKundeHinzufuegen_Click);
            // 
            // btnMitarbeiterHinzufuegen
            // 
            this.btnMitarbeiterHinzufuegen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnMitarbeiterHinzufuegen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMitarbeiterHinzufuegen.FlatAppearance.BorderSize = 0;
            this.btnMitarbeiterHinzufuegen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMitarbeiterHinzufuegen.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMitarbeiterHinzufuegen.ForeColor = System.Drawing.Color.White;
            this.btnMitarbeiterHinzufuegen.Image = global::Contact_Manager.Properties.Resources.nutzer_hinzufugen;
            this.btnMitarbeiterHinzufuegen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMitarbeiterHinzufuegen.Location = new System.Drawing.Point(0, 160);
            this.btnMitarbeiterHinzufuegen.Name = "btnMitarbeiterHinzufuegen";
            this.btnMitarbeiterHinzufuegen.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnMitarbeiterHinzufuegen.Size = new System.Drawing.Size(440, 120);
            this.btnMitarbeiterHinzufuegen.TabIndex = 3;
            this.btnMitarbeiterHinzufuegen.Text = "    Mitarbeiter Hinzufügen";
            this.btnMitarbeiterHinzufuegen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMitarbeiterHinzufuegen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMitarbeiterHinzufuegen.UseVisualStyleBackColor = false;
            this.btnMitarbeiterHinzufuegen.Click += new System.EventHandler(this.btnMitarbeiterHinzufuegen_Click);
            // 
            // pictureBoxDatabaseDarkMode
            // 
            this.pictureBoxDatabaseDarkMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxDatabaseDarkMode.Image = global::Contact_Manager.Properties.Resources.dankenbanklogodarkmode;
            this.pictureBoxDatabaseDarkMode.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxDatabaseDarkMode.Name = "pictureBoxDatabaseDarkMode";
            this.pictureBoxDatabaseDarkMode.Size = new System.Drawing.Size(440, 160);
            this.pictureBoxDatabaseDarkMode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDatabaseDarkMode.TabIndex = 0;
            this.pictureBoxDatabaseDarkMode.TabStop = false;
            this.pictureBoxDatabaseDarkMode.Click += new System.EventHandler(this.pictureBoxDatabase_Click);
            // 
            // pictureBoxDatabaseLightmodeMode
            // 
            this.pictureBoxDatabaseLightmodeMode.BackColor = System.Drawing.Color.Silver;
            this.pictureBoxDatabaseLightmodeMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxDatabaseLightmodeMode.Image = global::Contact_Manager.Properties.Resources.dankebanklogolightmode;
            this.pictureBoxDatabaseLightmodeMode.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxDatabaseLightmodeMode.Name = "pictureBoxDatabaseLightmodeMode";
            this.pictureBoxDatabaseLightmodeMode.Size = new System.Drawing.Size(440, 160);
            this.pictureBoxDatabaseLightmodeMode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDatabaseLightmodeMode.TabIndex = 1;
            this.pictureBoxDatabaseLightmodeMode.TabStop = false;
            this.pictureBoxDatabaseLightmodeMode.Visible = false;
            this.pictureBoxDatabaseLightmodeMode.Click += new System.EventHandler(this.pictureBoxDatabaseLightmodeMode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1618, 1024);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelNav.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDatabaseDarkMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDatabaseLightmodeMode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Button btnMitarbeiterHinzufuegen;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnLightmode;
        private System.Windows.Forms.Button btnDatenbankSearch;
        private System.Windows.Forms.Button btnKundeHinzufuegen;
        private System.Windows.Forms.PictureBox pictureBoxDatabaseDarkMode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxDatabaseLightmodeMode;
    }
}

