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
            this.lblAddMitarbeiter = new System.Windows.Forms.Label();
            this.txtbVorname = new System.Windows.Forms.TextBox();
            this.lblVorname = new System.Windows.Forms.Label();
            this.lblNachname = new System.Windows.Forms.Label();
            this.txtbNachname = new System.Windows.Forms.TextBox();
            this.lblAnrede = new System.Windows.Forms.Label();
            this.lblGeburtsdatum = new System.Windows.Forms.Label();
            this.dtpGeburtsdatum = new System.Windows.Forms.DateTimePicker();
            this.lblGeschlecht = new System.Windows.Forms.Label();
            this.lblTitel = new System.Windows.Forms.Label();
            this.txtbTitel = new System.Windows.Forms.TextBox();
            this.lblGeschaeftsnummer = new System.Windows.Forms.Label();
            this.txtbGeschaeftsnummer = new System.Windows.Forms.TextBox();
            this.lblMobileNummer = new System.Windows.Forms.Label();
            this.txtbMobilenummer = new System.Windows.Forms.TextBox();
            this.lblTelefonNummer = new System.Windows.Forms.Label();
            this.txtbTelefonPrivat = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblWohnort = new System.Windows.Forms.Label();
            this.txtbWohnort = new System.Windows.Forms.TextBox();
            this.lblNationalitaet = new System.Windows.Forms.Label();
            this.txtbNationalitaet = new System.Windows.Forms.TextBox();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.txtbAdresse = new System.Windows.Forms.TextBox();
            this.lblPLZ = new System.Windows.Forms.Label();
            this.txtbPLZ = new System.Windows.Forms.TextBox();
            this.lblMitarbeiternummer = new System.Windows.Forms.Label();
            this.txtbMitarbeiternummer = new System.Windows.Forms.TextBox();
            this.lblAbteilung = new System.Windows.Forms.Label();
            this.txtbAbteilung = new System.Windows.Forms.TextBox();
            this.lblAHV = new System.Windows.Forms.Label();
            this.txtbAHV = new System.Windows.Forms.TextBox();
            this.lblEintrittsdatum = new System.Windows.Forms.Label();
            this.lblaustrittsdatum = new System.Windows.Forms.Label();
            this.dtpEintrittsdatum = new System.Windows.Forms.DateTimePicker();
            this.dtpaustrittsdatum = new System.Windows.Forms.DateTimePicker();
            this.lblBeschaeftigungsgrad = new System.Windows.Forms.Label();
            this.lblRolle = new System.Windows.Forms.Label();
            this.txtbRolle = new System.Windows.Forms.TextBox();
            this.lblKaderStufe = new System.Windows.Forms.Label();
            this.lblLehrjahre = new System.Windows.Forms.Label();
            this.lblAktuelleslehrjahr = new System.Windows.Forms.Label();
            this.cmbAnrede = new System.Windows.Forms.ComboBox();
            this.cmbGeschlecht = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.txtbBeschaeftigungsgrad = new System.Windows.Forms.TextBox();
            this.txtbKaderStufe = new System.Windows.Forms.TextBox();
            this.txtbLehrjahre = new System.Windows.Forms.TextBox();
            this.txtbAktuelleslehrjahr = new System.Windows.Forms.TextBox();
            this.cbxAustrittsdatum = new System.Windows.Forms.CheckBox();
            this.cbxLehrling = new System.Windows.Forms.CheckBox();
            this.lblLehrling = new System.Windows.Forms.Label();
            this.BtnZurueck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddMitarbeiter
            // 
            this.lblAddMitarbeiter.Location = new System.Drawing.Point(629, 41);
            this.lblAddMitarbeiter.Name = "lblAddMitarbeiter";
            this.lblAddMitarbeiter.Size = new System.Drawing.Size(190, 34);
            this.lblAddMitarbeiter.TabIndex = 0;
            this.lblAddMitarbeiter.Text = "add mitarbeiter";
            this.lblAddMitarbeiter.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtbVorname
            // 
            this.txtbVorname.Location = new System.Drawing.Point(351, 245);
            this.txtbVorname.Name = "txtbVorname";
            this.txtbVorname.Size = new System.Drawing.Size(100, 26);
            this.txtbVorname.TabIndex = 1;
            this.txtbVorname.TextChanged += new System.EventHandler(this.txtbVorname_TextChanged);
            // 
            // lblVorname
            // 
            this.lblVorname.Location = new System.Drawing.Point(185, 245);
            this.lblVorname.Name = "lblVorname";
            this.lblVorname.Size = new System.Drawing.Size(160, 26);
            this.lblVorname.TabIndex = 2;
            this.lblVorname.Text = "Vorname:";
            // 
            // lblNachname
            // 
            this.lblNachname.Location = new System.Drawing.Point(185, 309);
            this.lblNachname.Name = "lblNachname";
            this.lblNachname.Size = new System.Drawing.Size(160, 26);
            this.lblNachname.TabIndex = 4;
            this.lblNachname.Text = "Nachname:";
            // 
            // txtbNachname
            // 
            this.txtbNachname.Location = new System.Drawing.Point(351, 309);
            this.txtbNachname.Name = "txtbNachname";
            this.txtbNachname.Size = new System.Drawing.Size(100, 26);
            this.txtbNachname.TabIndex = 3;
            this.txtbNachname.TextChanged += new System.EventHandler(this.txtbNachname_TextChanged);
            // 
            // lblAnrede
            // 
            this.lblAnrede.Location = new System.Drawing.Point(185, 193);
            this.lblAnrede.Name = "lblAnrede";
            this.lblAnrede.Size = new System.Drawing.Size(160, 26);
            this.lblAnrede.TabIndex = 8;
            this.lblAnrede.Text = "Anrede";
            // 
            // lblGeburtsdatum
            // 
            this.lblGeburtsdatum.Location = new System.Drawing.Point(185, 381);
            this.lblGeburtsdatum.Name = "lblGeburtsdatum";
            this.lblGeburtsdatum.Size = new System.Drawing.Size(160, 26);
            this.lblGeburtsdatum.TabIndex = 6;
            this.lblGeburtsdatum.Text = "Geburtsdatum:";
            // 
            // dtpGeburtsdatum
            // 
            this.dtpGeburtsdatum.Location = new System.Drawing.Point(351, 376);
            this.dtpGeburtsdatum.Name = "dtpGeburtsdatum";
            this.dtpGeburtsdatum.Size = new System.Drawing.Size(312, 26);
            this.dtpGeburtsdatum.TabIndex = 10;
            // 
            // lblGeschlecht
            // 
            this.lblGeschlecht.Location = new System.Drawing.Point(185, 443);
            this.lblGeschlecht.Name = "lblGeschlecht";
            this.lblGeschlecht.Size = new System.Drawing.Size(160, 26);
            this.lblGeschlecht.TabIndex = 11;
            this.lblGeschlecht.Text = "Geschlecht:";
            // 
            // lblTitel
            // 
            this.lblTitel.Location = new System.Drawing.Point(185, 486);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(160, 26);
            this.lblTitel.TabIndex = 16;
            this.lblTitel.Text = "Titel:";
            // 
            // txtbTitel
            // 
            this.txtbTitel.Location = new System.Drawing.Point(351, 486);
            this.txtbTitel.Name = "txtbTitel";
            this.txtbTitel.Size = new System.Drawing.Size(100, 26);
            this.txtbTitel.TabIndex = 15;
            // 
            // lblGeschaeftsnummer
            // 
            this.lblGeschaeftsnummer.Location = new System.Drawing.Point(185, 527);
            this.lblGeschaeftsnummer.Name = "lblGeschaeftsnummer";
            this.lblGeschaeftsnummer.Size = new System.Drawing.Size(160, 26);
            this.lblGeschaeftsnummer.TabIndex = 18;
            this.lblGeschaeftsnummer.Text = "Geschäftsnummer:";
            // 
            // txtbGeschaeftsnummer
            // 
            this.txtbGeschaeftsnummer.Location = new System.Drawing.Point(351, 527);
            this.txtbGeschaeftsnummer.Name = "txtbGeschaeftsnummer";
            this.txtbGeschaeftsnummer.Size = new System.Drawing.Size(100, 26);
            this.txtbGeschaeftsnummer.TabIndex = 17;
            // 
            // lblMobileNummer
            // 
            this.lblMobileNummer.Location = new System.Drawing.Point(185, 569);
            this.lblMobileNummer.Name = "lblMobileNummer";
            this.lblMobileNummer.Size = new System.Drawing.Size(160, 26);
            this.lblMobileNummer.TabIndex = 20;
            this.lblMobileNummer.Text = "Mobile Nummer:";
            // 
            // txtbMobilenummer
            // 
            this.txtbMobilenummer.Location = new System.Drawing.Point(351, 569);
            this.txtbMobilenummer.Name = "txtbMobilenummer";
            this.txtbMobilenummer.Size = new System.Drawing.Size(100, 26);
            this.txtbMobilenummer.TabIndex = 19;
            // 
            // lblTelefonNummer
            // 
            this.lblTelefonNummer.Location = new System.Drawing.Point(185, 617);
            this.lblTelefonNummer.Name = "lblTelefonNummer";
            this.lblTelefonNummer.Size = new System.Drawing.Size(160, 26);
            this.lblTelefonNummer.TabIndex = 22;
            this.lblTelefonNummer.Text = "Telefon Privat:";
            // 
            // txtbTelefonPrivat
            // 
            this.txtbTelefonPrivat.Location = new System.Drawing.Point(351, 617);
            this.txtbTelefonPrivat.Name = "txtbTelefonPrivat";
            this.txtbTelefonPrivat.Size = new System.Drawing.Size(100, 26);
            this.txtbTelefonPrivat.TabIndex = 21;
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(185, 666);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(160, 26);
            this.lblEmail.TabIndex = 24;
            this.lblEmail.Text = "E-Mail:";
            // 
            // txtbEmail
            // 
            this.txtbEmail.Location = new System.Drawing.Point(351, 666);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(100, 26);
            this.txtbEmail.TabIndex = 23;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(185, 715);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(160, 26);
            this.lblStatus.TabIndex = 26;
            this.lblStatus.Text = "Status:";
            // 
            // lblWohnort
            // 
            this.lblWohnort.Location = new System.Drawing.Point(949, 190);
            this.lblWohnort.Name = "lblWohnort";
            this.lblWohnort.Size = new System.Drawing.Size(160, 26);
            this.lblWohnort.TabIndex = 29;
            this.lblWohnort.Text = "Wohnort:";
            // 
            // txtbWohnort
            // 
            this.txtbWohnort.Location = new System.Drawing.Point(1115, 190);
            this.txtbWohnort.Name = "txtbWohnort";
            this.txtbWohnort.Size = new System.Drawing.Size(100, 26);
            this.txtbWohnort.TabIndex = 28;
            // 
            // lblNationalitaet
            // 
            this.lblNationalitaet.Location = new System.Drawing.Point(949, 245);
            this.lblNationalitaet.Name = "lblNationalitaet";
            this.lblNationalitaet.Size = new System.Drawing.Size(160, 26);
            this.lblNationalitaet.TabIndex = 31;
            this.lblNationalitaet.Text = "Nationalität:";
            // 
            // txtbNationalitaet
            // 
            this.txtbNationalitaet.Location = new System.Drawing.Point(1115, 245);
            this.txtbNationalitaet.Name = "txtbNationalitaet";
            this.txtbNationalitaet.Size = new System.Drawing.Size(100, 26);
            this.txtbNationalitaet.TabIndex = 30;
            // 
            // lblAdresse
            // 
            this.lblAdresse.Location = new System.Drawing.Point(949, 296);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(160, 26);
            this.lblAdresse.TabIndex = 33;
            this.lblAdresse.Text = "Adresse:";
            // 
            // txtbAdresse
            // 
            this.txtbAdresse.Location = new System.Drawing.Point(1115, 296);
            this.txtbAdresse.Name = "txtbAdresse";
            this.txtbAdresse.Size = new System.Drawing.Size(100, 26);
            this.txtbAdresse.TabIndex = 32;
            // 
            // lblPLZ
            // 
            this.lblPLZ.Location = new System.Drawing.Point(949, 339);
            this.lblPLZ.Name = "lblPLZ";
            this.lblPLZ.Size = new System.Drawing.Size(160, 26);
            this.lblPLZ.TabIndex = 35;
            this.lblPLZ.Text = "PLZ:";
            // 
            // txtbPLZ
            // 
            this.txtbPLZ.Location = new System.Drawing.Point(1115, 339);
            this.txtbPLZ.Name = "txtbPLZ";
            this.txtbPLZ.Size = new System.Drawing.Size(100, 26);
            this.txtbPLZ.TabIndex = 34;
            // 
            // lblMitarbeiternummer
            // 
            this.lblMitarbeiternummer.Location = new System.Drawing.Point(949, 394);
            this.lblMitarbeiternummer.Name = "lblMitarbeiternummer";
            this.lblMitarbeiternummer.Size = new System.Drawing.Size(160, 26);
            this.lblMitarbeiternummer.TabIndex = 37;
            this.lblMitarbeiternummer.Text = "Mitarbeiter Nummer";
            // 
            // txtbMitarbeiternummer
            // 
            this.txtbMitarbeiternummer.Location = new System.Drawing.Point(1115, 394);
            this.txtbMitarbeiternummer.Name = "txtbMitarbeiternummer";
            this.txtbMitarbeiternummer.Size = new System.Drawing.Size(100, 26);
            this.txtbMitarbeiternummer.TabIndex = 36;
            // 
            // lblAbteilung
            // 
            this.lblAbteilung.Location = new System.Drawing.Point(949, 443);
            this.lblAbteilung.Name = "lblAbteilung";
            this.lblAbteilung.Size = new System.Drawing.Size(160, 26);
            this.lblAbteilung.TabIndex = 39;
            this.lblAbteilung.Text = "Abteilung";
            // 
            // txtbAbteilung
            // 
            this.txtbAbteilung.Location = new System.Drawing.Point(1115, 443);
            this.txtbAbteilung.Name = "txtbAbteilung";
            this.txtbAbteilung.Size = new System.Drawing.Size(100, 26);
            this.txtbAbteilung.TabIndex = 38;
            // 
            // lblAHV
            // 
            this.lblAHV.Location = new System.Drawing.Point(949, 486);
            this.lblAHV.Name = "lblAHV";
            this.lblAHV.Size = new System.Drawing.Size(160, 26);
            this.lblAHV.TabIndex = 41;
            this.lblAHV.Text = "AHV nummer";
            // 
            // txtbAHV
            // 
            this.txtbAHV.Location = new System.Drawing.Point(1115, 486);
            this.txtbAHV.Name = "txtbAHV";
            this.txtbAHV.Size = new System.Drawing.Size(100, 26);
            this.txtbAHV.TabIndex = 40;
            // 
            // lblEintrittsdatum
            // 
            this.lblEintrittsdatum.Location = new System.Drawing.Point(949, 543);
            this.lblEintrittsdatum.Name = "lblEintrittsdatum";
            this.lblEintrittsdatum.Size = new System.Drawing.Size(160, 26);
            this.lblEintrittsdatum.TabIndex = 43;
            this.lblEintrittsdatum.Text = "Eintrittsdatum";
            // 
            // lblaustrittsdatum
            // 
            this.lblaustrittsdatum.Location = new System.Drawing.Point(949, 592);
            this.lblaustrittsdatum.Name = "lblaustrittsdatum";
            this.lblaustrittsdatum.Size = new System.Drawing.Size(160, 26);
            this.lblaustrittsdatum.TabIndex = 45;
            this.lblaustrittsdatum.Text = "austrittsdatum";
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
            this.dtpaustrittsdatum.Visible = false;
            // 
            // lblBeschaeftigungsgrad
            // 
            this.lblBeschaeftigungsgrad.Location = new System.Drawing.Point(949, 638);
            this.lblBeschaeftigungsgrad.Name = "lblBeschaeftigungsgrad";
            this.lblBeschaeftigungsgrad.Size = new System.Drawing.Size(160, 26);
            this.lblBeschaeftigungsgrad.TabIndex = 49;
            this.lblBeschaeftigungsgrad.Text = "Beschäftigungsgrad";
            // 
            // lblRolle
            // 
            this.lblRolle.Location = new System.Drawing.Point(953, 689);
            this.lblRolle.Name = "lblRolle";
            this.lblRolle.Size = new System.Drawing.Size(160, 26);
            this.lblRolle.TabIndex = 52;
            this.lblRolle.Text = "Rolle";
            // 
            // txtbRolle
            // 
            this.txtbRolle.Location = new System.Drawing.Point(1115, 689);
            this.txtbRolle.Name = "txtbRolle";
            this.txtbRolle.Size = new System.Drawing.Size(100, 26);
            this.txtbRolle.TabIndex = 51;
            // 
            // lblKaderStufe
            // 
            this.lblKaderStufe.Location = new System.Drawing.Point(949, 721);
            this.lblKaderStufe.Name = "lblKaderStufe";
            this.lblKaderStufe.Size = new System.Drawing.Size(160, 26);
            this.lblKaderStufe.TabIndex = 54;
            this.lblKaderStufe.Text = "Kader Stufe";
            // 
            // lblLehrjahre
            // 
            this.lblLehrjahre.Location = new System.Drawing.Point(949, 808);
            this.lblLehrjahre.Name = "lblLehrjahre";
            this.lblLehrjahre.Size = new System.Drawing.Size(160, 26);
            this.lblLehrjahre.TabIndex = 56;
            this.lblLehrjahre.Text = "Lehrjahre";
            this.lblLehrjahre.Visible = false;
            // 
            // lblAktuelleslehrjahr
            // 
            this.lblAktuelleslehrjahr.Location = new System.Drawing.Point(949, 850);
            this.lblAktuelleslehrjahr.Name = "lblAktuelleslehrjahr";
            this.lblAktuelleslehrjahr.Size = new System.Drawing.Size(160, 26);
            this.lblAktuelleslehrjahr.TabIndex = 59;
            this.lblAktuelleslehrjahr.Text = "aktuelleslehrjahr";
            this.lblAktuelleslehrjahr.Visible = false;
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
            // txtbBeschaeftigungsgrad
            // 
            this.txtbBeschaeftigungsgrad.Location = new System.Drawing.Point(1115, 638);
            this.txtbBeschaeftigungsgrad.Name = "txtbBeschaeftigungsgrad";
            this.txtbBeschaeftigungsgrad.Size = new System.Drawing.Size(100, 26);
            this.txtbBeschaeftigungsgrad.TabIndex = 65;
            // 
            // txtbKaderStufe
            // 
            this.txtbKaderStufe.Location = new System.Drawing.Point(1115, 721);
            this.txtbKaderStufe.Name = "txtbKaderStufe";
            this.txtbKaderStufe.Size = new System.Drawing.Size(100, 26);
            this.txtbKaderStufe.TabIndex = 66;
            // 
            // txtbLehrjahre
            // 
            this.txtbLehrjahre.Location = new System.Drawing.Point(1104, 805);
            this.txtbLehrjahre.Name = "txtbLehrjahre";
            this.txtbLehrjahre.Size = new System.Drawing.Size(100, 26);
            this.txtbLehrjahre.TabIndex = 67;
            this.txtbLehrjahre.Visible = false;
            this.txtbLehrjahre.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtbAktuelleslehrjahr
            // 
            this.txtbAktuelleslehrjahr.Location = new System.Drawing.Point(1104, 847);
            this.txtbAktuelleslehrjahr.Name = "txtbAktuelleslehrjahr";
            this.txtbAktuelleslehrjahr.Size = new System.Drawing.Size(100, 26);
            this.txtbAktuelleslehrjahr.TabIndex = 68;
            this.txtbAktuelleslehrjahr.Visible = false;
            // 
            // cbxAustrittsdatum
            // 
            this.cbxAustrittsdatum.AutoSize = true;
            this.cbxAustrittsdatum.Location = new System.Drawing.Point(907, 593);
            this.cbxAustrittsdatum.Name = "cbxAustrittsdatum";
            this.cbxAustrittsdatum.Size = new System.Drawing.Size(22, 21);
            this.cbxAustrittsdatum.TabIndex = 70;
            this.cbxAustrittsdatum.UseVisualStyleBackColor = true;
            this.cbxAustrittsdatum.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbxLehrling
            // 
            this.cbxLehrling.AutoSize = true;
            this.cbxLehrling.Location = new System.Drawing.Point(907, 764);
            this.cbxLehrling.Name = "cbxLehrling";
            this.cbxLehrling.Size = new System.Drawing.Size(22, 21);
            this.cbxLehrling.TabIndex = 71;
            this.cbxLehrling.UseVisualStyleBackColor = true;
            this.cbxLehrling.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // lblLehrling
            // 
            this.lblLehrling.AutoSize = true;
            this.lblLehrling.Location = new System.Drawing.Point(953, 764);
            this.lblLehrling.Name = "lblLehrling";
            this.lblLehrling.Size = new System.Drawing.Size(65, 20);
            this.lblLehrling.TabIndex = 72;
            this.lblLehrling.Text = "Lehrling";
            // 
            // BtnZurueck
            // 
            this.BtnZurueck.Location = new System.Drawing.Point(1270, 55);
            this.BtnZurueck.Name = "BtnZurueck";
            this.BtnZurueck.Size = new System.Drawing.Size(168, 83);
            this.BtnZurueck.TabIndex = 73;
            this.BtnZurueck.Text = "Zurück";
            this.BtnZurueck.UseVisualStyleBackColor = true;
            this.BtnZurueck.Click += new System.EventHandler(this.BtnZurueck_Click);
            // 
            // AddMitarbeiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnZurueck);
            this.Controls.Add(this.lblLehrling);
            this.Controls.Add(this.cbxLehrling);
            this.Controls.Add(this.cbxAustrittsdatum);
            this.Controls.Add(this.txtbAktuelleslehrjahr);
            this.Controls.Add(this.txtbLehrjahre);
            this.Controls.Add(this.txtbKaderStufe);
            this.Controls.Add(this.txtbBeschaeftigungsgrad);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbGeschlecht);
            this.Controls.Add(this.cmbAnrede);
            this.Controls.Add(this.lblAktuelleslehrjahr);
            this.Controls.Add(this.lblLehrjahre);
            this.Controls.Add(this.lblKaderStufe);
            this.Controls.Add(this.lblRolle);
            this.Controls.Add(this.txtbRolle);
            this.Controls.Add(this.lblBeschaeftigungsgrad);
            this.Controls.Add(this.dtpaustrittsdatum);
            this.Controls.Add(this.dtpEintrittsdatum);
            this.Controls.Add(this.lblaustrittsdatum);
            this.Controls.Add(this.lblEintrittsdatum);
            this.Controls.Add(this.lblAHV);
            this.Controls.Add(this.txtbAHV);
            this.Controls.Add(this.lblAbteilung);
            this.Controls.Add(this.txtbAbteilung);
            this.Controls.Add(this.lblMitarbeiternummer);
            this.Controls.Add(this.txtbMitarbeiternummer);
            this.Controls.Add(this.lblPLZ);
            this.Controls.Add(this.txtbPLZ);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.txtbAdresse);
            this.Controls.Add(this.lblNationalitaet);
            this.Controls.Add(this.txtbNationalitaet);
            this.Controls.Add(this.lblWohnort);
            this.Controls.Add(this.txtbWohnort);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtbEmail);
            this.Controls.Add(this.lblTelefonNummer);
            this.Controls.Add(this.txtbTelefonPrivat);
            this.Controls.Add(this.lblMobileNummer);
            this.Controls.Add(this.txtbMobilenummer);
            this.Controls.Add(this.lblGeschaeftsnummer);
            this.Controls.Add(this.txtbGeschaeftsnummer);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.txtbTitel);
            this.Controls.Add(this.lblGeschlecht);
            this.Controls.Add(this.dtpGeburtsdatum);
            this.Controls.Add(this.lblAnrede);
            this.Controls.Add(this.lblGeburtsdatum);
            this.Controls.Add(this.lblNachname);
            this.Controls.Add(this.txtbNachname);
            this.Controls.Add(this.lblVorname);
            this.Controls.Add(this.txtbVorname);
            this.Controls.Add(this.lblAddMitarbeiter);
            this.Name = "AddMitarbeiter";
            this.Size = new System.Drawing.Size(1594, 1000);
            this.Load += new System.EventHandler(this.AddMitarbeiter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddMitarbeiter;
        private System.Windows.Forms.TextBox txtbVorname;
        private System.Windows.Forms.Label lblVorname;
        private System.Windows.Forms.Label lblNachname;
        private System.Windows.Forms.TextBox txtbNachname;
        private System.Windows.Forms.Label lblAnrede;
        private System.Windows.Forms.Label lblGeburtsdatum;
        private System.Windows.Forms.DateTimePicker dtpGeburtsdatum;
        private System.Windows.Forms.Label lblGeschlecht;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.TextBox txtbTitel;
        private System.Windows.Forms.Label lblGeschaeftsnummer;
        private System.Windows.Forms.TextBox txtbGeschaeftsnummer;
        private System.Windows.Forms.Label lblMobileNummer;
        private System.Windows.Forms.TextBox txtbMobilenummer;
        private System.Windows.Forms.Label lblTelefonNummer;
        private System.Windows.Forms.TextBox txtbTelefonPrivat;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblWohnort;
        private System.Windows.Forms.TextBox txtbWohnort;
        private System.Windows.Forms.Label lblNationalitaet;
        private System.Windows.Forms.TextBox txtbNationalitaet;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.TextBox txtbAdresse;
        private System.Windows.Forms.Label lblPLZ;
        private System.Windows.Forms.TextBox txtbPLZ;
        private System.Windows.Forms.Label lblMitarbeiternummer;
        private System.Windows.Forms.TextBox txtbMitarbeiternummer;
        private System.Windows.Forms.Label lblAbteilung;
        private System.Windows.Forms.TextBox txtbAbteilung;
        private System.Windows.Forms.Label lblAHV;
        private System.Windows.Forms.TextBox txtbAHV;
        private System.Windows.Forms.Label lblEintrittsdatum;
        private System.Windows.Forms.Label lblaustrittsdatum;
        private System.Windows.Forms.DateTimePicker dtpEintrittsdatum;
        private System.Windows.Forms.DateTimePicker dtpaustrittsdatum;
        private System.Windows.Forms.Label lblBeschaeftigungsgrad;
        private System.Windows.Forms.Label lblRolle;
        private System.Windows.Forms.TextBox txtbRolle;
        private System.Windows.Forms.Label lblKaderStufe;
        private System.Windows.Forms.Label lblLehrjahre;
        private System.Windows.Forms.Label lblAktuelleslehrjahr;
        private System.Windows.Forms.ComboBox cmbAnrede;
        private System.Windows.Forms.ComboBox cmbGeschlecht;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.TextBox txtbBeschaeftigungsgrad;
        private System.Windows.Forms.TextBox txtbKaderStufe;
        private System.Windows.Forms.TextBox txtbLehrjahre;
        private System.Windows.Forms.TextBox txtbAktuelleslehrjahr;
        private System.Windows.Forms.CheckBox cbxAustrittsdatum;
        private System.Windows.Forms.CheckBox cbxLehrling;
        private System.Windows.Forms.Label lblLehrling;
        private System.Windows.Forms.Button BtnZurueck;
    }
}
