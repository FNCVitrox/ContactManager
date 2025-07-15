namespace Contact_Manager
{
    partial class AddKunde
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
            this.lblAddKunde = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbGeschlecht = new System.Windows.Forms.ComboBox();
            this.cmbAnrede = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.lblTelefonNummer = new System.Windows.Forms.Label();
            this.txtbTelefonPrivat = new System.Windows.Forms.TextBox();
            this.lblMobileNummer = new System.Windows.Forms.Label();
            this.txtbMobilenummer = new System.Windows.Forms.TextBox();
            this.lblGeschaeftsnummer = new System.Windows.Forms.Label();
            this.txtbGeschaeftsnummer = new System.Windows.Forms.TextBox();
            this.lblTitel = new System.Windows.Forms.Label();
            this.txtbTitel = new System.Windows.Forms.TextBox();
            this.lblGeschlecht = new System.Windows.Forms.Label();
            this.dtpGeburtsdatum = new System.Windows.Forms.DateTimePicker();
            this.lblAnrede = new System.Windows.Forms.Label();
            this.lblGeburtsdatum = new System.Windows.Forms.Label();
            this.lblNachname = new System.Windows.Forms.Label();
            this.txtbNachname = new System.Windows.Forms.TextBox();
            this.lblVorname = new System.Windows.Forms.Label();
            this.txtbVorname = new System.Windows.Forms.TextBox();
            this.lblPLZ = new System.Windows.Forms.Label();
            this.txtbPLZ = new System.Windows.Forms.TextBox();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.txtbAdresse = new System.Windows.Forms.TextBox();
            this.lblNationalitaet = new System.Windows.Forms.Label();
            this.txtbNationalitaet = new System.Windows.Forms.TextBox();
            this.lblWohnort = new System.Windows.Forms.Label();
            this.txtbWohnort = new System.Windows.Forms.TextBox();
            this.lblFirmenname = new System.Windows.Forms.Label();
            this.txtbFirmenname = new System.Windows.Forms.TextBox();
            this.txtbGeschaeftsadresse = new System.Windows.Forms.TextBox();
            this.lblGeschaeftsadresse = new System.Windows.Forms.Label();
            this.lblKundenTyp = new System.Windows.Forms.Label();
            this.txtbKundentyp = new System.Windows.Forms.TextBox();
            this.txtbFirmenkontakt = new System.Windows.Forms.TextBox();
            this.lblFirmenkontakt = new System.Windows.Forms.Label();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddKunde
            // 
            this.lblAddKunde.AutoSize = true;
            this.lblAddKunde.Location = new System.Drawing.Point(463, 78);
            this.lblAddKunde.Name = "lblAddKunde";
            this.lblAddKunde.Size = new System.Drawing.Size(104, 20);
            this.lblAddKunde.TabIndex = 0;
            this.lblAddKunde.Text = "ADD KUNDE";
            this.lblAddKunde.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(251, 746);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 28);
            this.cmbStatus.TabIndex = 85;
            // 
            // cmbGeschlecht
            // 
            this.cmbGeschlecht.FormattingEnabled = true;
            this.cmbGeschlecht.Location = new System.Drawing.Point(251, 468);
            this.cmbGeschlecht.Name = "cmbGeschlecht";
            this.cmbGeschlecht.Size = new System.Drawing.Size(121, 28);
            this.cmbGeschlecht.TabIndex = 84;
            // 
            // cmbAnrede
            // 
            this.cmbAnrede.FormattingEnabled = true;
            this.cmbAnrede.Location = new System.Drawing.Point(251, 221);
            this.cmbAnrede.Name = "cmbAnrede";
            this.cmbAnrede.Size = new System.Drawing.Size(121, 28);
            this.cmbAnrede.TabIndex = 83;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(85, 743);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(160, 26);
            this.lblStatus.TabIndex = 82;
            this.lblStatus.Text = "Status:";
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(85, 694);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(160, 26);
            this.lblEmail.TabIndex = 81;
            this.lblEmail.Text = "E-Mail:";
            // 
            // txtbEmail
            // 
            this.txtbEmail.Location = new System.Drawing.Point(251, 694);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(100, 26);
            this.txtbEmail.TabIndex = 80;
            // 
            // lblTelefonNummer
            // 
            this.lblTelefonNummer.Location = new System.Drawing.Point(85, 645);
            this.lblTelefonNummer.Name = "lblTelefonNummer";
            this.lblTelefonNummer.Size = new System.Drawing.Size(160, 26);
            this.lblTelefonNummer.TabIndex = 79;
            this.lblTelefonNummer.Text = "Telefon Privat:";
            // 
            // txtbTelefonPrivat
            // 
            this.txtbTelefonPrivat.Location = new System.Drawing.Point(251, 645);
            this.txtbTelefonPrivat.Name = "txtbTelefonPrivat";
            this.txtbTelefonPrivat.Size = new System.Drawing.Size(100, 26);
            this.txtbTelefonPrivat.TabIndex = 78;
            // 
            // lblMobileNummer
            // 
            this.lblMobileNummer.Location = new System.Drawing.Point(85, 597);
            this.lblMobileNummer.Name = "lblMobileNummer";
            this.lblMobileNummer.Size = new System.Drawing.Size(160, 26);
            this.lblMobileNummer.TabIndex = 77;
            this.lblMobileNummer.Text = "Mobile Nummer:";
            // 
            // txtbMobilenummer
            // 
            this.txtbMobilenummer.Location = new System.Drawing.Point(251, 597);
            this.txtbMobilenummer.Name = "txtbMobilenummer";
            this.txtbMobilenummer.Size = new System.Drawing.Size(100, 26);
            this.txtbMobilenummer.TabIndex = 76;
            // 
            // lblGeschaeftsnummer
            // 
            this.lblGeschaeftsnummer.Location = new System.Drawing.Point(85, 555);
            this.lblGeschaeftsnummer.Name = "lblGeschaeftsnummer";
            this.lblGeschaeftsnummer.Size = new System.Drawing.Size(160, 26);
            this.lblGeschaeftsnummer.TabIndex = 75;
            this.lblGeschaeftsnummer.Text = "Geschäftsnummer:";
            // 
            // txtbGeschaeftsnummer
            // 
            this.txtbGeschaeftsnummer.Location = new System.Drawing.Point(251, 555);
            this.txtbGeschaeftsnummer.Name = "txtbGeschaeftsnummer";
            this.txtbGeschaeftsnummer.Size = new System.Drawing.Size(100, 26);
            this.txtbGeschaeftsnummer.TabIndex = 74;
            // 
            // lblTitel
            // 
            this.lblTitel.Location = new System.Drawing.Point(85, 514);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(160, 26);
            this.lblTitel.TabIndex = 73;
            this.lblTitel.Text = "Titel:";
            // 
            // txtbTitel
            // 
            this.txtbTitel.Location = new System.Drawing.Point(251, 514);
            this.txtbTitel.Name = "txtbTitel";
            this.txtbTitel.Size = new System.Drawing.Size(100, 26);
            this.txtbTitel.TabIndex = 72;
            // 
            // lblGeschlecht
            // 
            this.lblGeschlecht.Location = new System.Drawing.Point(85, 471);
            this.lblGeschlecht.Name = "lblGeschlecht";
            this.lblGeschlecht.Size = new System.Drawing.Size(160, 26);
            this.lblGeschlecht.TabIndex = 71;
            this.lblGeschlecht.Text = "Geschlecht:";
            // 
            // dtpGeburtsdatum
            // 
            this.dtpGeburtsdatum.Location = new System.Drawing.Point(251, 404);
            this.dtpGeburtsdatum.Name = "dtpGeburtsdatum";
            this.dtpGeburtsdatum.Size = new System.Drawing.Size(312, 26);
            this.dtpGeburtsdatum.TabIndex = 70;
            // 
            // lblAnrede
            // 
            this.lblAnrede.Location = new System.Drawing.Point(85, 221);
            this.lblAnrede.Name = "lblAnrede";
            this.lblAnrede.Size = new System.Drawing.Size(160, 26);
            this.lblAnrede.TabIndex = 69;
            this.lblAnrede.Text = "Anrede";
            // 
            // lblGeburtsdatum
            // 
            this.lblGeburtsdatum.Location = new System.Drawing.Point(85, 409);
            this.lblGeburtsdatum.Name = "lblGeburtsdatum";
            this.lblGeburtsdatum.Size = new System.Drawing.Size(160, 26);
            this.lblGeburtsdatum.TabIndex = 68;
            this.lblGeburtsdatum.Text = "Geburtsdatum:";
            // 
            // lblNachname
            // 
            this.lblNachname.Location = new System.Drawing.Point(85, 337);
            this.lblNachname.Name = "lblNachname";
            this.lblNachname.Size = new System.Drawing.Size(160, 26);
            this.lblNachname.TabIndex = 67;
            this.lblNachname.Text = "Nachname:";
            // 
            // txtbNachname
            // 
            this.txtbNachname.Location = new System.Drawing.Point(251, 337);
            this.txtbNachname.Name = "txtbNachname";
            this.txtbNachname.Size = new System.Drawing.Size(100, 26);
            this.txtbNachname.TabIndex = 66;
            // 
            // lblVorname
            // 
            this.lblVorname.Location = new System.Drawing.Point(85, 273);
            this.lblVorname.Name = "lblVorname";
            this.lblVorname.Size = new System.Drawing.Size(160, 26);
            this.lblVorname.TabIndex = 65;
            this.lblVorname.Text = "Vorname:";
            // 
            // txtbVorname
            // 
            this.txtbVorname.Location = new System.Drawing.Point(251, 273);
            this.txtbVorname.Name = "txtbVorname";
            this.txtbVorname.Size = new System.Drawing.Size(100, 26);
            this.txtbVorname.TabIndex = 64;
            // 
            // lblPLZ
            // 
            this.lblPLZ.Location = new System.Drawing.Point(588, 370);
            this.lblPLZ.Name = "lblPLZ";
            this.lblPLZ.Size = new System.Drawing.Size(160, 26);
            this.lblPLZ.TabIndex = 93;
            this.lblPLZ.Text = "PLZ:";
            // 
            // txtbPLZ
            // 
            this.txtbPLZ.Location = new System.Drawing.Point(754, 370);
            this.txtbPLZ.Name = "txtbPLZ";
            this.txtbPLZ.Size = new System.Drawing.Size(100, 26);
            this.txtbPLZ.TabIndex = 92;
            // 
            // lblAdresse
            // 
            this.lblAdresse.Location = new System.Drawing.Point(588, 327);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(160, 26);
            this.lblAdresse.TabIndex = 91;
            this.lblAdresse.Text = "Adresse:";
            // 
            // txtbAdresse
            // 
            this.txtbAdresse.Location = new System.Drawing.Point(754, 327);
            this.txtbAdresse.Name = "txtbAdresse";
            this.txtbAdresse.Size = new System.Drawing.Size(100, 26);
            this.txtbAdresse.TabIndex = 90;
            // 
            // lblNationalitaet
            // 
            this.lblNationalitaet.Location = new System.Drawing.Point(588, 276);
            this.lblNationalitaet.Name = "lblNationalitaet";
            this.lblNationalitaet.Size = new System.Drawing.Size(160, 26);
            this.lblNationalitaet.TabIndex = 89;
            this.lblNationalitaet.Text = "Nationalität:";
            // 
            // txtbNationalitaet
            // 
            this.txtbNationalitaet.Location = new System.Drawing.Point(754, 276);
            this.txtbNationalitaet.Name = "txtbNationalitaet";
            this.txtbNationalitaet.Size = new System.Drawing.Size(100, 26);
            this.txtbNationalitaet.TabIndex = 88;
            // 
            // lblWohnort
            // 
            this.lblWohnort.Location = new System.Drawing.Point(588, 221);
            this.lblWohnort.Name = "lblWohnort";
            this.lblWohnort.Size = new System.Drawing.Size(160, 26);
            this.lblWohnort.TabIndex = 87;
            this.lblWohnort.Text = "Wohnort:";
            // 
            // txtbWohnort
            // 
            this.txtbWohnort.Location = new System.Drawing.Point(754, 221);
            this.txtbWohnort.Name = "txtbWohnort";
            this.txtbWohnort.Size = new System.Drawing.Size(100, 26);
            this.txtbWohnort.TabIndex = 86;
            // 
            // lblFirmenname
            // 
            this.lblFirmenname.AutoSize = true;
            this.lblFirmenname.Location = new System.Drawing.Point(588, 436);
            this.lblFirmenname.Name = "lblFirmenname";
            this.lblFirmenname.Size = new System.Drawing.Size(98, 20);
            this.lblFirmenname.TabIndex = 94;
            this.lblFirmenname.Text = "Firmenname";
            // 
            // txtbFirmenname
            // 
            this.txtbFirmenname.Location = new System.Drawing.Point(754, 436);
            this.txtbFirmenname.Name = "txtbFirmenname";
            this.txtbFirmenname.Size = new System.Drawing.Size(100, 26);
            this.txtbFirmenname.TabIndex = 95;
            // 
            // txtbGeschaeftsadresse
            // 
            this.txtbGeschaeftsadresse.Location = new System.Drawing.Point(754, 486);
            this.txtbGeschaeftsadresse.Name = "txtbGeschaeftsadresse";
            this.txtbGeschaeftsadresse.Size = new System.Drawing.Size(100, 26);
            this.txtbGeschaeftsadresse.TabIndex = 96;
            // 
            // lblGeschaeftsadresse
            // 
            this.lblGeschaeftsadresse.AutoSize = true;
            this.lblGeschaeftsadresse.Location = new System.Drawing.Point(588, 486);
            this.lblGeschaeftsadresse.Name = "lblGeschaeftsadresse";
            this.lblGeschaeftsadresse.Size = new System.Drawing.Size(140, 20);
            this.lblGeschaeftsadresse.TabIndex = 97;
            this.lblGeschaeftsadresse.Text = "Geschäftsadresse";
            // 
            // lblKundenTyp
            // 
            this.lblKundenTyp.AutoSize = true;
            this.lblKundenTyp.Location = new System.Drawing.Point(588, 538);
            this.lblKundenTyp.Name = "lblKundenTyp";
            this.lblKundenTyp.Size = new System.Drawing.Size(85, 20);
            this.lblKundenTyp.TabIndex = 98;
            this.lblKundenTyp.Text = "Kundentyp";
            // 
            // txtbKundentyp
            // 
            this.txtbKundentyp.Location = new System.Drawing.Point(754, 532);
            this.txtbKundentyp.Name = "txtbKundentyp";
            this.txtbKundentyp.Size = new System.Drawing.Size(100, 26);
            this.txtbKundentyp.TabIndex = 99;
            // 
            // txtbFirmenkontakt
            // 
            this.txtbFirmenkontakt.Location = new System.Drawing.Point(754, 583);
            this.txtbFirmenkontakt.Name = "txtbFirmenkontakt";
            this.txtbFirmenkontakt.Size = new System.Drawing.Size(100, 26);
            this.txtbFirmenkontakt.TabIndex = 100;
            // 
            // lblFirmenkontakt
            // 
            this.lblFirmenkontakt.AutoSize = true;
            this.lblFirmenkontakt.Location = new System.Drawing.Point(588, 583);
            this.lblFirmenkontakt.Name = "lblFirmenkontakt";
            this.lblFirmenkontakt.Size = new System.Drawing.Size(111, 20);
            this.lblFirmenkontakt.TabIndex = 101;
            this.lblFirmenkontakt.Text = "Firmenkontakt";
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Location = new System.Drawing.Point(659, 701);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(150, 68);
            this.btnSpeichern.TabIndex = 102;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // AddKunde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.lblFirmenkontakt);
            this.Controls.Add(this.txtbFirmenkontakt);
            this.Controls.Add(this.txtbKundentyp);
            this.Controls.Add(this.lblKundenTyp);
            this.Controls.Add(this.lblGeschaeftsadresse);
            this.Controls.Add(this.txtbGeschaeftsadresse);
            this.Controls.Add(this.txtbFirmenname);
            this.Controls.Add(this.lblFirmenname);
            this.Controls.Add(this.lblPLZ);
            this.Controls.Add(this.txtbPLZ);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.txtbAdresse);
            this.Controls.Add(this.lblNationalitaet);
            this.Controls.Add(this.txtbNationalitaet);
            this.Controls.Add(this.lblWohnort);
            this.Controls.Add(this.txtbWohnort);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbGeschlecht);
            this.Controls.Add(this.cmbAnrede);
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
            this.Controls.Add(this.lblAddKunde);
            this.Name = "AddKunde";
            this.Size = new System.Drawing.Size(1167, 1015);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddKunde;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbGeschlecht;
        private System.Windows.Forms.ComboBox cmbAnrede;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.Label lblTelefonNummer;
        private System.Windows.Forms.TextBox txtbTelefonPrivat;
        private System.Windows.Forms.Label lblMobileNummer;
        private System.Windows.Forms.TextBox txtbMobilenummer;
        private System.Windows.Forms.Label lblGeschaeftsnummer;
        private System.Windows.Forms.TextBox txtbGeschaeftsnummer;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.TextBox txtbTitel;
        private System.Windows.Forms.Label lblGeschlecht;
        private System.Windows.Forms.DateTimePicker dtpGeburtsdatum;
        private System.Windows.Forms.Label lblAnrede;
        private System.Windows.Forms.Label lblGeburtsdatum;
        private System.Windows.Forms.Label lblNachname;
        private System.Windows.Forms.TextBox txtbNachname;
        private System.Windows.Forms.Label lblVorname;
        private System.Windows.Forms.TextBox txtbVorname;
        private System.Windows.Forms.Label lblPLZ;
        private System.Windows.Forms.TextBox txtbPLZ;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.TextBox txtbAdresse;
        private System.Windows.Forms.Label lblNationalitaet;
        private System.Windows.Forms.TextBox txtbNationalitaet;
        private System.Windows.Forms.Label lblWohnort;
        private System.Windows.Forms.TextBox txtbWohnort;
        private System.Windows.Forms.Label lblFirmenname;
        private System.Windows.Forms.TextBox txtbFirmenname;
        private System.Windows.Forms.TextBox txtbGeschaeftsadresse;
        private System.Windows.Forms.Label lblGeschaeftsadresse;
        private System.Windows.Forms.Label lblKundenTyp;
        private System.Windows.Forms.TextBox txtbKundentyp;
        private System.Windows.Forms.TextBox txtbFirmenkontakt;
        private System.Windows.Forms.Label lblFirmenkontakt;
        private System.Windows.Forms.Button btnSpeichern;
    }
}
