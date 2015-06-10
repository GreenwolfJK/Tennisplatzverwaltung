namespace Tennisplatzverwaltung_Brockwitz
{
    partial class MainWindow
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
            this.lblWillkommen = new System.Windows.Forms.Label();
            this.lblVorhaben = new System.Windows.Forms.Label();
            this.btnBuchung = new System.Windows.Forms.Button();
            this.btnDatenbank = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWillkommen
            // 
            this.lblWillkommen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWillkommen.Location = new System.Drawing.Point(26, 9);
            this.lblWillkommen.Name = "lblWillkommen";
            this.lblWillkommen.Size = new System.Drawing.Size(332, 18);
            this.lblWillkommen.TabIndex = 0;
            this.lblWillkommen.Text = "Herzlich Willkommen zur Tennisplatzverwaltung!";
            // 
            // lblVorhaben
            // 
            this.lblVorhaben.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVorhaben.Location = new System.Drawing.Point(26, 75);
            this.lblVorhaben.Name = "lblVorhaben";
            this.lblVorhaben.Size = new System.Drawing.Size(332, 18);
            this.lblVorhaben.TabIndex = 1;
            this.lblVorhaben.Text = "Was möchten Sie tun?";
            this.lblVorhaben.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBuchung
            // 
            this.btnBuchung.AutoSize = true;
            this.btnBuchung.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuchung.Location = new System.Drawing.Point(12, 117);
            this.btnBuchung.Name = "btnBuchung";
            this.btnBuchung.Size = new System.Drawing.Size(80, 28);
            this.btnBuchung.TabIndex = 2;
            this.btnBuchung.Text = "Buchung";
            this.btnBuchung.UseVisualStyleBackColor = true;
            this.btnBuchung.Click += new System.EventHandler(this.btnBuchung_Click);
            // 
            // btnDatenbank
            // 
            this.btnDatenbank.AutoSize = true;
            this.btnDatenbank.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatenbank.Location = new System.Drawing.Point(283, 117);
            this.btnDatenbank.Name = "btnDatenbank";
            this.btnDatenbank.Size = new System.Drawing.Size(89, 28);
            this.btnDatenbank.TabIndex = 3;
            this.btnDatenbank.Text = "Datenbank";
            this.btnDatenbank.UseVisualStyleBackColor = true;
            this.btnDatenbank.Click += new System.EventHandler(this.btnDatenbank_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 162);
            this.Controls.Add(this.btnDatenbank);
            this.Controls.Add(this.btnBuchung);
            this.Controls.Add(this.lblVorhaben);
            this.Controls.Add(this.lblWillkommen);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWillkommen;
        private System.Windows.Forms.Label lblVorhaben;
        private System.Windows.Forms.Button btnBuchung;
        private System.Windows.Forms.Button btnDatenbank;


    }
}

