namespace Tennisplatzverwaltung
{
    partial class AdressdatenEinzel
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
            this.btn_action = new System.Windows.Forms.Button();
            this.btn_schliessen = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txb_id = new System.Windows.Forms.TextBox();
            this.txb_ort = new System.Windows.Forms.TextBox();
            this.lbl_ort = new System.Windows.Forms.Label();
            this.txb_plz = new System.Windows.Forms.TextBox();
            this.lbl_plz = new System.Windows.Forms.Label();
            this.txb_strasse = new System.Windows.Forms.TextBox();
            this.lbl_strasse = new System.Windows.Forms.Label();
            this.txb_nachname = new System.Windows.Forms.TextBox();
            this.lbl_nachname = new System.Windows.Forms.Label();
            this.txb_vorname = new System.Windows.Forms.TextBox();
            this.lbl_vorname = new System.Windows.Forms.Label();
            this.lbl_meldung = new System.Windows.Forms.Label();
            this.lbl_ueberschrift = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_action
            // 
            this.btn_action.Location = new System.Drawing.Point(15, 140);
            this.btn_action.Name = "btn_action";
            this.btn_action.Size = new System.Drawing.Size(75, 23);
            this.btn_action.TabIndex = 0;
            this.btn_action.Text = "speichern";
            this.btn_action.UseVisualStyleBackColor = true;
            this.btn_action.Click += new System.EventHandler(this.btn_action_Click);
            // 
            // btn_schliessen
            // 
            this.btn_schliessen.Location = new System.Drawing.Point(396, 140);
            this.btn_schliessen.Name = "btn_schliessen";
            this.btn_schliessen.Size = new System.Drawing.Size(75, 23);
            this.btn_schliessen.TabIndex = 1;
            this.btn_schliessen.Text = "schliessen";
            this.btn_schliessen.UseVisualStyleBackColor = true;
            this.btn_schliessen.Click += new System.EventHandler(this.btn_schliessen_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(12, 40);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(85, 13);
            this.lbl_id.TabIndex = 2;
            this.lbl_id.Text = "Mitgliedsnummer";
            // 
            // txb_id
            // 
            this.txb_id.Location = new System.Drawing.Point(103, 37);
            this.txb_id.Name = "txb_id";
            this.txb_id.Size = new System.Drawing.Size(100, 20);
            this.txb_id.TabIndex = 3;
            // 
            // txb_ort
            // 
            this.txb_ort.Location = new System.Drawing.Point(313, 106);
            this.txb_ort.Name = "txb_ort";
            this.txb_ort.Size = new System.Drawing.Size(158, 20);
            this.txb_ort.TabIndex = 5;
            // 
            // lbl_ort
            // 
            this.lbl_ort.AutoSize = true;
            this.lbl_ort.Location = new System.Drawing.Point(222, 109);
            this.lbl_ort.Name = "lbl_ort";
            this.lbl_ort.Size = new System.Drawing.Size(21, 13);
            this.lbl_ort.TabIndex = 4;
            this.lbl_ort.Text = "Ort";
            // 
            // txb_plz
            // 
            this.txb_plz.Location = new System.Drawing.Point(313, 71);
            this.txb_plz.Name = "txb_plz";
            this.txb_plz.Size = new System.Drawing.Size(158, 20);
            this.txb_plz.TabIndex = 7;
            // 
            // lbl_plz
            // 
            this.lbl_plz.AutoSize = true;
            this.lbl_plz.Location = new System.Drawing.Point(222, 74);
            this.lbl_plz.Name = "lbl_plz";
            this.lbl_plz.Size = new System.Drawing.Size(60, 13);
            this.lbl_plz.TabIndex = 6;
            this.lbl_plz.Text = "Postleitzahl";
            // 
            // txb_strasse
            // 
            this.txb_strasse.Location = new System.Drawing.Point(313, 37);
            this.txb_strasse.Name = "txb_strasse";
            this.txb_strasse.Size = new System.Drawing.Size(158, 20);
            this.txb_strasse.TabIndex = 9;
            // 
            // lbl_strasse
            // 
            this.lbl_strasse.AutoSize = true;
            this.lbl_strasse.Location = new System.Drawing.Point(222, 40);
            this.lbl_strasse.Name = "lbl_strasse";
            this.lbl_strasse.Size = new System.Drawing.Size(42, 13);
            this.lbl_strasse.TabIndex = 8;
            this.lbl_strasse.Text = "Strasse";
            // 
            // txb_nachname
            // 
            this.txb_nachname.Location = new System.Drawing.Point(103, 106);
            this.txb_nachname.Name = "txb_nachname";
            this.txb_nachname.Size = new System.Drawing.Size(100, 20);
            this.txb_nachname.TabIndex = 11;
            // 
            // lbl_nachname
            // 
            this.lbl_nachname.AutoSize = true;
            this.lbl_nachname.Location = new System.Drawing.Point(12, 109);
            this.lbl_nachname.Name = "lbl_nachname";
            this.lbl_nachname.Size = new System.Drawing.Size(59, 13);
            this.lbl_nachname.TabIndex = 10;
            this.lbl_nachname.Text = "Nachname";
            // 
            // txb_vorname
            // 
            this.txb_vorname.Location = new System.Drawing.Point(103, 71);
            this.txb_vorname.Name = "txb_vorname";
            this.txb_vorname.Size = new System.Drawing.Size(100, 20);
            this.txb_vorname.TabIndex = 13;
            // 
            // lbl_vorname
            // 
            this.lbl_vorname.AutoSize = true;
            this.lbl_vorname.Location = new System.Drawing.Point(12, 74);
            this.lbl_vorname.Name = "lbl_vorname";
            this.lbl_vorname.Size = new System.Drawing.Size(49, 13);
            this.lbl_vorname.TabIndex = 12;
            this.lbl_vorname.Text = "Vorname";
            // 
            // lbl_meldung
            // 
            this.lbl_meldung.AutoSize = true;
            this.lbl_meldung.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_meldung.Location = new System.Drawing.Point(100, 145);
            this.lbl_meldung.Name = "lbl_meldung";
            this.lbl_meldung.Size = new System.Drawing.Size(0, 13);
            this.lbl_meldung.TabIndex = 14;
            // 
            // lbl_ueberschrift
            // 
            this.lbl_ueberschrift.AutoSize = true;
            this.lbl_ueberschrift.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ueberschrift.Location = new System.Drawing.Point(12, 11);
            this.lbl_ueberschrift.Name = "lbl_ueberschrift";
            this.lbl_ueberschrift.Size = new System.Drawing.Size(0, 13);
            this.lbl_ueberschrift.TabIndex = 15;
            // 
            // AdressdatenEinzel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 181);
            this.Controls.Add(this.lbl_ueberschrift);
            this.Controls.Add(this.lbl_meldung);
            this.Controls.Add(this.txb_vorname);
            this.Controls.Add(this.lbl_vorname);
            this.Controls.Add(this.txb_nachname);
            this.Controls.Add(this.lbl_nachname);
            this.Controls.Add(this.txb_strasse);
            this.Controls.Add(this.lbl_strasse);
            this.Controls.Add(this.txb_plz);
            this.Controls.Add(this.lbl_plz);
            this.Controls.Add(this.txb_ort);
            this.Controls.Add(this.lbl_ort);
            this.Controls.Add(this.txb_id);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.btn_schliessen);
            this.Controls.Add(this.btn_action);
            this.Name = "AdressdatenEinzel";
            this.Text = "AdressdatenEinzel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_action;
        private System.Windows.Forms.Button btn_schliessen;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txb_id;
        private System.Windows.Forms.TextBox txb_ort;
        private System.Windows.Forms.Label lbl_ort;
        private System.Windows.Forms.TextBox txb_plz;
        private System.Windows.Forms.Label lbl_plz;
        private System.Windows.Forms.TextBox txb_strasse;
        private System.Windows.Forms.Label lbl_strasse;
        private System.Windows.Forms.TextBox txb_nachname;
        private System.Windows.Forms.Label lbl_nachname;
        private System.Windows.Forms.TextBox txb_vorname;
        private System.Windows.Forms.Label lbl_vorname;
        private System.Windows.Forms.Label lbl_meldung;
        private System.Windows.Forms.Label lbl_ueberschrift;
    }
}