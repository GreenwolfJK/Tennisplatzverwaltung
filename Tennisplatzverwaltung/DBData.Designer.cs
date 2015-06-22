namespace Tennisplatzverwaltung
{
    partial class DBData
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
            this.dgvDBData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDBData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDBData
            // 
            this.dgvDBData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDBData.Location = new System.Drawing.Point(12, 12);
            this.dgvDBData.Name = "dgvDBData";
            this.dgvDBData.Size = new System.Drawing.Size(568, 263);
            this.dgvDBData.TabIndex = 0;
            // 
            // DBData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 287);
            this.ControlBox = false;
            this.Controls.Add(this.dgvDBData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DBData";
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.dgvDBData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDBData;
    }
}