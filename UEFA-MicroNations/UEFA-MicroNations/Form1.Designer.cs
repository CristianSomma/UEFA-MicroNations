namespace UEFA_MicroNations
{
    partial class MainForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitleP2 = new System.Windows.Forms.Label();
            this.lblUEFATitle = new System.Windows.Forms.Label();
            this.lstWindow = new System.Windows.Forms.ListView();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(163)))), ((int)(((byte)(55)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(934, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 711);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(163)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.lblTitleP2);
            this.panel2.Controls.Add(this.lblUEFATitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(934, 75);
            this.panel2.TabIndex = 1;
            // 
            // lblTitleP2
            // 
            this.lblTitleP2.AutoSize = true;
            this.lblTitleP2.Font = new System.Drawing.Font("Corbel", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleP2.ForeColor = System.Drawing.Color.White;
            this.lblTitleP2.Location = new System.Drawing.Point(136, 14);
            this.lblTitleP2.Name = "lblTitleP2";
            this.lblTitleP2.Size = new System.Drawing.Size(240, 49);
            this.lblTitleP2.TabIndex = 1;
            this.lblTitleP2.Text = "MicroNations";
            // 
            // lblUEFATitle
            // 
            this.lblUEFATitle.AutoSize = true;
            this.lblUEFATitle.Font = new System.Drawing.Font("Corbel", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUEFATitle.ForeColor = System.Drawing.Color.White;
            this.lblUEFATitle.Location = new System.Drawing.Point(12, 14);
            this.lblUEFATitle.Name = "lblUEFATitle";
            this.lblUEFATitle.Size = new System.Drawing.Size(118, 49);
            this.lblUEFATitle.TabIndex = 0;
            this.lblUEFATitle.Text = "UEFA";
            // 
            // lstWindow
            // 
            this.lstWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstWindow.Font = new System.Drawing.Font("Noto Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstWindow.HideSelection = false;
            this.lstWindow.Location = new System.Drawing.Point(0, 75);
            this.lstWindow.Name = "lstWindow";
            this.lstWindow.Size = new System.Drawing.Size(934, 636);
            this.lstWindow.TabIndex = 2;
            this.lstWindow.UseCompatibleStateImageBehavior = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 711);
            this.Controls.Add(this.lstWindow);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "UEFA MicroNations";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitleP2;
        private System.Windows.Forms.Label lblUEFATitle;
        private System.Windows.Forms.ListView lstWindow;
    }
}

