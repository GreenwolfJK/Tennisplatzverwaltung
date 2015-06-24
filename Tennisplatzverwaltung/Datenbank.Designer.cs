namespace Tennisplatzverwaltung
{
    partial class Datenbank
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
            this.cbTables = new System.Windows.Forms.ComboBox();
            this.lblTabelle = new System.Windows.Forms.Label();
            this.btnShowPersDat = new System.Windows.Forms.Button();
            this.lblDBConnected = new System.Windows.Forms.Label();
            this.pbConnected = new System.Windows.Forms.PictureBox();
            this.btnBuchung = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_details = new System.Windows.Forms.Button();
            this.lblFilter = new System.Windows.Forms.Label();
            this.tbFilter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbConnected)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTables
            // 
            this.cbTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTables.FormattingEnabled = true;
            this.cbTables.Items.AddRange(new object[] {
            "adressdaten",
            "buchungen",
            "finanzdaten",
            "personendaten",
            "platzdaten"});
            this.cbTables.Location = new System.Drawing.Point(12, 78);
            this.cbTables.Name = "cbTables";
            this.cbTables.Size = new System.Drawing.Size(121, 26);
            this.cbTables.TabIndex = 0;
            this.cbTables.Visible = false;
            this.cbTables.SelectedIndexChanged += new System.EventHandler(this.cbTables_SelectedIndexChanged);
            // 
            // lblTabelle
            // 
            this.lblTabelle.AutoSize = true;
            this.lblTabelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblTabelle.Location = new System.Drawing.Point(9, 57);
            this.lblTabelle.Name = "lblTabelle";
            this.lblTabelle.Size = new System.Drawing.Size(109, 18);
            this.lblTabelle.TabIndex = 1;
            this.lblTabelle.Text = "Tabelle wählen:";
            this.lblTabelle.Visible = false;
            // 
            // btnShowPersDat
            // 
            this.btnShowPersDat.Enabled = false;
            this.btnShowPersDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnShowPersDat.Location = new System.Drawing.Point(239, 187);
            this.btnShowPersDat.Name = "btnShowPersDat";
            this.btnShowPersDat.Size = new System.Drawing.Size(26, 32);
            this.btnShowPersDat.TabIndex = 7;
            this.btnShowPersDat.Text = "<";
            this.btnShowPersDat.UseVisualStyleBackColor = true;
            this.btnShowPersDat.Click += new System.EventHandler(this.btnShowPersDat_Click);
            // 
            // lblDBConnected
            // 
            this.lblDBConnected.AutoSize = true;
            this.lblDBConnected.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblDBConnected.Location = new System.Drawing.Point(173, 57);
            this.lblDBConnected.Name = "lblDBConnected";
            this.lblDBConnected.Size = new System.Drawing.Size(77, 18);
            this.lblDBConnected.TabIndex = 4;
            this.lblDBConnected.Text = "connected";
            // 
            // pbConnected
            // 
            this.pbConnected.BackColor = System.Drawing.SystemColors.Control;
            this.pbConnected.InitialImage = null;
            this.pbConnected.Location = new System.Drawing.Point(176, 78);
            this.pbConnected.Name = "pbConnected";
            this.pbConnected.Size = new System.Drawing.Size(35, 33);
            this.pbConnected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbConnected.TabIndex = 9;
            this.pbConnected.TabStop = false;
            // 
            // btnBuchung
            // 
            this.btnBuchung.AutoSize = true;
            this.btnBuchung.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuchung.Location = new System.Drawing.Point(12, 191);
            this.btnBuchung.Name = "btnBuchung";
            this.btnBuchung.Size = new System.Drawing.Size(115, 28);
            this.btnBuchung.TabIndex = 10;
            this.btnBuchung.Text = "Neue Buchung";
            this.btnBuchung.UseVisualStyleBackColor = true;
            this.btnBuchung.Click += new System.EventHandler(this.btnBuchung_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(39, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tennisplatzverwaltung";
            // 
            // btn_details
            // 
            this.btn_details.AutoSize = true;
            this.btn_details.Enabled = false;
            this.btn_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_details.Location = new System.Drawing.Point(13, 157);
            this.btn_details.Name = "btn_details";
            this.btn_details.Size = new System.Drawing.Size(114, 28);
            this.btn_details.TabIndex = 12;
            this.btn_details.Text = "Details";
            this.btn_details.UseVisualStyleBackColor = true;
            this.btn_details.Visible = false;
            this.btn_details.Click += new System.EventHandler(this.btn_details_Click);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(12, 111);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(32, 13);
            this.lblFilter.TabIndex = 13;
            this.lblFilter.Text = "Filter:";
            this.lblFilter.Visible = false;
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(13, 128);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(100, 20);
            this.tbFilter.TabIndex = 14;
            this.tbFilter.Visible = false;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            // 
            // Datenbank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 228);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.btn_details);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuchung);
            this.Controls.Add(this.pbConnected);
            this.Controls.Add(this.btnShowPersDat);
            this.Controls.Add(this.lblDBConnected);
            this.Controls.Add(this.lblTabelle);
            this.Controls.Add(this.cbTables);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Datenbank";
            this.Text = "Datenbank";
            this.LocationChanged += new System.EventHandler(this.Datenbank_LocationChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pbConnected)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTables;
        private System.Windows.Forms.Label lblTabelle;
        private System.Windows.Forms.Button btnShowPersDat;
        private System.Windows.Forms.Label lblDBConnected;
        private System.Windows.Forms.PictureBox pbConnected;
        private System.Windows.Forms.Button btnBuchung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_details;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox tbFilter;
    }
}