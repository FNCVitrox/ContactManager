namespace Contact_Manager
{
    partial class AddMitarbeiter
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtbVorname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbNachname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpGeburtsdatum = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbTitel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbGeschaeftsnummer = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbMobilenummer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbTelefonPrivat = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtbWohnort = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtbNationalitaet = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtbAdresse = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtbPLZ = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtbMitarbeiternummer = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtbAbteilung = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtbAHV = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.dtpEintrittsdatum = new System.Windows.Forms.DateTimePicker();
            this.dtpaustrittsdatum = new System.Windows.Forms.DateTimePicker();
            this.label22 = new System.Windows.Forms.Label();
            this.nupBeschaeftigungsgrad = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.txtbRolle = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.nupKaderStufe = new System.Windows.Forms.NumericUpDown();
            this.nupLehrjahre = new System.Windows.Forms.NumericUpDown();
            this.nupAktuelleslehrjahr = new System.Windows.Forms.NumericUpDown();
            this.label26 = new System.Windows.Forms.Label();
            this.cmbAnrede = new System.Windows.Forms.ComboBox();
            this.cmbGeschlecht = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnSpeichern = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupBeschaeftigungsgrad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupKaderStufe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupLehrjahre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAktuelleslehrjahr)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(629, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "add mitarbeiter";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtbVorname
            // 
            this.txtbVorname.Location = new System.Drawing.Point(351, 245);
            this.txtbVorname.Name = "txtbVorname";
            this.txtbVorname.Size = new System.Drawing.Size(100, 26);
            this.txtbVorname.TabIndex = 1;
            this.txtbVorname.TextChanged += new System.EventHandler(this.txtbVorname_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(185, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vorname:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(185, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nachname:";
            // 
            // txtbNachname
            // 
            this.txtbNachname.Location = new System.Drawing.Point(351, 309);
            this.txtbNachname.Name = "txtbNachname";
            this.txtbNachname.Size = new System.Drawing.Size(100, 26);
            this.txtbNachname.TabIndex = 3;
            this.txtbNachname.TextChanged += new System.EventHandler(this.txtbNachname_TextChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(185, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Anrede";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(185, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "Geburtsdatum:";
            // 
            // dtpGeburtsdatum
            // 
            this.dtpGeburtsdatum.Location = new System.Drawing.Point(351, 376);
            this.dtpGeburtsdatum.Name = "dtpGeburtsdatum";
            this.dtpGeburtsdatum.Size = new System.Drawing.Size(312, 26);
            this.dtpGeburtsdatum.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(185, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 26);
            this.label6.TabIndex = 11;
            this.label6.Text = "Geschlecht:";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(185, 486);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 26);
            this.label8.TabIndex = 16;
            this.label8.Text = "Titel:";
            // 
            // txtbTitel
            // 
            this.txtbTitel.Location = new System.Drawing.Point(351, 486);
            this.txtbTitel.Name = "txtbTitel";
            this.txtbTitel.Size = new System.Drawing.Size(100, 26);
            this.txtbTitel.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(185, 527);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 26);
            this.label9.TabIndex = 18;
            this.label9.Text = "Geschäftsnummer:";
            // 
            // txtbGeschaeftsnummer
            // 
            this.txtbGeschaeftsnummer.Location = new System.Drawing.Point(351, 527);
            this.txtbGeschaeftsnummer.Name = "txtbGeschaeftsnummer";
            this.txtbGeschaeftsnummer.Size = new System.Drawing.Size(100, 26);
            this.txtbGeschaeftsnummer.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(185, 569);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 26);
            this.label10.TabIndex = 20;
            this.label10.Text = "Mobile Nummer:";
            // 
            // txtbMobilenummer
            // 
            this.txtbMobilenummer.Location = new System.Drawing.Point(351, 569);
            this.txtbMobilenummer.Name = "txtbMobilenummer";
            this.txtbMobilenummer.Size = new System.Drawing.Size(100, 26);
            this.txtbMobilenummer.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(185, 617);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 26);
            this.label7.TabIndex = 22;
            this.label7.Text = "Telefon Privat:";
            // 
            // txtbTelefonPrivat
            // 
            this.txtbTelefonPrivat.Location = new System.Drawing.Point(351, 617);
            this.txtbTelefonPrivat.Name = "txtbTelefonPrivat";
            this.txtbTelefonPrivat.Size = new System.Drawing.Size(100, 26);
            this.txtbTelefonPrivat.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(185, 666);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 26);
            this.label11.TabIndex = 24;
            this.label11.Text = "E-Mail:";
            // 
            // txtbEmail
            // 
            this.txtbEmail.Location = new System.Drawing.Point(351, 666);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(100, 26);
            this.txtbEmail.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(185, 715);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 26);
            this.label12.TabIndex = 26;
            this.label12.Text = "Status:";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(949, 190);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(160, 26);
            this.label13.TabIndex = 29;
            this.label13.Text = "Wohnort:";
            // 
            // txtbWohnort
            // 
            this.txtbWohnort.Location = new System.Drawing.Point(1115, 190);
            this.txtbWohnort.Name = "txtbWohnort";
            this.txtbWohnort.Size = new System.Drawing.Size(100, 26);
            this.txtbWohnort.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(949, 245);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(160, 26);
            this.label14.TabIndex = 31;
            this.label14.Text = "Nationalität:";
            // 
            // txtbNationalitaet
            // 
            this.txtbNationalitaet.Location = new System.Drawing.Point(1115, 245);
            this.txtbNationalitaet.Name = "txtbNationalitaet";
            this.txtbNationalitaet.Size = new System.Drawing.Size(100, 26);
            this.txtbNationalitaet.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(949, 296);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(160, 26);
            this.label15.TabIndex = 33;
            this.label15.Text = "Adresse:";
            // 
            // txtbAdresse
            // 
            this.txtbAdresse.Location = new System.Drawing.Point(1115, 296);
            this.txtbAdresse.Name = "txtbAdresse";
            this.txtbAdresse.Size = new System.Drawing.Size(100, 26);
            this.txtbAdresse.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(949, 339);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(160, 26);
            this.label16.TabIndex = 35;
            this.label16.Text = "PLZ:";
            // 
            // txtbPLZ
            // 
            this.txtbPLZ.Location = new System.Drawing.Point(1115, 339);
            this.txtbPLZ.Name = "txtbPLZ";
            this.txtbPLZ.Size = new System.Drawing.Size(100, 26);
            this.txtbPLZ.TabIndex = 34;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(949, 394);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(160, 26);
            this.label17.TabIndex = 37;
            this.label17.Text = "Mitarbeiter Nummer";
            // 
            // txtbMitarbeiternummer
            // 
            this.txtbMitarbeiternummer.Location = new System.Drawing.Point(1115, 394);
            this.txtbMitarbeiternummer.Name = "txtbMitarbeiternummer";
            this.txtbMitarbeiternummer.Size = new System.Drawing.Size(100, 26);
            this.txtbMitarbeiternummer.TabIndex = 36;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(949, 443);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(160, 26);
            this.label18.TabIndex = 39;
            this.label18.Text = "Abteilung";
            // 
            // txtbAbteilung
            // 
            this.txtbAbteilung.Location = new System.Drawing.Point(1115, 443);
            this.txtbAbteilung.Name = "txtbAbteilung";
            this.txtbAbteilung.Size = new System.Drawing.Size(100, 26);
            this.txtbAbteilung.TabIndex = 38;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(949, 486);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(160, 26);
            this.label19.TabIndex = 41;
            this.label19.Text = "AHV nummer";
            // 
            // txtbAHV
            // 
            this.txtbAHV.Location = new System.Drawing.Point(1115, 486);
            this.txtbAHV.Name = "txtbAHV";
            this.txtbAHV.Size = new System.Drawing.Size(100, 26);
            this.txtbAHV.TabIndex = 40;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(949, 543);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(160, 26);
            this.label20.TabIndex = 43;
            this.label20.Text = "Eintrittsdatum";
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(949, 592);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(160, 26);
            this.label21.TabIndex = 45;
            this.label21.Text = "austrittsdatum";
            // 
            // dtpEintrittsdatum
            // 
            this.dtpEintrittsdatum.Location = new System.Drawing.Point(1115, 538);
            this.dtpEintrittsdatum.Name = "dtpEintrittsdatum";
            this.dtpEintrittsdatum.Size = new System.Drawing.Size(312, 26);
            this.dtpEintrittsdatum.TabIndex = 46;
            // 
            // dtpaustrittsdatum
            // 
            this.dtpaustrittsdatum.Location = new System.Drawing.Point(1115, 587);
            this.dtpaustrittsdatum.Name = "dtpaustrittsdatum";
            this.dtpaustrittsdatum.Size = new System.Drawing.Size(312, 26);
            this.dtpaustrittsdatum.TabIndex = 47;
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(949, 638);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(160, 26);
            this.label22.TabIndex = 49;
            this.label22.Text = "Beschäftigungsgrad";
            // 
            // nupBeschaeftigungsgrad
            // 
            this.nupBeschaeftigungsgrad.Location = new System.Drawing.Point(1115, 638);
            this.nupBeschaeftigungsgrad.Name = "nupBeschaeftigungsgrad";
            this.nupBeschaeftigungsgrad.Size = new System.Drawing.Size(120, 26);
            this.nupBeschaeftigungsgrad.TabIndex = 50;
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(949, 689);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(160, 26);
            this.label23.TabIndex = 52;
            this.label23.Text = "Rolle";
            // 
            // txtbRolle
            // 
            this.txtbRolle.Location = new System.Drawing.Point(1115, 689);
            this.txtbRolle.Name = "txtbRolle";
            this.txtbRolle.Size = new System.Drawing.Size(100, 26);
            this.txtbRolle.TabIndex = 51;
            // 
            // label24
            // 
            this.label24.Location = new System.Drawing.Point(949, 721);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(160, 26);
            this.label24.TabIndex = 54;
            this.label24.Text = "Kader Stufe";
            // 
            // label25
            // 
            this.label25.Location = new System.Drawing.Point(949, 753);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(160, 26);
            this.label25.TabIndex = 56;
            this.label25.Text = "Lehrjahre";
            // 
            // nupKaderStufe
            // 
            this.nupKaderStufe.Location = new System.Drawing.Point(1115, 719);
            this.nupKaderStufe.Name = "nupKaderStufe";
            this.nupKaderStufe.Size = new System.Drawing.Size(120, 26);
            this.nupKaderStufe.TabIndex = 57;
            // 
            // nupLehrjahre
            // 
            this.nupLehrjahre.Location = new System.Drawing.Point(1115, 751);
            this.nupLehrjahre.Name = "nupLehrjahre";
            this.nupLehrjahre.Size = new System.Drawing.Size(120, 26);
            this.nupLehrjahre.TabIndex = 58;
            // 
            // nupAktuelleslehrjahr
            // 
            this.nupAktuelleslehrjahr.Location = new System.Drawing.Point(1115, 793);
            this.nupAktuelleslehrjahr.Name = "nupAktuelleslehrjahr";
            this.nupAktuelleslehrjahr.Size = new System.Drawing.Size(120, 26);
            this.nupAktuelleslehrjahr.TabIndex = 60;
            // 
            // label26
            // 
            this.label26.Location = new System.Drawing.Point(949, 795);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(160, 26);
            this.label26.TabIndex = 59;
            this.label26.Text = "aktuelleslehrjahr";
            // 
            // cmbAnrede
            // 
            this.cmbAnrede.FormattingEnabled = true;
            this.cmbAnrede.Location = new System.Drawing.Point(351, 193);
            this.cmbAnrede.Name = "cmbAnrede";
            this.cmbAnrede.Size = new System.Drawing.Size(121, 28);
            this.cmbAnrede.TabIndex = 61;
            this.cmbAnrede.SelectedIndexChanged += new System.EventHandler(this.cmbAnrede_SelectedIndexChanged);
            // 
            // cmbGeschlecht
            // 
            this.cmbGeschlecht.FormattingEnabled = true;
            this.cmbGeschlecht.Location = new System.Drawing.Point(351, 440);
            this.cmbGeschlecht.Name = "cmbGeschlecht";
            this.cmbGeschlecht.Size = new System.Drawing.Size(121, 28);
            this.cmbGeschlecht.TabIndex = 62;
            this.cmbGeschlecht.SelectedIndexChanged += new System.EventHandler(this.cmbGeschlecht_SelectedIndexChanged);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(351, 718);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 28);
            this.cmbStatus.TabIndex = 63;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Location = new System.Drawing.Point(1270, 900);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(197, 52);
            this.btnSpeichern.TabIndex = 64;
            this.btnSpeichern.Text = "speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // AddMitarbeiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbGeschlecht);
            this.Controls.Add(this.cmbAnrede);
            this.Controls.Add(this.nupAktuelleslehrjahr);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.nupLehrjahre);
            this.Controls.Add(this.nupKaderStufe);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtbRolle);
            this.Controls.Add(this.nupBeschaeftigungsgrad);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.dtpaustrittsdatum);
            this.Controls.Add(this.dtpEintrittsdatum);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtbAHV);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtbAbteilung);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtbMitarbeiternummer);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtbPLZ);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtbAdresse);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtbNationalitaet);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtbWohnort);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtbEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbTelefonPrivat);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtbMobilenummer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtbGeschaeftsnummer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtbTitel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpGeburtsdatum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbNachname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbVorname);
            this.Controls.Add(this.label1);
            this.Name = "AddMitarbeiter";
            this.Size = new System.Drawing.Size(1594, 1000);
            this.Load += new System.EventHandler(this.AddMitarbeiter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupBeschaeftigungsgrad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupKaderStufe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupLehrjahre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAktuelleslehrjahr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbVorname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbNachname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpGeburtsdatum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbTitel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbGeschaeftsnummer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtbMobilenummer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbTelefonPrivat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtbWohnort;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtbNationalitaet;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtbAdresse;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtbPLZ;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtbMitarbeiternummer;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtbAbteilung;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtbAHV;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DateTimePicker dtpEintrittsdatum;
        private System.Windows.Forms.DateTimePicker dtpaustrittsdatum;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.NumericUpDown nupBeschaeftigungsgrad;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtbRolle;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.NumericUpDown nupKaderStufe;
        private System.Windows.Forms.NumericUpDown nupLehrjahre;
        private System.Windows.Forms.NumericUpDown nupAktuelleslehrjahr;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox cmbAnrede;
        private System.Windows.Forms.ComboBox cmbGeschlecht;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnSpeichern;
    }
}
