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
            //{
            //    MessageBox.Show("Synchronisieren erfolgreich!");
            //}
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error has occured! " + ex.Message);
                cbTables.SelectedIndex = oldSelection;
            }
        }

        private void btnBuchung_Click(object sender, EventArgs e)
        {
            new Buchung().ShowDialog();
        }

        private void Datenbank_LocationChanged(object sender, EventArgs e)
        {
            dbData.SetDesktopLocation(this.Location.X + this.Width, this.Location.Y);
            dbData.TopMost = true;
            dbData.TopMost = false;
        }
    }
}
