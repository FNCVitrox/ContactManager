namespace Contact_Manager
{
    partial class LogoDarkMode
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
            this.pictureBoxLogoGrossDarkMode = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoGrossDarkMode)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogoGrossDarkMode
            // 
            this.pictureBoxLogoGrossDarkMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.pictureBoxLogoGrossDarkMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLogoGrossDarkMode.Image = global::Contact_Manager.Properties.Resources.image;
            this.pictureBoxLogoGrossDarkMode.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogoGrossDarkMode.Name = "pictureBoxLogoGrossDarkMode";
            this.pictureBoxLogoGrossDarkMode.Size = new System.Drawing.Size(1167, 1015);
            this.pictureBoxLogoGrossDarkMode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogoGrossDarkMode.TabIndex = 1;
            this.pictureBoxLogoGrossDarkMode.TabStop = false;
            // 
            // LogoDarkMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxLogoGrossDarkMode);
            this.Name = "LogoDarkMode";
            this.Size = new System.Drawing.Size(1167, 1015);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoGrossDarkMode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogoGrossDarkMode;
    }
}
