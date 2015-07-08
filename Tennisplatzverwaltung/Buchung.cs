using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

            //aktuelles Datum initialisieren
            dateTimePicker1.Value = DateTime.Now;

            //  Change  Date-Format in Constructor
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
        }

        private void btnPrüfen_Click(object sender, EventArgs e)
        {
            // Prüfen ob Platz bereits belegt ist
            Buchungscheck bc;

            if (cBPlatz.Text != "" && tbStartzeitHour.Text != "" && tbStartzeitMin.Text != "" && tbEndzeitHour.Text != "" && tbEndzeitMin.Text != "")
            {
                if (tbPersonId.Text != "" || tbVorname.Text != "" && tbNachname.Text != "")
                {
                    bc = new Buchungscheck(cBPlatz.SelectedIndex + 1,
                                                             dateTimePicker1.Value,
                                                             new Time(Convert.ToInt32(tbStartzeitHour.Text), Convert.ToInt32(tbStartzeitMin.Text)),
                                                             new Time(Convert.ToInt32(tbEndzeitHour.Text), Convert.ToInt32(tbEndzeitMin.Text)),
                                                             tbVorname.Text + " " + tbNachname.Text);
                    if (bc.checkBuchung())
                    {
                        btnBuchen.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Bitte füllen Sie alle Felder aus!");
                }
            }
            else
            {
                MessageBox.Show("Bitte füllen Sie alle Felder aus!");
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
                    DateTime startDateTime = buildTime(dateTimePicker1.Text.ToString(), tbStartzeitHour.Text, tbStartzeitMin.Text);
                    DateTime endDateTime = buildTime(dateTimePicker1.Text.ToString(), tbEndzeitHour.Text, tbEndzeitMin.Text);
                    
                    string platz = cBPlatz.Text;
                    string placeId = Regex.Replace(platz, "Platz ", "");
                    dbBuchen.buchungAnlegen(personId, placeId, startDateTime, endDateTime);
            }
        }

        private DateTime buildTime(string date, string hour, string min)
        {
            DateTime dateTime;
            string dateTimeString = date + " " + hour + ":" + min + ":00";

            dateTime = new DateTime();
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

        private void tbStartzeitHour_Enter(object sender, EventArgs e)
        {
            tbStartzeitHour.Text = "";
            bearbeitenModus();
        }

        private void tbStartzeitMin_Enter(object sender, EventArgs e)
        {
            tbStartzeitMin.Text = "";
            bearbeitenModus();
        }

        private void tbEndzeitHour_Enter(object sender, EventArgs e)
        {
            tbEndzeitHour.Text = "";
            bearbeitenModus();
        }

        private void tbEndzeitMin_Enter(object sender, EventArgs e)
        {
            tbEndzeitMin.Text = "";
            bearbeitenModus();
        }

        private void tbStartzeitHour_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool numbercheck = allowOnlyNumbers(sender, e);
        }

        private void tbStartzeitMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool numbercheck = allowOnlyNumbers(sender, e);
        }

        private void tbEndzeitHour_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool numbercheck = allowOnlyNumbers(sender, e);
        }

        private void tbEndzeitMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool numbercheck = allowOnlyNumbers(sender, e);
        }

        private void tbPersonId_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool numbercheck = allowOnlyNumbers(sender,e);
        }

        private void cBPlatz_Enter(object sender, EventArgs e)
        {
            bearbeitenModus();
        }

        private void dateTimePicker1_Enter(object sender, EventArgs e)
        {
            bearbeitenModus();
        }

        private void tbPersonId_Enter(object sender, EventArgs e)
        {
            bearbeitenModus();
        }

        private void tbVorname_Enter(object sender, EventArgs e)
        {
            bearbeitenModus();
        }

        private void tbNachname_Enter(object sender, EventArgs e)
        {
            bearbeitenModus();
        }

        private void bearbeitenModus()
        {
            if(btnBuchen.Enabled ==  true)
            {
                btnBuchen.Enabled = false;
            }
        }

        private void tbStartzeitHour_Validating(object sender, CancelEventArgs e)
        {
            if (tbStartzeitHour.Text == "")
            {
                MessageBox.Show("Bitte Startzeitminuten ausfüllen");
            }
            else if(tbStartzeitHour.TextLength != 2)
            {
                tbStartzeitHour.Text = "";
                MessageBox.Show("Format HH muss eingehalten werden.");
            }
            else
            {
                string tbHour = tbStartzeitHour.Text;
                int hour = Convert.ToInt32(tbHour);
                int min;
                if (tbStartzeitMin.Text == "MM")
                {
                    min = 00;
                }
                else
                {
                    string tbMin = tbStartzeitHour.Text;
                    min = Convert.ToInt32(tbMin);
                }

                bool isValid = checkValidHour(hour, min);
                if (isValid == false)
                {
                    MessageBox.Show("Falsches Startzeitformat");
                    tbStartzeitHour.Text = "";
                }
            }
        }

        private void tbStartzeitMin_Validating(object sender, CancelEventArgs e)
        {
            if (tbStartzeitMin.Text == "")
            {
                MessageBox.Show("Bitte Startzeitminuten ausfüllen");
            }
            else if(tbStartzeitMin.TextLength != 2)
            {
                tbStartzeitMin.Text = "";
                MessageBox.Show("Format MM muss eingehalten werden.");
            }
            else
            {
                string tbMin = tbStartzeitMin.Text;
                int min = Convert.ToInt32(tbMin);
                int hour;

                if (tbStartzeitHour.Text == "HH")
                {
                    hour = 00;
                }
                else
                {
                    string tbHour = tbStartzeitMin.Text;
                    hour = Convert.ToInt32(tbHour);
                }

                bool isValid = checkValidMin(hour, min);

                if (isValid == false)
                {
                    MessageBox.Show("Falsches Startzeitformat");
                    tbStartzeitMin.Text = "";
                }
            }
        }

        private void tbEndzeitHour_Validating(object sender, CancelEventArgs e)
        {
            if (tbEndzeitHour.Text == "")
            {
                MessageBox.Show("Bitte Endzeitstunden ausfüllen");
            }
            else if(tbEndzeitHour.TextLength != 2)
            {
                tbEndzeitHour.Text = "";
                MessageBox.Show("Format HH muss eingehalten werden.");
            }
            else
            {
                int hour; int min;
                string tbHour = tbEndzeitHour.Text;

                hour = Convert.ToInt32(tbHour);
                if (tbEndzeitMin.Text == "MM")
                {
                    min = 00;
                }
                else
                {
                    string tbMin = tbEndzeitMin.Text;
                    min = Convert.ToInt32(tbMin);
                }

                bool isValid = checkValidHour(hour, min);

                if (isValid == false)
                {
                    MessageBox.Show("Falsches Endzeitformat");
                    tbEndzeitHour.Text = "";
                }
            }
        }

        private void tbEndzeitMin_Validating(object sender, CancelEventArgs e)
        {
            if (tbEndzeitMin.Text == "")
            {
                MessageBox.Show("Bitte Endzeitminuten ausfüllen");
            }
            else if(tbEndzeitMin.TextLength != 2)
            {
                tbEndzeitMin.Text = "";
                MessageBox.Show("Format MM muss eingehalten werden.");
            }

            else
            {
                int hour; int min;
                string tbMin = tbEndzeitMin.Text;
                min = Convert.ToInt32(tbMin); 

                if (tbEndzeitHour.Text == "HH")
                {
                    hour = 00;
                }
                else
                {
                    string tbHour = tbEndzeitMin.Text;
                    hour = Convert.ToInt32(tbHour);
                }

                bool isValid = checkValidMin(hour, min);

                if (isValid == false)
                {
                    MessageBox.Show("Falsches Endzeitformat");
                    tbEndzeitMin.Text = "";
                }
            }
        }

        private bool checkValidHour(int hour, int min)
        {
            if (hour <= 23 || hour == 24 && min == 0)
            {
                bool isValid = true;
                return isValid;
            }
            else
            {
                bool isValid = false;
                return isValid;
            }
        }


        private bool checkValidMin(int hour, int min)
        {
            if (min <= 59 || min == 60 && hour == 24)
            {
                bool isValid = true;
                return isValid;
            }
            else
            {
                bool isValid = false;
                return isValid;
            }
        }

        private bool allowOnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                return e.Handled = true;
            }
            else
            {
                return e.Handled = false;
            }
        }
    }
}
