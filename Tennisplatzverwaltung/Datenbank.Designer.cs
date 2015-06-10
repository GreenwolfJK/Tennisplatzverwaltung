namespace Tennisplatzverwaltung_Brockwitz
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
            this.btnBeenden = new System.Windows.Forms.Button();
            this.btnDBConnect = new System.Windows.Forms.Button();
            this.lblDBConnect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbTables
            // 
            this.cbTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTables.FormattingEnabled = true;
            this.cbTables.Items.AddRange(new object[] {
            "Adressdaten",
            "Buchungen",
            "Finanzdaten",
            "Personen",
            "Plätze"});
            this.cbTables.Location = new System.Drawing.Point(16, 105);
            this.cbTables.Name = "cbTables";
            this.cbTables.Size = new System.Drawing.Size(121, 26);
            this.cbTables.TabIndex = 0;
            this.cbTables.Visible = false;
            // 
            // lblTabelle
            // 
            this.lblTabelle.AutoSize = true;
            this.lblTabelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabelle.Location = new System.Drawing.Point(13, 84);
            this.lblTabelle.Name = "lblTabelle";
            this.lblTabelle.Size = new System.Drawing.Size(109, 18);
            this.lblTabelle.TabIndex = 1;
            this.lblTabelle.Text = "Tabelle wählen:";
            this.lblTabelle.Visible = false;
            // 
            // btnBeenden
            // 
            this.btnBeenden.AutoSize = true;
            this.btnBeenden.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeenden.Location = new System.Drawing.Point(196, 222);
            this.btnBeenden.Name = "btnBeenden";
            this.btnBeenden.Size = new System.Drawing.Size(76, 28);
            this.btnBeenden.TabIndex = 2;
            this.btnBeenden.Text = "Beenden";
            this.btnBeenden.UseVisualStyleBackColor = true;
            this.btnBeenden.Click += new System.EventHandler(this.btnBeenden_Click);
            // 
            // btnDBConnect
            // 
            this.btnDBConnect.AutoSize = true;
            this.btnDBConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDBConnect.Location = new System.Drawing.Point(16, 36);
            this.btnDBConnect.Name = "btnDBConnect";
            this.btnDBConnect.Size = new System.Drawing.Size(75, 28);
            this.btnDBConnect.TabIndex = 3;
            this.btnDBConnect.Text = "Connect";
            this.btnDBConnect.UseVisualStyleBackColor = true;
            this.btnDBConnect.Click += new System.EventHandler(this.btnDBConnect_Click);
            // 
            // lblDBConnect
            // 
            this.lblDBConnect.AutoSize = true;
            this.lblDBConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDBConnect.Location = new System.Drawing.Point(16, 13);
            this.lblDBConnect.Name = "lblDBConnect";
            this.lblDBConnect.Size = new System.Drawing.Size(176, 18);
            this.lblDBConnect.TabIndex = 4;
            this.lblDBConnect.Text = "Zur Datenbank verbinden:";
            // 
            // Datenbank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblDBConnect);
            this.Controls.Add(this.btnDBConnect);
            this.Controls.Add(this.btnBeenden);
            this.Controls.Add(this.lblTabelle);
            this.Controls.Add(this.cbTables);
            this.Name = "Datenbank";
            this.Text = "Datenbank";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTables;
        private System.Windows.Forms.Label lblTabelle;
        private System.Windows.Forms.Button btnBeenden;
        private System.Windows.Forms.Button btnDBConnect;
        private System.Windows.Forms.Label lblDBConnect;
    }
}