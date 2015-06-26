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
    public partial class Buchung : Form
    {
        DBConnect dbBuchen = new DBConnect();

        public Buchung(DBConnect db)
        {
            dbBuchen = db;
            InitializeComponent();
            
        }

        private void btnPrüfen_Click(object sender, EventArgs e)
        {
            // ... Code einfügen ...
            // Prüfen ob Platz bereits belegt ist
            // ... Code einfügen ...
            Buchungscheck bc = new Buchungscheck();
            //MessageBox mb = new MessageBox();

            if (bc.checkBuchung())
            {
                MessageBox.Show("Passt");
            }
            else
            {
                MessageBox.Show("Passt nicht");
            }
        }

        private void btnBuchen_Click(object sender, EventArgs e)
        {
            int personId = dbBuchen.getPersonId(tbVorname.Text, tbNachname.Text);
            MessageBox.Show(personId.ToString());
            if (personId == 0)
            {
                MessageBox.Show("Kein Kunde gefunden");
            }
        }

        private void tbPersonId_TextChanged(object sender, EventArgs e)
        {
            if(tbPersonId.Text != "")
            {
                tbVorname.Enabled = false;
                tbNachname.Enabled = false;
            }
            else
            {
                tbVorname.Enabled = true;
                tbNachname.Enabled = true;
            }
        }

        private void tbNames_TextChanged(object sender, EventArgs e)
        {
            if (tbVorname.Text != "" || tbNachname.Text != "")
            {
                tbPersonId.Enabled = false;
            }
            else
            {
                tbPersonId.Enabled = true;
            }
        }
    }
}
