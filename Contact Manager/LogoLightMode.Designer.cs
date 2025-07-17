namespace Contact_Manager
{
    partial class LogoLightMode
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
            this.pictureBoxLogoGrossLightMode = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoGrossLightMode)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogoGrossLightMode
            // 
            this.pictureBoxLogoGrossLightMode.BackColor = System.Drawing.Color.White;
            this.pictureBoxLogoGrossLightMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLogoGrossLightMode.Image = global::Contact_Manager.Properties.Resources.imagelightmode;
            this.pictureBoxLogoGrossLightMode.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogoGrossLightMode.Name = "pictureBoxLogoGrossLightMode";
            this.pictureBoxLogoGrossLightMode.Size = new System.Drawing.Size(1167, 1015);
            this.pictureBoxLogoGrossLightMode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogoGrossLightMode.TabIndex = 2;
            this.pictureBoxLogoGrossLightMode.TabStop = false;
            // 
            // LogoLightMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxLogoGrossLightMode);
            this.Name = "LogoLightMode";
            this.Size = new System.Drawing.Size(1167, 1015);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoGrossLightMode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogoGrossLightMode;
    }
}
