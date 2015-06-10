using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tennisplatzverwaltung_Brockwitz
{
    public partial class Datenbank : Form
    {
        public Datenbank()
        {
            InitializeComponent();
        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDBConnect_Click(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            bool dbopen = db.openDatabase();
            MessageBox.Show(dbopen.ToString());

            lblTabelle.Visible = true;
            cbTables.Visible = true;
        }
    }
}
