namespace Contact_Manager
{
    partial class mainmenu
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
            this.btnNeu = new System.Windows.Forms.Button();
            this.btnSuchen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNeu
            // 
            this.btnNeu.Location = new System.Drawing.Point(539, 154);
            this.btnNeu.Name = "btnNeu";
            this.btnNeu.Size = new System.Drawing.Size(169, 98);
            this.btnNeu.TabIndex = 0;
            this.btnNeu.Text = "neu";
            this.btnNeu.UseVisualStyleBackColor = true;
            this.btnNeu.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSuchen
            // 
            this.btnSuchen.Location = new System.Drawing.Point(816, 154);
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Size = new System.Drawing.Size(169, 98);
            this.btnSuchen.TabIndex = 1;
            this.btnSuchen.Text = "suchen";
            this.btnSuchen.UseVisualStyleBackColor = true;
            this.btnSuchen.Click += new System.EventHandler(this.button2_Click);
            // 
            // mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSuchen);
            this.Controls.Add(this.btnNeu);
            this.Name = "mainmenu";
            this.Size = new System.Drawing.Size(1594, 1000);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNeu;
        private System.Windows.Forms.Button btnSuchen;
    }
}
