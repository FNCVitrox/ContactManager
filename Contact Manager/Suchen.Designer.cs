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
            this.txtbSuchen = new System.Windows.Forms.TextBox();
            this.dgvErgebnisse = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErgebnisse)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSuchen
            // 
            this.lblSuchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuchen.Location = new System.Drawing.Point(32, 15);
            this.lblSuchen.Name = "lblSuchen";
            this.lblSuchen.Size = new System.Drawing.Size(111, 42);
            this.lblSuchen.TabIndex = 0;
            this.lblSuchen.Text = "Suchen";
            // 
            // txtbSuchen
            // 
            this.txtbSuchen.Location = new System.Drawing.Point(403, 43);
            this.txtbSuchen.Name = "txtbSuchen";
            this.txtbSuchen.Size = new System.Drawing.Size(257, 26);
            this.txtbSuchen.TabIndex = 1;
            this.txtbSuchen.TextChanged += new System.EventHandler(this.txtbSuchen_TextChanged);
            // 
            // dgvErgebnisse
            // 
            this.dgvErgebnisse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvErgebnisse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvErgebnisse.Location = new System.Drawing.Point(21, 101);
            this.dgvErgebnisse.Name = "dgvErgebnisse";
            this.dgvErgebnisse.ReadOnly = true;
            this.dgvErgebnisse.RowHeadersWidth = 62;
            this.dgvErgebnisse.RowTemplate.Height = 28;
            this.dgvErgebnisse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvErgebnisse.Size = new System.Drawing.Size(1121, 875);
            this.dgvErgebnisse.TabIndex = 2;
            // 
            // Suchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvErgebnisse);
            this.Controls.Add(this.txtbSuchen);
            this.Controls.Add(this.lblSuchen);
            this.Name = "Suchen";
            this.Size = new System.Drawing.Size(1167, 1015);
            this.Load += new System.EventHandler(this.Suchen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvErgebnisse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSuchen;
        private System.Windows.Forms.TextBox txtbSuchen;
        private System.Windows.Forms.DataGridView dgvErgebnisse;
    }
}
