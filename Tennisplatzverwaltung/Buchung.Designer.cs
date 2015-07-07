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
            this.cBPlatz = new System.Windows.Forms.ComboBox();
            this.lblPlatzWahl = new System.Windows.Forms.Label();
            this.lblVon = new System.Windows.Forms.Label();
            this.lblBis = new System.Windows.Forms.Label();
            this.tbStartzeitHour = new System.Windows.Forms.TextBox();
            this.tbEndzeitHour = new System.Windows.Forms.TextBox();
            this.lblVorname = new System.Windows.Forms.Label();
            this.lblNachname = new System.Windows.Forms.Label();
            this.tbVorname = new System.Windows.Forms.TextBox();
            this.tbNachname = new System.Windows.Forms.TextBox();
            this.btnPrüfen = new System.Windows.Forms.Button();
            this.btnBuchen = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblStartPlaceholder = new System.Windows.Forms.Label();
            this.tbStartzeitMin = new System.Windows.Forms.TextBox();
            this.tbEndzeitMin = new System.Windows.Forms.TextBox();
            this.lblEndPlaceholder = new System.Windows.Forms.Label();
            this.tbPersonId = new System.Windows.Forms.TextBox();
            this.lblPersonId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cBPlatz
            // 
            this.cBPlatz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBPlatz.FormattingEnabled = true;
            this.cBPlatz.Items.AddRange(new object[] {
            "Platz 1",
            "Platz 2",
            "Platz 3",
            "Platz 4",
            "Platz 5"});
            this.cBPlatz.Location = new System.Drawing.Point(25, 34);
            this.cBPlatz.Name = "cBPlatz";
            this.cBPlatz.Size = new System.Drawing.Size(121, 26);
            this.cBPlatz.TabIndex = 0;
            this.cBPlatz.Enter += new System.EventHandler(this.cBPlatz_Enter);
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
            // tbStartzeitHour
            // 
            this.tbStartzeitHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStartzeitHour.Location = new System.Drawing.Point(59, 90);
            this.tbStartzeitHour.MaxLength = 2;
            this.tbStartzeitHour.Name = "tbStartzeitHour";
            this.tbStartzeitHour.Size = new System.Drawing.Size(33, 24);
            this.tbStartzeitHour.TabIndex = 2;
            this.tbStartzeitHour.Text = "HH";
            this.tbStartzeitHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbStartzeitHour.Enter += new System.EventHandler(this.tbStartzeitHour_Enter);
            this.tbStartzeitHour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStartzeitHour_KeyPress);
            // 
            // tbEndzeitHour
            // 
            this.tbEndzeitHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEndzeitHour.Location = new System.Drawing.Point(192, 90);
            this.tbEndzeitHour.MaxLength = 2;
            this.tbEndzeitHour.Name = "tbEndzeitHour";
            this.tbEndzeitHour.Size = new System.Drawing.Size(33, 24);
            this.tbEndzeitHour.TabIndex = 4;
            this.tbEndzeitHour.Text = "HH";
            this.tbEndzeitHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbEndzeitHour.Enter += new System.EventHandler(this.tbEndzeitHour_Enter);
            this.tbEndzeitHour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEndzeitHour_KeyPress);
            // 
            // lblVorname
            // 
            this.lblVorname.AutoSize = true;
            this.lblVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVorname.Location = new System.Drawing.Point(22, 158);
            this.lblVorname.Name = "lblVorname";
            this.lblVorname.Size = new System.Drawing.Size(72, 18);
            this.lblVorname.TabIndex = 6;
            this.lblVorname.Text = "Vorname:";
            // 
            // lblNachname
            // 
            this.lblNachname.AutoSize = true;
            this.lblNachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNachname.Location = new System.Drawing.Point(22, 190);
            this.lblNachname.Name = "lblNachname";
            this.lblNachname.Size = new System.Drawing.Size(84, 18);
            this.lblNachname.TabIndex = 7;
            this.lblNachname.Text = "Nachname:";
            // 
            // tbVorname
            // 
            this.tbVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVorname.Location = new System.Drawing.Point(103, 158);
            this.tbVorname.Multiline = true;
            this.tbVorname.Name = "tbVorname";
            this.tbVorname.Size = new System.Drawing.Size(100, 20);
            this.tbVorname.TabIndex = 7;
            this.tbVorname.TextChanged += new System.EventHandler(this.tbNames_TextChanged);
            this.tbVorname.Enter += new System.EventHandler(this.tbVorname_Enter);
            // 
            // tbNachname
            // 
            this.tbNachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNachname.Location = new System.Drawing.Point(103, 190);
            this.tbNachname.Multiline = true;
            this.tbNachname.Name = "tbNachname";
            this.tbNachname.Size = new System.Drawing.Size(100, 20);
            this.tbNachname.TabIndex = 8;
            this.tbNachname.TextChanged += new System.EventHandler(this.tbNames_TextChanged);
            this.tbNachname.Enter += new System.EventHandler(this.tbNachname_Enter);
            // 
            // btnPrüfen
            // 
            this.btnPrüfen.AutoSize = true;
            this.btnPrüfen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrüfen.Location = new System.Drawing.Point(12, 219);
            this.btnPrüfen.Name = "btnPrüfen";
            this.btnPrüfen.Size = new System.Drawing.Size(121, 28);
            this.btnPrüfen.TabIndex = 9;
            this.btnPrüfen.Text = "Buchung prüfen";
            this.btnPrüfen.UseVisualStyleBackColor = true;
            this.btnPrüfen.Click += new System.EventHandler(this.btnPrüfen_Click);
            // 
            // btnBuchen
            // 
            this.btnBuchen.Enabled = false;
            this.btnBuchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuchen.Location = new System.Drawing.Point(251, 219);
            this.btnBuchen.Name = "btnBuchen";
            this.btnBuchen.Size = new System.Drawing.Size(121, 28);
            this.btnBuchen.TabIndex = 11;
            this.btnBuchen.Text = "Buchen";
            this.btnBuchen.UseVisualStyleBackColor = true;
            this.btnBuchen.Click += new System.EventHandler(this.btnBuchen_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(25, 64);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(267, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Enter += new System.EventHandler(this.dateTimePicker1_Enter);
            // 
            // lblStartPlaceholder
            // 
            this.lblStartPlaceholder.AutoSize = true;
            this.lblStartPlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblStartPlaceholder.Location = new System.Drawing.Point(97, 92);
            this.lblStartPlaceholder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartPlaceholder.Name = "lblStartPlaceholder";
            this.lblStartPlaceholder.Size = new System.Drawing.Size(12, 18);
            this.lblStartPlaceholder.TabIndex = 14;
            this.lblStartPlaceholder.Text = ":";
            // 
            // tbStartzeitMin
            // 
            this.tbStartzeitMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStartzeitMin.Location = new System.Drawing.Point(113, 90);
            this.tbStartzeitMin.MaxLength = 2;
            this.tbStartzeitMin.Name = "tbStartzeitMin";
            this.tbStartzeitMin.Size = new System.Drawing.Size(33, 24);
            this.tbStartzeitMin.TabIndex = 3;
            this.tbStartzeitMin.Text = "MM";
            this.tbStartzeitMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbStartzeitMin.Enter += new System.EventHandler(this.tbStartzeitMin_Enter);
            this.tbStartzeitMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStartzeitMin_KeyPress);
            // 
            // tbEndzeitMin
            // 
            this.tbEndzeitMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEndzeitMin.Location = new System.Drawing.Point(246, 90);
            this.tbEndzeitMin.MaxLength = 2;
            this.tbEndzeitMin.Name = "tbEndzeitMin";
            this.tbEndzeitMin.Size = new System.Drawing.Size(33, 24);
            this.tbEndzeitMin.TabIndex = 5;
            this.tbEndzeitMin.Text = "MM";
            this.tbEndzeitMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbEndzeitMin.Enter += new System.EventHandler(this.tbEndzeitMin_Enter);
            this.tbEndzeitMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEndzeitMin_KeyPress);
            // 
            // lblEndPlaceholder
            // 
            this.lblEndPlaceholder.AutoSize = true;
            this.lblEndPlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblEndPlaceholder.Location = new System.Drawing.Point(230, 92);
            this.lblEndPlaceholder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndPlaceholder.Name = "lblEndPlaceholder";
            this.lblEndPlaceholder.Size = new System.Drawing.Size(12, 18);
            this.lblEndPlaceholder.TabIndex = 17;
            this.lblEndPlaceholder.Text = ":";
            // 
            // tbPersonId
            // 
            this.tbPersonId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPersonId.Location = new System.Drawing.Point(103, 125);
            this.tbPersonId.Multiline = true;
            this.tbPersonId.Name = "tbPersonId";
            this.tbPersonId.Size = new System.Drawing.Size(100, 20);
            this.tbPersonId.TabIndex = 6;
            this.tbPersonId.TextChanged += new System.EventHandler(this.tbPersonId_TextChanged);
            this.tbPersonId.Enter += new System.EventHandler(this.tbPersonId_Enter);
            this.tbPersonId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPersonId_KeyPress);
            // 
            // lblPersonId
            // 
            this.lblPersonId.AutoSize = true;
            this.lblPersonId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonId.Location = new System.Drawing.Point(22, 125);
            this.lblPersonId.Name = "lblPersonId";
            this.lblPersonId.Size = new System.Drawing.Size(76, 18);
            this.lblPersonId.TabIndex = 20;
            this.lblPersonId.Text = "Person-Id:";
            // 
            // Buchung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.lblPersonId);
            this.Controls.Add(this.tbPersonId);
            this.Controls.Add(this.lblEndPlaceholder);
            this.Controls.Add(this.tbEndzeitMin);
            this.Controls.Add(this.tbStartzeitMin);
            this.Controls.Add(this.lblStartPlaceholder);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnBuchen);
            this.Controls.Add(this.btnPrüfen);
            this.Controls.Add(this.tbNachname);
            this.Controls.Add(this.tbVorname);
            this.Controls.Add(this.lblNachname);
            this.Controls.Add(this.lblVorname);
            this.Controls.Add(this.tbEndzeitHour);
            this.Controls.Add(this.tbStartzeitHour);
            this.Controls.Add(this.lblBis);
            this.Controls.Add(this.lblVon);
            this.Controls.Add(this.lblPlatzWahl);
            this.Controls.Add(this.cBPlatz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Buchung";
            this.Text = "Buchung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBPlatz;
        private System.Windows.Forms.Label lblPlatzWahl;
        private System.Windows.Forms.Label lblVon;
        private System.Windows.Forms.Label lblBis;
        private System.Windows.Forms.TextBox tbStartzeitHour;
        private System.Windows.Forms.TextBox tbEndzeitHour;
        private System.Windows.Forms.Label lblVorname;
        private System.Windows.Forms.Label lblNachname;
        private System.Windows.Forms.TextBox tbVorname;
        private System.Windows.Forms.TextBox tbNachname;
        private System.Windows.Forms.Button btnPrüfen;
        private System.Windows.Forms.Button btnBuchen;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblStartPlaceholder;
        private System.Windows.Forms.TextBox tbStartzeitMin;
        private System.Windows.Forms.TextBox tbEndzeitMin;
        private System.Windows.Forms.Label lblEndPlaceholder;
        private System.Windows.Forms.TextBox tbPersonId;
        private System.Windows.Forms.Label lblPersonId;
    }
}