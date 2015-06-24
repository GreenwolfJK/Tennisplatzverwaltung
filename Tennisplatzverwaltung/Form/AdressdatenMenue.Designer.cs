namespace Tennisplatzverwaltung
{
    partial class AdressdatenMenue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lsb_adressdaten = new System.Windows.Forms.ListBox();
            this.btn_anzeigen = new System.Windows.Forms.Button();
            this.btn_aendern = new System.Windows.Forms.Button();
            this.btn_loeschen = new System.Windows.Forms.Button();
            this.btn_neu = new System.Windows.Forms.Button();
            this.btn_schliessen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsb_adressdaten
            // 
            this.lsb_adressdaten.FormattingEnabled = true;
            this.lsb_adressdaten.Location = new System.Drawing.Point(126, 12);
            this.lsb_adressdaten.Name = "lsb_adressdaten";
            this.lsb_adressdaten.Size = new System.Drawing.Size(380, 290);
            this.lsb_adressdaten.TabIndex = 0;
            // 
            // btn_anzeigen
            // 
            this.btn_anzeigen.Location = new System.Drawing.Point(13, 13);
            this.btn_anzeigen.Name = "btn_anzeigen";
            this.btn_anzeigen.Size = new System.Drawing.Size(107, 30);
            this.btn_anzeigen.TabIndex = 1;
            this.btn_anzeigen.Text = "Anzeigen";
            this.btn_anzeigen.UseVisualStyleBackColor = true;
            this.btn_anzeigen.Click += new System.EventHandler(this.btn_anzeigen_Click);
            // 
            // btn_aendern
            // 
            this.btn_aendern.Location = new System.Drawing.Point(13, 49);
            this.btn_aendern.Name = "btn_aendern";
            this.btn_aendern.Size = new System.Drawing.Size(107, 30);
            this.btn_aendern.TabIndex = 2;
            this.btn_aendern.Text = "Ändern";
            this.btn_aendern.UseVisualStyleBackColor = true;
            this.btn_aendern.Click += new System.EventHandler(this.btn_aendern_Click);
            // 
            // btn_loeschen
            // 
            this.btn_loeschen.Location = new System.Drawing.Point(13, 85);
            this.btn_loeschen.Name = "btn_loeschen";
            this.btn_loeschen.Size = new System.Drawing.Size(107, 30);
            this.btn_loeschen.TabIndex = 3;
            this.btn_loeschen.Text = "Löschen";
            this.btn_loeschen.UseVisualStyleBackColor = true;
            this.btn_loeschen.Click += new System.EventHandler(this.btn_loeschen_Click);
            // 
            // btn_neu
            // 
            this.btn_neu.Location = new System.Drawing.Point(13, 121);
            this.btn_neu.Name = "btn_neu";
            this.btn_neu.Size = new System.Drawing.Size(107, 30);
            this.btn_neu.TabIndex = 4;
            this.btn_neu.Text = "Neuanlage";
            this.btn_neu.UseVisualStyleBackColor = true;
            this.btn_neu.Click += new System.EventHandler(this.btn_neu_Click);
            // 
            // btn_schliessen
            // 
            this.btn_schliessen.Location = new System.Drawing.Point(13, 272);
            this.btn_schliessen.Name = "btn_schliessen";
            this.btn_schliessen.Size = new System.Drawing.Size(107, 30);
            this.btn_schliessen.TabIndex = 5;
            this.btn_schliessen.Text = "Schließen";
            this.btn_schliessen.UseVisualStyleBackColor = true;
            this.btn_schliessen.Click += new System.EventHandler(this.btn_schliessen_Click);
            // 
            // AdressdatenMenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 314);
            this.Controls.Add(this.btn_schliessen);
            this.Controls.Add(this.btn_neu);
            this.Controls.Add(this.btn_loeschen);
            this.Controls.Add(this.btn_aendern);
            this.Controls.Add(this.btn_anzeigen);
            this.Controls.Add(this.lsb_adressdaten);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "AdressdatenMenue";
            this.Text = "Adressdaten";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsb_adressdaten;
        private System.Windows.Forms.Button btn_anzeigen;
        private System.Windows.Forms.Button btn_aendern;
        private System.Windows.Forms.Button btn_loeschen;
        private System.Windows.Forms.Button btn_neu;
        private System.Windows.Forms.Button btn_schliessen;
    }
}