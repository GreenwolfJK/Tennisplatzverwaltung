using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Tennisplatzverwaltung
{
    public partial class Datenbank : Form
    {
        //Connection Objekt
        DBConnect db = new DBConnect();

        private DBData dbData = new DBData();

        //Enthält Daten des aktuell ausgewählten Tables
        DataTable tblDBData = new DataTable();
        MySqlDataAdapter da = new MySqlDataAdapter();

        AdressdatenMenue admenue = null;

        //Speichervariable für cbTables
        int oldSelection = -1;

        public Datenbank()
        {
            InitializeComponent();

            //Zuweisen der Logik des btnSave_Click Events zum SelectionChanged Event des DGV
            dbData.Datgrid.SelectionChanged += btnSave_Click;

            //Verbindung zur Datenbank aufbauen
            if (connectDB())
            {
                //Falls erfolgreich, ändere Oberfläche entsprechend in positive Rückmeldung
                lblDBConnected.Text = "connected";
                lblDBConnected.ForeColor = Color.Green;
                pbConnected.Image = Image.FromFile("Haken.png");
            }
            else
            {
                //Falls nicht erfolgreich, ändere Oberfläche in negative Rückmeldung
                lblDBConnected.Text = "disconnected";
                lblDBConnected.ForeColor = Color.Red;
                pbConnected.Image = Image.FromFile("Kreuz.png");
            }
        }

        //Verbinden zur Datenbank
        private bool connectDB()
        {
            //Zuweisen des Rückgabewerts, ob Verbindung erfolgreich
            bool dbopen = db.openDatabase();
            //Falls Verbindung erfolgreich, schalte weitere Benutzeroberflächenelemente frei
            if (dbopen)
            {
                lblTabelle.Visible = true;
                cbTables.Visible = true;
            }
            return dbopen;
        }

        //Wird bei SelectionChanged im DGV aufgerufen
        private void btnSave_Click(object sender, EventArgs e)
        {
            db.writeIntoDatabase(tblDBData, cbTables.SelectedItem.ToString());
        }

        //Button mit Logik zum anzeigen/ausblenden des DGV
        private void btnShowPersDat_Click(object sender, EventArgs e)
        {
            //Falls DGV bereits befüllt
            if (dbData.Datgrid.DataSource != null)
            {
                //Zeige DGV an
                if (dbData.Visible == false)
                {
                    dbData.Visible = true;
                    btnShowPersDat.Text = "<";
                }
                //Blende DGV aus
                else
                {
                    dbData.Visible = false;
                    btnShowPersDat.Text = ">";
                }
            }
        }

        //Event zum Aktualisieren der Daten im DGV
        private void cbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Falls gültiger Index
                if (cbTables.SelectedIndex != -1)
                {
                    //Befülle DataTable mit entsprechender SQL Syntax
                    tblDBData = db.fillTable("SELECT * FROM " + cbTables.SelectedItem.ToString());
                    //Befülle DGV mit DataTable Daten
                    dbData.fillDGV(tblDBData);


                    //dbData.Datgrid.Rows[dbData.Datgrid.CurrentRow.Index].Cells[0].Value = Convert.ToInt32(dbData.Datgrid.Rows[dbData.Datgrid.CurrentRow.Index - 1].Cells[0].Value.ToString()) + 1;
                    //Falls in Tabelle Buchungen, sperre Spalte mit IDs
                    //if (dbData.Datgrid.Columns[0].Name == "id")
                    //{
                    //    dbData.Datgrid.Columns[0].ReadOnly = true;
                    //}

                    //Zeige Form mit DGV an
                    dbData.Visible = true;
                    //Setze richtige Position der Form ("Andocken" an Datenbank Form)
                    dbData.SetDesktopLocation(this.Location.X + this.Width, this.Location.Y);

                    //Cachen des SelectedIndex, Anzeigen des Buttons zum Ein-/Aufklappen der Form
                    oldSelection = cbTables.SelectedIndex;
                    btnShowPersDat.Enabled = true;
                }
            }
            //Fehler beim Aktualisieren -> Fehlermeldung + Zurücksetzen des Index auf Cache
            catch (Exception ex)
            {
                MessageBox.Show("Error has occured! " + ex.Message);
                cbTables.SelectedIndex = oldSelection;
            }
            //Falls aktuell ausgewählter Table "adressdaten" entspricht, zeige btn_details an
            if (cbTables.SelectedItem.ToString().Equals("adressdaten"))
            {
                btn_details.Enabled = true;
                btn_details.Visible = true;
                tbFilter.Visible = false;
                lblFilter.Visible = false;

            }
            //Falls aktuell ausgewählter Table "personendaten" entspricht, zeige Filter an
            else if (cbTables.SelectedItem.ToString().Equals("personendaten"))
            {
                btn_details.Enabled = false;
                btn_details.Visible = false;
                tbFilter.Visible = true;
                lblFilter.Visible = true;
            }
            //Ausblenden der Benutzersteuerelemente
            else
            {
                btn_details.Enabled = false;
                btn_details.Visible = false;
                tbFilter.Visible = false;
                lblFilter.Visible = false;
            }
        }

        private void btnBuchung_Click(object sender, EventArgs e)
        {
            new Buchung(db).ShowDialog();
        }

        //Event zum Andocken der DGV Form und der Details Anzeige an Hauptfenster
        private void Datenbank_LocationChanged(object sender, EventArgs e)
        {
            dbData.SetDesktopLocation(this.Location.X + this.Width, this.Location.Y);
            dbData.TopMost = true;
            dbData.TopMost = false;

            if (admenue != null)
            {
                admenue.SetDesktopLocation(this.Location.X + this.Width, this.Location.Y);
                admenue.TopMost = true;
                admenue.TopMost = false;
            }
        }

        // Logik zur Anzeige der Menüfenster für Adressdaten mit Übergabe der person_id
        private void btn_details_Click(object sender, EventArgs e)
        {
            // Konstrukt stellt sicher, dass das Fenster nicht mehrfach geöffnet wird
            if (admenue != null)
            {
                if (!admenue.Visible)
                {
                    admenue = null;
                    btn_details_Click(this, null);
                }
            }
            else
            {
                // Wenn er einen ausgewählten Satz kriegt, übergibt er den Parameter person_id, ansonsten ohne Übergabe
                try
                {
                    DataGridViewSelectedCellCollection cells = dbData.Datgrid.SelectedCells;
                    String id = cells[cells.Count - 1].OwningRow.Cells[0].Value.ToString().Trim();
                    admenue = new AdressdatenMenue(db, id);
                    admenue.Show();
                }
                catch (Exception)
                {
                    admenue = new AdressdatenMenue(db);
                    admenue.Show();
                }
                if (dbData.Visible == true)
                {
                    btnShowPersDat_Click(this, null);
                }
                Datenbank_LocationChanged(this, null);
            }
        }

        // Funktion für den Filter, der mit der Enter-Taste getriggert wird
        private void tbFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // SQL-Abfrage auf Vorname, Nachname, Telefonnummer, Geburtsdatum, PLZ, Strasse und Ort ist möglich
                // Hierfür wird der Inhalt der Textbox "Filter" als Vergleichswert für die Abfrage genutzt
                tblDBData = db.fillTable("SELECT * FROM " + cbTables.SelectedItem.ToString() +
                                     " LEFT JOIN `adressdaten` ON " + cbTables.SelectedItem.ToString() + ".`person_id`=`adressdaten`.`person_id`" +
                                     " WHERE " + cbTables.SelectedItem.ToString() + ".`vorname` LIKE '%" + tbFilter.Text + "%' " +
                                     " OR " + cbTables.SelectedItem.ToString() + ".`nachname` LIKE '%" + tbFilter.Text + "%' " +
                                     " OR " + cbTables.SelectedItem.ToString() + ".`telefonnr` LIKE '%" + tbFilter.Text + "%' " +
                                     " OR " + cbTables.SelectedItem.ToString() + ".`geburtstag` LIKE '%" + tbFilter.Text + "%' " +
                                     " OR `adressdaten`.`plz` LIKE '%" + tbFilter.Text + "%' " +
                                     " OR `adressdaten`.`strasse` LIKE '%" + tbFilter.Text + "%' " +
                                     " OR `adressdaten`.`ort` LIKE '%" + tbFilter.Text + "%' ");
                dbData.fillDGV(tblDBData);
                dbData.Visible = true;
            }
        }
    }
}
