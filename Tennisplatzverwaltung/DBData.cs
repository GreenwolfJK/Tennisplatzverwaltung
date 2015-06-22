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
        public DataGridView Datgrid
        {
            get { return dgvDBData; }
        }

        public DBData()
        {
            InitializeComponent();
        }

        public void fillDGV(DataTable tbl)
        {
            dgvDBData.DataSource = tbl;
        }
    }
}
