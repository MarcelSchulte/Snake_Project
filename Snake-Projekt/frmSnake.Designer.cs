namespace Snake_Projekt
{
    partial class frmGame
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbSpielFeld = new System.Windows.Forms.PictureBox();
            this.timZeit = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbSpielFeld)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSpielFeld
            // 
            this.pbSpielFeld.Location = new System.Drawing.Point(0, 0);
            this.pbSpielFeld.Name = "pbSpielFeld";
            this.pbSpielFeld.Size = new System.Drawing.Size(524, 362);
            this.pbSpielFeld.TabIndex = 0;
            this.pbSpielFeld.TabStop = false;
            this.pbSpielFeld.Click += new System.EventHandler(this.pbSpielFeld_Click);
            // 
            // timZeit
            // 
            this.timZeit.Tick += new System.EventHandler(this.timZeit_Tick);
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 361);
            this.Controls.Add(this.pbSpielFeld);
            this.Name = "frmGame";
            this.Text = "Snake";
            this.Load += new System.EventHandler(this.frmGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSpielFeld)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSpielFeld;
        private System.Windows.Forms.Timer timZeit;
    }
}

