namespace Contact_Manager
{
    partial class Suchen
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
            this.lblSuchen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSuchen
            // 
            this.lblSuchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuchen.Location = new System.Drawing.Point(213, 95);
            this.lblSuchen.Name = "lblSuchen";
            this.lblSuchen.Size = new System.Drawing.Size(134, 57);
            this.lblSuchen.TabIndex = 0;
            this.lblSuchen.Text = "Suchen";
            // 
            // Suchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSuchen);
            this.Name = "Suchen";
            this.Size = new System.Drawing.Size(1167, 1015);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSuchen;
    }
}
