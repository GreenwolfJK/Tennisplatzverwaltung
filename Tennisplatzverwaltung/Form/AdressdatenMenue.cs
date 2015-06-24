using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class AdressdatenMenue : Form
    {
        ArrayList arr_adressdaten = null;
        DBConnect db = null;
        int selIdx = -1;

        public AdressdatenMenue(DBConnect db)
        {
            this.db = db;
            InitializeComponent();
            load_adressdaten();
            refresh_lsb();
        }

        public AdressdatenMenue(DBConnect db, String selId)
        {
            this.db = db;
            InitializeComponent();
            load_adressdaten();
            refresh_lsb();

            for (int i = 0; i < arr_adressdaten.Count; i++)
            {
                if (selId.Equals(((Adressdatensatz)arr_adressdaten[i]).Id.Trim()))
                {
                    selIdx = i;
                    lsb_adressdaten.SelectedIndex = selIdx;
                }
            }
        }

        private void load_adressdaten()
        {
            MySqlDataReader reader = null;
            String sql = null;
            arr_adressdaten = new ArrayList();
            Adressdatensatz a = null;

            sql = "select p.person_id, " +
                  "	      p.nachname, " +
                  "	      p.vorname, " +
                  "	      a.strasse, " +
                  "	      a.plz, " +
                  "	      a.ort " +
                  "  from adressdaten a " +
                  "  	inner join personendaten p " +
                  "  		on a.person_id = p.person_id ";
            try
            {
                reader = db.executeQuery(sql);
                while (reader.Read())
                {
                    a = new Adressdatensatz();
                    a.Id = reader.GetString("person_id");
                    a.Vorname = reader.GetString("vorname");
                    a.Nachname = reader.GetString("nachname");
                    a.Strasse = reader.GetString("strasse");
                    a.Plz = reader.GetString("plz");
                    a.Ort = reader.GetString("ort");
                    arr_adressdaten.Add(a);
                }
                reader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Fehler beim Laden der Adressdaten!");
            }
        }

        private void refresh_lsb()
        {
            lsb_adressdaten.Items.Clear();

            foreach (Adressdatensatz a in arr_adressdaten)
            {
                lsb_adressdaten.Items.Add(a.lsb_String());
            }

            if (selIdx != -1)
            {
                lsb_adressdaten.SelectedIndex = selIdx;
            }
        }

        private void btn_schliessen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_anzeigen_Click(object sender, EventArgs e)
        {
            if (lsb_adressdaten.SelectedIndex >= 0)
            {
                AdressdatenEinzel a = new AdressdatenEinzel(db, 1, (Adressdatensatz)arr_adressdaten[lsb_adressdaten.SelectedIndex]);
                a.ShowDialog();
            }
        }

        private void btn_aendern_Click(object sender, EventArgs e)
        {
            if (lsb_adressdaten.SelectedIndex >= 0)
            {
                selIdx = lsb_adressdaten.SelectedIndex;
                AdressdatenEinzel a = new AdressdatenEinzel(db, 2, (Adressdatensatz)arr_adressdaten[lsb_adressdaten.SelectedIndex]);
                a.ShowDialog();
                load_adressdaten();
                refresh_lsb();
            }
        }

        private void btn_loeschen_Click(object sender, EventArgs e)
        {
            if (lsb_adressdaten.SelectedIndex >= 0)
            {
                selIdx = -1;
                AdressdatenEinzel a = new AdressdatenEinzel(db, 3, (Adressdatensatz)arr_adressdaten[lsb_adressdaten.SelectedIndex]);
                a.ShowDialog();
                load_adressdaten();
                refresh_lsb();
            }
        }

        private void btn_neu_Click(object sender, EventArgs e)
        {
            AdressdatenNeu a = new AdressdatenNeu(db);
            a.ShowDialog();
            load_adressdaten();
            refresh_lsb();
        }
    }
}
