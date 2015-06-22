namespace Tennisplatzverwaltung
{
    partial class Buchung
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblPlatzWahl = new System.Windows.Forms.Label();
            this.lblVon = new System.Windows.Forms.Label();
            this.lblBis = new System.Windows.Forms.Label();
            this.tbStartzeit = new System.Windows.Forms.TextBox();
            this.tbEndzeit = new System.Windows.Forms.TextBox();
            this.lblVorname = new System.Windows.Forms.Label();
            this.lblNachname = new System.Windows.Forms.Label();
            this.tbVorname = new System.Windows.Forms.TextBox();
            this.tbNachname = new System.Windows.Forms.TextBox();
            this.btnPrüfen = new System.Windows.Forms.Button();
            this.btnBuchen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Platz 1",
            "Platz 2",
            "Platz 3",
            "Platz 4",
            "Platz 5"});
            this.comboBox1.Location = new System.Drawing.Point(25, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 0;
            // 
            // lblPlatzWahl
            // 
            this.lblPlatzWahl.AutoSize = true;
            this.lblPlatzWahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlatzWahl.Location = new System.Drawing.Point(22, 13);
            this.lblPlatzWahl.Name = "lblPlatzWahl";
            this.lblPlatzWahl.Size = new System.Drawing.Size(160, 18);
            this.lblPlatzWahl.TabIndex = 1;
            this.lblPlatzWahl.Text = "Wählen Sie Ihren Platz:";
            // 
            // lblVon
            // 
            this.lblVon.AutoSize = true;
            this.lblVon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVon.Location = new System.Drawing.Point(22, 92);
            this.lblVon.Name = "lblVon";
            this.lblVon.Size = new System.Drawing.Size(36, 18);
            this.lblVon.TabIndex = 2;
            this.lblVon.Text = "von:";
            // 
            // lblBis
            // 
            this.lblBis.AutoSize = true;
            this.lblBis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBis.Location = new System.Drawing.Point(161, 92);
            this.lblBis.Name = "lblBis";
            this.lblBis.Size = new System.Drawing.Size(31, 18);
            this.lblBis.TabIndex = 3;
            this.lblBis.Text = "bis:";
            // 
            // tbStartzeit
            // 
            this.tbStartzeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStartzeit.Location = new System.Drawing.Point(59, 90);
            this.tbStartzeit.Name = "tbStartzeit";
            this.tbStartzeit.Size = new System.Drawing.Size(100, 24);
            this.tbStartzeit.TabIndex = 4;
            // 
            // tbEndzeit
            // 
            this.tbEndzeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEndzeit.Location = new System.Drawing.Point(192, 90);
            this.tbEndzeit.Name = "tbEndzeit";
            this.tbEndzeit.Size = new System.Drawing.Size(100, 24);
            this.tbEndzeit.TabIndex = 5;
            // 
            // lblVorname
            // 
            this.lblVorname.AutoSize = true;
            this.lblVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVorname.Location = new System.Drawing.Point(22, 146);
            this.lblVorname.Name = "lblVorname";
            this.lblVorname.Size = new System.Drawing.Size(72, 18);
            this.lblVorname.TabIndex = 6;
            this.lblVorname.Text = "Vorname:";
            // 
            // lblNachname
            // 
            this.lblNachname.AutoSize = true;
            this.lblNachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNachname.Location = new System.Drawing.Point(22, 174);
            this.lblNachname.Name = "lblNachname";
            this.lblNachname.Size = new System.Drawing.Size(84, 18);
            this.lblNachname.TabIndex = 7;
            this.lblNachname.Text = "Nachname:";
            // 
            // tbVorname
            // 
            this.tbVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVorname.Location = new System.Drawing.Point(92, 146);
            this.tbVorname.Multiline = true;
            this.tbVorname.Name = "tbVorname";
            this.tbVorname.Size = new System.Drawing.Size(100, 20);
            this.tbVorname.TabIndex = 8;
            // 
            // tbNachname
            // 
            this.tbNachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNachname.Location = new System.Drawing.Point(103, 174);
            this.tbNachname.Multiline = true;
            this.tbNachname.Name = "tbNachname";
            this.tbNachname.Size = new System.Drawing.Size(100, 20);
            this.tbNachname.TabIndex = 9;
            // 
            // btnPrüfen
            // 
            this.btnPrüfen.AutoSize = true;
            this.btnPrüfen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrüfen.Location = new System.Drawing.Point(12, 219);
            this.btnPrüfen.Name = "btnPrüfen";
            this.btnPrüfen.Size = new System.Drawing.Size(121, 28);
            this.btnPrüfen.TabIndex = 10;
            this.btnPrüfen.Text = "Buchung prüfen";
            this.btnPrüfen.UseVisualStyleBackColor = true;
            this.btnPrüfen.Click += new System.EventHandler(this.btnPrüfen_Click);
            // 
            // btnBuchen
            // 
            this.btnBuchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuchen.Location = new System.Drawing.Point(251, 219);
            this.btnBuchen.Name = "btnBuchen";
            this.btnBuchen.Size = new System.Drawing.Size(121, 28);
            this.btnBuchen.TabIndex = 11;
            this.btnBuchen.Text = "Buchen";
            this.btnBuchen.UseVisualStyleBackColor = true;
            this.btnBuchen.Click += new System.EventHandler(this.btnBuchen_Click);
            // 
            // Buchung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.btnBuchen);
            this.Controls.Add(this.btnPrüfen);
            this.Controls.Add(this.tbNachname);
            this.Controls.Add(this.tbVorname);
            this.Controls.Add(this.lblNachname);
            this.Controls.Add(this.lblVorname);
            this.Controls.Add(this.tbEndzeit);
            this.Controls.Add(this.tbStartzeit);
            this.Controls.Add(this.lblBis);
            this.Controls.Add(this.lblVon);
            this.Controls.Add(this.lblPlatzWahl);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Buchung";
            this.Text = "Buchung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblPlatzWahl;
        private System.Windows.Forms.Label lblVon;
        private System.Windows.Forms.Label lblBis;
        private System.Windows.Forms.TextBox tbStartzeit;
        private System.Windows.Forms.TextBox tbEndzeit;
        private System.Windows.Forms.Label lblVorname;
        private System.Windows.Forms.Label lblNachname;
        private System.Windows.Forms.TextBox tbVorname;
        private System.Windows.Forms.TextBox tbNachname;
        private System.Windows.Forms.Button btnPrüfen;
        private System.Windows.Forms.Button btnBuchen;
    }
}