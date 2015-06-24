namespace Tennisplatzverwaltung
{
    partial class AdressdatenNeu
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
            this.lsb_neuanlage = new System.Windows.Forms.ListBox();
            this.btn_neuanlage_ok = new System.Windows.Forms.Button();
            this.btn_neuanlage_abbrechen = new System.Windows.Forms.Button();
            this.lbl_neuanlage_meldung = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsb_neuanlage
            // 
            this.lsb_neuanlage.FormattingEnabled = true;
            this.lsb_neuanlage.Location = new System.Drawing.Point(13, 13);
            this.lsb_neuanlage.Name = "lsb_neuanlage";
            this.lsb_neuanlage.Size = new System.Drawing.Size(259, 186);
            this.lsb_neuanlage.TabIndex = 0;
            // 
            // btn_neuanlage_ok
            // 
            this.btn_neuanlage_ok.Location = new System.Drawing.Point(13, 226);
            this.btn_neuanlage_ok.Name = "btn_neuanlage_ok";
            this.btn_neuanlage_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_neuanlage_ok.TabIndex = 1;
            this.btn_neuanlage_ok.Text = "OK";
            this.btn_neuanlage_ok.UseVisualStyleBackColor = true;
            this.btn_neuanlage_ok.Click += new System.EventHandler(this.btn_neuanlage_ok_Click);
            // 
            // btn_neuanlage_abbrechen
            // 
            this.btn_neuanlage_abbrechen.Location = new System.Drawing.Point(197, 226);
            this.btn_neuanlage_abbrechen.Name = "btn_neuanlage_abbrechen";
            this.btn_neuanlage_abbrechen.Size = new System.Drawing.Size(75, 23);
            this.btn_neuanlage_abbrechen.TabIndex = 2;
            this.btn_neuanlage_abbrechen.Text = "Abbrechen";
            this.btn_neuanlage_abbrechen.UseVisualStyleBackColor = true;
            this.btn_neuanlage_abbrechen.Click += new System.EventHandler(this.btn_neuanlage_abbrechen_Click);
            // 
            // lbl_neuanlage_meldung
            // 
            this.lbl_neuanlage_meldung.AutoSize = true;
            this.lbl_neuanlage_meldung.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_neuanlage_meldung.Location = new System.Drawing.Point(13, 207);
            this.lbl_neuanlage_meldung.Name = "lbl_neuanlage_meldung";
            this.lbl_neuanlage_meldung.Size = new System.Drawing.Size(174, 13);
            this.lbl_neuanlage_meldung.TabIndex = 3;
            this.lbl_neuanlage_meldung.Text = "Bitte wählen Sie eine Person!";
            // 
            // AdressdatenNeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbl_neuanlage_meldung);
            this.Controls.Add(this.btn_neuanlage_abbrechen);
            this.Controls.Add(this.btn_neuanlage_ok);
            this.Controls.Add(this.lsb_neuanlage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdressdatenNeu";
            this.Text = "Adressdaten Neuanlage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsb_neuanlage;
        private System.Windows.Forms.Button btn_neuanlage_ok;
        private System.Windows.Forms.Button btn_neuanlage_abbrechen;
        private System.Windows.Forms.Label lbl_neuanlage_meldung;
    }
}