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
        DBConnect db = new DBConnect();

        private DBData dbData = new DBData();
        DataTable tblDBData = new DataTable();
        MySqlDataAdapter da = new MySqlDataAdapter();
        AdressdatenMenue admenue = null;

        int oldSelection = -1;

        public Datenbank()
        {
            InitializeComponent();

            dbData.Datgrid.SelectionChanged += btnSave_Click;

            if (connectDB())
            {
                lblDBConnected.Text = "connected";
                lblDBConnected.ForeColor = Color.Green;
                pbConnected.Image = Image.FromFile("Haken.png");
            }
            else
            {
                lblDBConnected.Text = "disconnected";
                lblDBConnected.ForeColor = Color.Red;
                pbConnected.Image = Image.FromFile("Kreuz.png");
            }
        }

        private bool connectDB()
        {
            bool dbopen = db.openDatabase();

            lblTabelle.Visible = true;
            cbTables.Visible = true;

            return dbopen;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            db.writeIntoDatabase(tblDBData, cbTables.SelectedItem.ToString());
        }

        private void btnShowPersDat_Click(object sender, EventArgs e)
        {
            if (dbData.Datgrid.DataSource != null)
            {
                if (dbData.Visible == false)
                {
                    dbData.Visible = true;
                    btnShowPersDat.Text = "<";
                }
                else
                {
                    dbData.Visible = false;
                    btnShowPersDat.Text = ">";
                }
            }
        }

        private void cbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (cbTables.SelectedIndex != -1)
                {
                    tblDBData = db.fillTable("SELECT * FROM " + cbTables.SelectedItem.ToString());
                    dbData.fillDGV(tblDBData);
                    dbData.Visible = true;
                    dbData.SetDesktopLocation(this.Location.X + this.Width, this.Location.Y);

                    oldSelection = cbTables.SelectedIndex;
                    btnShowPersDat.Enabled = true;
                }

                if (cbTables.SelectedItem.ToString().Equals("adressdaten"))
                {
                    btn_details.Enabled = true;
                    btn_details.Visible = true; 
                    tbFilter.Visible = false;
                    lblFilter.Visible = false;

                }
                else if (cbTables.SelectedItem.ToString().Equals("personendaten"))
                {
                    btn_details.Enabled = false;
                    btn_details.Visible = false;
                    tbFilter.Visible = true;
                    lblFilter.Visible = true;
                }
                else
                {
                    btn_details.Enabled = false;
                    btn_details.Visible = false;
                    tbFilter.Visible = false;
                    lblFilter.Visible = false;
                }

                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error has occured! " + ex.Message);
                cbTables.SelectedIndex = oldSelection;
            }
        }

        private void btnBuchung_Click(object sender, EventArgs e)
        {
            new Buchung(db).ShowDialog();
        }

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

        private void btn_details_Click(object sender, EventArgs e)
        {
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

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            tblDBData = db.fillTable("SELECT * FROM " + cbTables.SelectedItem.ToString() +
                                     " LEFT JOIN `adressdaten` ON " + cbTables.SelectedItem.ToString() + ".`person_id`=`adressdaten`.`person_id`" +
                                     " WHERE " + cbTables.SelectedItem.ToString() + ".`vorname` LIKE '%" + tbFilter.Text + "%' " +
                                     " OR " + cbTables.SelectedItem.ToString() + ".`nachname` LIKE '%" + tbFilter.Text + "%' " +
                                     " OR `adressdaten`.`strasse` LIKE '%" + tbFilter.Text + "%' " +
                                     " OR `adressdaten`.`ort` LIKE '%" + tbFilter.Text + "%' ");
            dbData.fillDGV(tblDBData);
            dbData.Visible = true;
            dbData.SetDesktopLocation(this.Location.X + this.Width, this.Location.Y);

            oldSelection = cbTables.SelectedIndex;
        }
    }
}
