using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tennisplatzverwaltung
{
    public partial class DBData : Form
    {
        //getter für DGV
        public DataGridView Datgrid
        {
            get { return dgvDBData; }
        }

        public DBData()
        {
            InitializeComponent();
        }

        //Befüllen des DGV mit übergebenem Table
        public void fillDGV(DataTable tbl)
        {
            //Setzen der DataSource des DGV auf übergebenen Table
            dgvDBData.DataSource = tbl;
        }
    }
}
