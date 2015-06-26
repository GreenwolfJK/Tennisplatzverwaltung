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
            this.btnReset = new System.Windows.Forms.Button();
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
            this.cBPlatz.Location = new System.Drawing.Point(33, 42);
            this.cBPlatz.Margin = new System.Windows.Forms.Padding(4);
            this.cBPlatz.Name = "cBPlatz";
            this.cBPlatz.Size = new System.Drawing.Size(160, 30);
            this.cBPlatz.TabIndex = 0;
            // 
            // lblPlatzWahl
            // 
            this.lblPlatzWahl.AutoSize = true;
            this.lblPlatzWahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlatzWahl.Location = new System.Drawing.Point(29, 16);
            this.lblPlatzWahl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlatzWahl.Name = "lblPlatzWahl";
            this.lblPlatzWahl.Size = new System.Drawing.Size(204, 24);
            this.lblPlatzWahl.TabIndex = 1;
            this.lblPlatzWahl.Text = "Wählen Sie Ihren Platz:";
            // 
            // lblVon
            // 
            this.lblVon.AutoSize = true;
            this.lblVon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVon.Location = new System.Drawing.Point(29, 113);
            this.lblVon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVon.Name = "lblVon";
            this.lblVon.Size = new System.Drawing.Size(46, 24);
            this.lblVon.TabIndex = 2;
            this.lblVon.Text = "von:";
            // 
            // lblBis
            // 
            this.lblBis.AutoSize = true;
            this.lblBis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBis.Location = new System.Drawing.Point(215, 113);
            this.lblBis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBis.Name = "lblBis";
            this.lblBis.Size = new System.Drawing.Size(39, 24);
            this.lblBis.TabIndex = 3;
            this.lblBis.Text = "bis:";
            // 
            // tbStartzeitHour
            // 
            this.tbStartzeitHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStartzeitHour.Location = new System.Drawing.Point(79, 111);
            this.tbStartzeitHour.Margin = new System.Windows.Forms.Padding(4);
            this.tbStartzeitHour.Name = "tbStartzeitHour";
            this.tbStartzeitHour.Size = new System.Drawing.Size(43, 28);
            this.tbStartzeitHour.TabIndex = 4;
            this.tbStartzeitHour.Text = "HH";
            this.tbStartzeitHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbEndzeitHour
            // 
            this.tbEndzeitHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEndzeitHour.Location = new System.Drawing.Point(256, 111);
            this.tbEndzeitHour.Margin = new System.Windows.Forms.Padding(4);
            this.tbEndzeitHour.Name = "tbEndzeitHour";
            this.tbEndzeitHour.Size = new System.Drawing.Size(43, 28);
            this.tbEndzeitHour.TabIndex = 5;
            this.tbEndzeitHour.Text = "HH";
            this.tbEndzeitHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblVorname
            // 
            this.lblVorname.AutoSize = true;
            this.lblVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVorname.Location = new System.Drawing.Point(29, 194);
            this.lblVorname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVorname.Name = "lblVorname";
            this.lblVorname.Size = new System.Drawing.Size(93, 24);
            this.lblVorname.TabIndex = 6;
            this.lblVorname.Text = "Vorname:";
            // 
            // lblNachname
            // 
            this.lblNachname.AutoSize = true;
            this.lblNachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNachname.Location = new System.Drawing.Point(29, 234);
            this.lblNachname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNachname.Name = "lblNachname";
            this.lblNachname.Size = new System.Drawing.Size(108, 24);
            this.lblNachname.TabIndex = 7;
            this.lblNachname.Text = "Nachname:";
            // 
            // tbVorname
            // 
            this.tbVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVorname.Location = new System.Drawing.Point(137, 194);
            this.tbVorname.Margin = new System.Windows.Forms.Padding(4);
            this.tbVorname.Multiline = true;
            this.tbVorname.Name = "tbVorname";
            this.tbVorname.Size = new System.Drawing.Size(132, 24);
            this.tbVorname.TabIndex = 8;
            this.tbVorname.TextChanged += new System.EventHandler(this.tbNames_TextChanged);
            // 
            // tbNachname
            // 
            this.tbNachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNachname.Location = new System.Drawing.Point(137, 234);
            this.tbNachname.Margin = new System.Windows.Forms.Padding(4);
            this.tbNachname.Multiline = true;
            this.tbNachname.Name = "tbNachname";
            this.tbNachname.Size = new System.Drawing.Size(132, 24);
            this.tbNachname.TabIndex = 9;
            this.tbNachname.TextChanged += new System.EventHandler(this.tbNames_TextChanged);
            // 
            // btnPrüfen
            // 
            this.btnPrüfen.AutoSize = true;
            this.btnPrüfen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrüfen.Location = new System.Drawing.Point(16, 270);
            this.btnPrüfen.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrüfen.Name = "btnPrüfen";
            this.btnPrüfen.Size = new System.Drawing.Size(161, 34);
            this.btnPrüfen.TabIndex = 10;
            this.btnPrüfen.Text = "Buchung prüfen";
            this.btnPrüfen.UseVisualStyleBackColor = true;
            this.btnPrüfen.Click += new System.EventHandler(this.btnPrüfen_Click);
            // 
            // btnBuchen
            // 
            this.btnBuchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuchen.Location = new System.Drawing.Point(335, 270);
            this.btnBuchen.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuchen.Name = "btnBuchen";
            this.btnBuchen.Size = new System.Drawing.Size(161, 34);
            this.btnBuchen.TabIndex = 11;
            this.btnBuchen.Text = "Buchen";
            this.btnBuchen.UseVisualStyleBackColor = true;
            this.btnBuchen.Click += new System.EventHandler(this.btnBuchen_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(33, 79);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(355, 22);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.Value = new System.DateTime(2015, 7, 5, 0, 0, 0, 0);
            // 
            // lblStartPlaceholder
            // 
            this.lblStartPlaceholder.AutoSize = true;
            this.lblStartPlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblStartPlaceholder.Location = new System.Drawing.Point(129, 113);
            this.lblStartPlaceholder.Name = "lblStartPlaceholder";
            this.lblStartPlaceholder.Size = new System.Drawing.Size(15, 24);
            this.lblStartPlaceholder.TabIndex = 14;
            this.lblStartPlaceholder.Text = ":";
            // 
            // tbStartzeitMin
            // 
            this.tbStartzeitMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStartzeitMin.Location = new System.Drawing.Point(151, 111);
            this.tbStartzeitMin.Margin = new System.Windows.Forms.Padding(4);
            this.tbStartzeitMin.Name = "tbStartzeitMin";
            this.tbStartzeitMin.Size = new System.Drawing.Size(43, 28);
            this.tbStartzeitMin.TabIndex = 15;
            this.tbStartzeitMin.Text = "MM";
            this.tbStartzeitMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbEndzeitMin
            // 
            this.tbEndzeitMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEndzeitMin.Location = new System.Drawing.Point(328, 111);
            this.tbEndzeitMin.Margin = new System.Windows.Forms.Padding(4);
            this.tbEndzeitMin.Name = "tbEndzeitMin";
            this.tbEndzeitMin.Size = new System.Drawing.Size(43, 28);
            this.tbEndzeitMin.TabIndex = 16;
            this.tbEndzeitMin.Text = "MM";
            this.tbEndzeitMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEndPlaceholder
            // 
            this.lblEndPlaceholder.AutoSize = true;
            this.lblEndPlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblEndPlaceholder.Location = new System.Drawing.Point(306, 113);
            this.lblEndPlaceholder.Name = "lblEndPlaceholder";
            this.lblEndPlaceholder.Size = new System.Drawing.Size(15, 24);
            this.lblEndPlaceholder.TabIndex = 17;
            this.lblEndPlaceholder.Text = ":";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(335, 228);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(161, 34);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Bearbeiten";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // tbPersonId
            // 
            this.tbPersonId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPersonId.Location = new System.Drawing.Point(137, 154);
            this.tbPersonId.Margin = new System.Windows.Forms.Padding(4);
            this.tbPersonId.Multiline = true;
            this.tbPersonId.Name = "tbPersonId";
            this.tbPersonId.Size = new System.Drawing.Size(132, 24);
            this.tbPersonId.TabIndex = 19;
            this.tbPersonId.TextChanged += new System.EventHandler(this.tbPersonId_TextChanged);
            // 
            // lblPersonId
            // 
            this.lblPersonId.AutoSize = true;
            this.lblPersonId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonId.Location = new System.Drawing.Point(29, 154);
            this.lblPersonId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPersonId.Name = "lblPersonId";
            this.lblPersonId.Size = new System.Drawing.Size(96, 24);
            this.lblPersonId.TabIndex = 20;
            this.lblPersonId.Text = "Person-Id:";
            // 
            // Buchung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 322);
            this.Controls.Add(this.lblPersonId);
            this.Controls.Add(this.tbPersonId);
            this.Controls.Add(this.btnReset);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox tbPersonId;
        private System.Windows.Forms.Label lblPersonId;
    }
}