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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void btnBuchung_Click(object sender, EventArgs e)
        {
            
            
                (sender as Button).Enabled = false;
                (sender as Button).Visible = false;
                new Buchung().Show();
                      
        }
    }
}
