namespace Contact_Manager
{
    partial class MitarbeiterBearbeiten
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
            this.cbxLehrling = new System.Windows.Forms.CheckBox();
            this.cbxAustrittsdatum = new System.Windows.Forms.CheckBox();
            this.txtbAktuelleslehrjahr = new System.Windows.Forms.TextBox();
            this.txtbLehrjahre = new System.Windows.Forms.TextBox();
            this.txtbKaderStufe = new System.Windows.Forms.TextBox();
            this.txtbBeschaeftigungsgrad = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbGeschlecht = new System.Windows.Forms.ComboBox();
            this.cmbAnrede = new System.Windows.Forms.ComboBox();
            this.lblAktuelleslehrjahr = new System.Windows.Forms.Label();
            this.lblLehrjahre = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtbRolle = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.dtpaustrittsdatum = new System.Windows.Forms.DateTimePicker();
            this.dtpEintrittsdatum = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtbAHV = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtbAbteilung = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtbMitarbeiternummer = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtbPLZ = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtbAdresse = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtbNationalitaet = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtbWohnort = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbTelefonPrivat = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbMobilenummer = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbGeschaeftsnummer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbTitel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpGeburtsdatum = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbNachname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbVorname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoeschen = new System.Windows.Forms.Button();
            this.btnBearbeiten = new System.Windows.Forms.Button();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxLehrling
            // 
            this.cbxLehrling.AutoSize = true;
            this.cbxLehrling.Enabled = false;
            this.cbxLehrling.Location = new System.Drawing.Point(513, 760);
            this.cbxLehrling.Name = "cbxLehrling";
            this.cbxLehrling.Size = new System.Drawing.Size(91, 24);
            this.cbxLehrling.TabIndex = 124;
            this.cbxLehrling.Text = "Lehrling";
            this.cbxLehrling.UseVisualStyleBackColor = true;
            this.cbxLehrling.CheckedChanged += new System.EventHandler(this.cbxLehrling_CheckedChanged);
            // 
            // cbxAustrittsdatum
            // 
            this.cbxAustrittsdatum.AutoSize = true;
            this.cbxAustrittsdatum.Enabled = false;
            this.cbxAustrittsdatum.Location = new System.Drawing.Point(582, 555);
            this.cbxAustrittsdatum.Name = "cbxAustrittsdatum";
            this.cbxAustrittsdatum.Size = new System.Drawing.Size(22, 21);
            this.cbxAustrittsdatum.TabIndex = 123;
            this.cbxAustrittsdatum.UseVisualStyleBackColor = true;
            this.cbxAustrittsdatum.CheckedChanged += new System.EventHandler(this.cbxAustrittsdatum_CheckedChanged);
            // 
            // txtbAktuelleslehrjahr
            // 
            this.txtbAktuelleslehrjahr.Location = new System.Drawing.Point(790, 758);
            this.txtbAktuelleslehrjahr.Name = "txtbAktuelleslehrjahr";
            this.txtbAktuelleslehrjahr.ReadOnly = true;
            this.txtbAktuelleslehrjahr.Size = new System.Drawing.Size(100, 26);
            this.txtbAktuelleslehrjahr.TabIndex = 122;
            this.txtbAktuelleslehrjahr.Visible = false;
            // 
            // txtbLehrjahre
            // 
            this.txtbLehrjahre.Location = new System.Drawing.Point(791, 715);
            this.txtbLehrjahre.Name = "txtbLehrjahre";
            this.txtbLehrjahre.ReadOnly = true;
            this.txtbLehrjahre.Size = new System.Drawing.Size(100, 26);
            this.txtbLehrjahre.TabIndex = 121;
            this.txtbLehrjahre.Visible = false;
            // 
            // txtbKaderStufe
            // 
            this.txtbKaderStufe.Location = new System.Drawing.Point(791, 684);
            this.txtbKaderStufe.Name = "txtbKaderStufe";
            this.txtbKaderStufe.ReadOnly = true;
            this.txtbKaderStufe.Size = new System.Drawing.Size(100, 26);
            this.txtbKaderStufe.TabIndex = 120;
            // 
            // txtbBeschaeftigungsgrad
            // 
            this.txtbBeschaeftigungsgrad.Location = new System.Drawing.Point(790, 600);
            this.txtbBeschaeftigungsgrad.Name = "txtbBeschaeftigungsgrad";
            this.txtbBeschaeftigungsgrad.ReadOnly = true;
            this.txtbBeschaeftigungsgrad.Size = new System.Drawing.Size(100, 26);
            this.txtbBeschaeftigungsgrad.TabIndex = 119;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Enabled = false;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(231, 678);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(312, 28);
            this.cmbStatus.TabIndex = 117;
            // 
            // cmbGeschlecht
            // 
            this.cmbGeschlecht.Enabled = false;
            this.cmbGeschlecht.FormattingEnabled = true;
            this.cmbGeschlecht.Location = new System.Drawing.Point(231, 400);
            this.cmbGeschlecht.Name = "cmbGeschlecht";
            this.cmbGeschlecht.Size = new System.Drawing.Size(312, 28);
            this.cmbGeschlecht.TabIndex = 116;
            // 
            // cmbAnrede
            // 
            this.cmbAnrede.Enabled = false;
            this.cmbAnrede.FormattingEnabled = true;
            this.cmbAnrede.Location = new System.Drawing.Point(231, 153);
            this.cmbAnrede.Name = "cmbAnrede";
            this.cmbAnrede.Size = new System.Drawing.Size(312, 28);
            this.cmbAnrede.TabIndex = 115;
            // 
            // lblAktuelleslehrjahr
            // 
            this.lblAktuelleslehrjahr.Location = new System.Drawing.Point(624, 758);
            this.lblAktuelleslehrjahr.Name = "lblAktuelleslehrjahr";
            this.lblAktuelleslehrjahr.Size = new System.Drawing.Size(160, 26);
            this.lblAktuelleslehrjahr.TabIndex = 114;
            this.lblAktuelleslehrjahr.Text = "aktuelleslehrjahr";
            this.lblAktuelleslehrjahr.Visible = false;
            // 
            // lblLehrjahre
            // 
            this.lblLehrjahre.Location = new System.Drawing.Point(624, 716);
            this.lblLehrjahre.Name = "lblLehrjahre";
            this.lblLehrjahre.Size = new System.Drawing.Size(160, 26);
            this.lblLehrjahre.TabIndex = 113;
            this.lblLehrjahre.Text = "Lehrjahre";
            this.lblLehrjahre.Visible = false;
            // 
            // label24
            // 
            this.label24.Location = new System.Drawing.Point(624, 684);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(160, 26);
            this.label24.TabIndex = 112;
            this.label24.Text = "Kader Stufe";
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(624, 652);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(160, 26);
            this.label23.TabIndex = 111;
            this.label23.Text = "Rolle";
            // 
            // txtbRolle
            // 
            this.txtbRolle.Location = new System.Drawing.Point(790, 652);
            this.txtbRolle.Name = "txtbRolle";
            this.txtbRolle.ReadOnly = true;
            this.txtbRolle.Size = new System.Drawing.Size(312, 26);
            this.txtbRolle.TabIndex = 110;
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(624, 601);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(160, 26);
            this.label22.TabIndex = 109;
            this.label22.Text = "Beschäftigungsgrad";
            // 
            // dtpaustrittsdatum
            // 
            this.dtpaustrittsdatum.Enabled = false;
            this.dtpaustrittsdatum.Location = new System.Drawing.Point(790, 550);
            this.dtpaustrittsdatum.Name = "dtpaustrittsdatum";
            this.dtpaustrittsdatum.Size = new System.Drawing.Size(312, 26);
            this.dtpaustrittsdatum.TabIndex = 108;
            this.dtpaustrittsdatum.Visible = false;
            // 
            // dtpEintrittsdatum
            // 
            this.dtpEintrittsdatum.Enabled = false;
            this.dtpEintrittsdatum.Location = new System.Drawing.Point(790, 501);
            this.dtpEintrittsdatum.Name = "dtpEintrittsdatum";
            this.dtpEintrittsdatum.Size = new System.Drawing.Size(312, 26);
            this.dtpEintrittsdatum.TabIndex = 107;
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(624, 555);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(160, 26);
            this.label21.TabIndex = 106;
            this.label21.Text = "austrittsdatum";
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(624, 506);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(160, 26);
            this.label20.TabIndex = 105;
            this.label20.Text = "Eintrittsdatum";
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(624, 449);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(160, 26);
            this.label19.TabIndex = 104;
            this.label19.Text = "AHV nummer";
            // 
            // txtbAHV
            // 
            this.txtbAHV.Location = new System.Drawing.Point(790, 449);
            this.txtbAHV.Name = "txtbAHV";
            this.txtbAHV.ReadOnly = true;
            this.txtbAHV.Size = new System.Drawing.Size(312, 26);
            this.txtbAHV.TabIndex = 103;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(624, 406);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(160, 26);
            this.label18.TabIndex = 102;
            this.label18.Text = "Abteilung";
            // 
            // txtbAbteilung
            // 
            this.txtbAbteilung.Location = new System.Drawing.Point(790, 406);
            this.txtbAbteilung.Name = "txtbAbteilung";
            this.txtbAbteilung.ReadOnly = true;
            this.txtbAbteilung.Size = new System.Drawing.Size(312, 26);
            this.txtbAbteilung.TabIndex = 101;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(624, 357);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(160, 26);
            this.label17.TabIndex = 100;
            this.label17.Text = "Mitarbeiter Nummer";
            // 
            // txtbMitarbeiternummer
            // 
            this.txtbMitarbeiternummer.Location = new System.Drawing.Point(790, 357);
            this.txtbMitarbeiternummer.Name = "txtbMitarbeiternummer";
            this.txtbMitarbeiternummer.ReadOnly = true;
            this.txtbMitarbeiternummer.Size = new System.Drawing.Size(312, 26);
            this.txtbMitarbeiternummer.TabIndex = 99;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(624, 302);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(160, 26);
            this.label16.TabIndex = 98;
            this.label16.Text = "PLZ:";
            // 
            // txtbPLZ
            // 
            this.txtbPLZ.Location = new System.Drawing.Point(790, 302);
            this.txtbPLZ.Name = "txtbPLZ";
            this.txtbPLZ.ReadOnly = true;
            this.txtbPLZ.Size = new System.Drawing.Size(312, 26);
            this.txtbPLZ.TabIndex = 97;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(624, 259);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(160, 26);
            this.label15.TabIndex = 96;
            this.label15.Text = "Adresse:";
            // 
            // txtbAdresse
            // 
            this.txtbAdresse.Location = new System.Drawing.Point(790, 259);
            this.txtbAdresse.Name = "txtbAdresse";
            this.txtbAdresse.ReadOnly = true;
            this.txtbAdresse.Size = new System.Drawing.Size(312, 26);
            this.txtbAdresse.TabIndex = 95;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(624, 208);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(160, 26);
            this.label14.TabIndex = 94;
            this.label14.Text = "Nationalität:";
            // 
            // txtbNationalitaet
            // 
            this.txtbNationalitaet.Location = new System.Drawing.Point(790, 208);
            this.txtbNationalitaet.Name = "txtbNationalitaet";
            this.txtbNationalitaet.ReadOnly = true;
            this.txtbNationalitaet.Size = new System.Drawing.Size(312, 26);
            this.txtbNationalitaet.TabIndex = 93;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(624, 153);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(160, 26);
            this.label13.TabIndex = 92;
            this.label13.Text = "Wohnort:";
            // 
            // txtbWohnort
            // 
            this.txtbWohnort.Location = new System.Drawing.Point(790, 153);
            this.txtbWohnort.Name = "txtbWohnort";
            this.txtbWohnort.ReadOnly = true;
            this.txtbWohnort.Size = new System.Drawing.Size(312, 26);
            this.txtbWohnort.TabIndex = 91;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(65, 675);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 26);
            this.label12.TabIndex = 90;
            this.label12.Text = "Status:";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(65, 626);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 26);
            this.label11.TabIndex = 89;
            this.label11.Text = "E-Mail:";
            // 
            // txtbEmail
            // 
            this.txtbEmail.Location = new System.Drawing.Point(231, 626);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.ReadOnly = true;
            this.txtbEmail.Size = new System.Drawing.Size(312, 26);
            this.txtbEmail.TabIndex = 88;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(65, 577);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 26);
            this.label7.TabIndex = 87;
            this.label7.Text = "Telefon Privat:";
            // 
            // txtbTelefonPrivat
            // 
            this.txtbTelefonPrivat.Location = new System.Drawing.Point(231, 577);
            this.txtbTelefonPrivat.Name = "txtbTelefonPrivat";
            this.txtbTelefonPrivat.ReadOnly = true;
            this.txtbTelefonPrivat.Size = new System.Drawing.Size(312, 26);
            this.txtbTelefonPrivat.TabIndex = 86;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(65, 529);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 26);
            this.label10.TabIndex = 85;
            this.label10.Text = "Mobile Nummer:";
            // 
            // txtbMobilenummer
            // 
            this.txtbMobilenummer.Location = new System.Drawing.Point(231, 529);
            this.txtbMobilenummer.Name = "txtbMobilenummer";
            this.txtbMobilenummer.ReadOnly = true;
            this.txtbMobilenummer.Size = new System.Drawing.Size(312, 26);
            this.txtbMobilenummer.TabIndex = 84;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(65, 487);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 26);
            this.label9.TabIndex = 83;
            this.label9.Text = "Geschäftsnummer:";
            // 
            // txtbGeschaeftsnummer
            // 
            this.txtbGeschaeftsnummer.Location = new System.Drawing.Point(231, 487);
            this.txtbGeschaeftsnummer.Name = "txtbGeschaeftsnummer";
            this.txtbGeschaeftsnummer.ReadOnly = true;
            this.txtbGeschaeftsnummer.Size = new System.Drawing.Size(312, 26);
            this.txtbGeschaeftsnummer.TabIndex = 82;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(65, 446);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 26);
            this.label8.TabIndex = 81;
            this.label8.Text = "Titel:";
            // 
            // txtbTitel
            // 
            this.txtbTitel.Location = new System.Drawing.Point(231, 446);
            this.txtbTitel.Name = "txtbTitel";
            this.txtbTitel.ReadOnly = true;
            this.txtbTitel.Size = new System.Drawing.Size(312, 26);
            this.txtbTitel.TabIndex = 80;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(65, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 26);
            this.label6.TabIndex = 79;
            this.label6.Text = "Geschlecht:";
            // 
            // dtpGeburtsdatum
            // 
            this.dtpGeburtsdatum.Enabled = false;
            this.dtpGeburtsdatum.Location = new System.Drawing.Point(231, 336);
            this.dtpGeburtsdatum.Name = "dtpGeburtsdatum";
            this.dtpGeburtsdatum.Size = new System.Drawing.Size(312, 26);
            this.dtpGeburtsdatum.TabIndex = 78;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(65, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 26);
            this.label4.TabIndex = 77;
            this.label4.Text = "Anrede";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(65, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 26);
            this.label5.TabIndex = 76;
            this.label5.Text = "Geburtsdatum:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(65, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 26);
            this.label3.TabIndex = 75;
            this.label3.Text = "Nachname:";
            // 
            // txtbNachname
            // 
            this.txtbNachname.Location = new System.Drawing.Point(231, 266);
            this.txtbNachname.Name = "txtbNachname";
            this.txtbNachname.ReadOnly = true;
            this.txtbNachname.Size = new System.Drawing.Size(312, 26);
            this.txtbNachname.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(65, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 26);
            this.label2.TabIndex = 73;
            this.label2.Text = "Vorname:";
            // 
            // txtbVorname
            // 
            this.txtbVorname.Location = new System.Drawing.Point(231, 205);
            this.txtbVorname.Name = "txtbVorname";
            this.txtbVorname.ReadOnly = true;
            this.txtbVorname.Size = new System.Drawing.Size(312, 26);
            this.txtbVorname.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(494, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 34);
            this.label1.TabIndex = 71;
            this.label1.Text = "mitarbeiter bearbeiten";
            // 
            // btnLoeschen
            // 
            this.btnLoeschen.Location = new System.Drawing.Point(525, 855);
            this.btnLoeschen.Name = "btnLoeschen";
            this.btnLoeschen.Size = new System.Drawing.Size(150, 68);
            this.btnLoeschen.TabIndex = 147;
            this.btnLoeschen.Text = "Löschen";
            this.btnLoeschen.UseVisualStyleBackColor = true;
            this.btnLoeschen.Click += new System.EventHandler(this.btnLoeschen_Click);
            // 
            // btnBearbeiten
            // 
            this.btnBearbeiten.Location = new System.Drawing.Point(681, 855);
            this.btnBearbeiten.Name = "btnBearbeiten";
            this.btnBearbeiten.Size = new System.Drawing.Size(150, 68);
            this.btnBearbeiten.TabIndex = 146;
            this.btnBearbeiten.Text = "Bearbeiten";
            this.btnBearbeiten.UseVisualStyleBackColor = true;
            this.btnBearbeiten.Click += new System.EventHandler(this.btnBearbeiten_Click);
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Enabled = false;
            this.btnSpeichern.Location = new System.Drawing.Point(837, 855);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(150, 68);
            this.btnSpeichern.TabIndex = 145;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // MitarbeiterBearbeiten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLoeschen);
            this.Controls.Add(this.btnBearbeiten);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.cbxLehrling);
            this.Controls.Add(this.cbxAustrittsdatum);
            this.Controls.Add(this.txtbAktuelleslehrjahr);
            this.Controls.Add(this.txtbLehrjahre);
            this.Controls.Add(this.txtbKaderStufe);
            this.Controls.Add(this.txtbBeschaeftigungsgrad);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbGeschlecht);
            this.Controls.Add(this.cmbAnrede);
            this.Controls.Add(this.lblAktuelleslehrjahr);
            this.Controls.Add(this.lblLehrjahre);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtbRolle);
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
            this.Name = "MitarbeiterBearbeiten";
            this.Size = new System.Drawing.Size(1167, 1015);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxLehrling;
        private System.Windows.Forms.CheckBox cbxAustrittsdatum;
        private System.Windows.Forms.TextBox txtbAktuelleslehrjahr;
        private System.Windows.Forms.TextBox txtbLehrjahre;
        private System.Windows.Forms.TextBox txtbKaderStufe;
        private System.Windows.Forms.TextBox txtbBeschaeftigungsgrad;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbGeschlecht;
        private System.Windows.Forms.ComboBox cmbAnrede;
        private System.Windows.Forms.Label lblAktuelleslehrjahr;
        private System.Windows.Forms.Label lblLehrjahre;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtbRolle;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DateTimePicker dtpaustrittsdatum;
        private System.Windows.Forms.DateTimePicker dtpEintrittsdatum;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtbAHV;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtbAbteilung;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtbMitarbeiternummer;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtbPLZ;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtbAdresse;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtbNationalitaet;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtbWohnort;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbTelefonPrivat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtbMobilenummer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbGeschaeftsnummer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbTitel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpGeburtsdatum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbNachname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbVorname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoeschen;
        private System.Windows.Forms.Button btnBearbeiten;
        private System.Windows.Forms.Button btnSpeichern;
    }
}
