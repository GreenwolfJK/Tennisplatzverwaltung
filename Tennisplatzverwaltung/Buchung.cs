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
            //  Change  Date-Format in Constructor
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
        }

        private void btnPrüfen_Click(object sender, EventArgs e)
        {
            // ... Code einfügen ...
            // Prüfen ob Platz bereits belegt ist
            // ... Code einfügen ...
            Buchungscheck bc = new Buchungscheck(cBPlatz.SelectedIndex + 1,
                                                     dateTimePicker1.Value,
                                                     new Time(Convert.ToInt32(tbStartzeitHour.Text), Convert.ToInt32(tbStartzeitMin.Text)),
                                                     new Time(Convert.ToInt32(tbEndzeitHour.Text), Convert.ToInt32(tbEndzeitMin.Text)),
                                                     tbVorname.Text + " " + tbNachname.Text);
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
            // Helper for unknown Person-Ids
            int personId = 0;

            if (tbPersonId.Text == "")
            {
                // Get PersonId, cause we book with PersonId
                personId = dbBuchen.getPersonId(tbVorname.Text, tbNachname.Text);
                MessageBox.Show(personId.ToString());
            }
            else
            {
                personId = dbBuchen.checkPersonId(Convert.ToInt32(tbPersonId.Text));
                //int personId = Convert.ToInt32(tbPersonId.Text);
            }

            if (personId == 0)
            {
                MessageBox.Show("Kein Kunde gefunden.\nBitte Daten korrigieren.");
            }
            else
            {
                //DateTimeBuilder Method
                DateTime startDateTime = buildTime(dateTimePicker1.Text.ToString(),tbStartzeitHour.Text, tbStartzeitMin.Text);
                DateTime endDateTimee = buildTime(dateTimePicker1.Text.ToString(), tbEndzeitHour.Text, tbEndzeitMin.Text);
                string platz = cBPlatz.Text;
                //dbBuchen.buchungAnlegen(personId, platz, startDateTime, endDateTime)
            }
        }

        private DateTime buildTime(string date, string hour, string min)
        {
            DateTime dateTime;
            string dateTimeString = date + " " + hour + ":" + min + ":00";

            dateTime = new DateTime();
            MessageBox.Show(dateTimeString);
            dateTime = DateTime.ParseExact(dateTimeString, "dd-MM-yyyy HH:mm:ss",null);
        
            return dateTime;
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
