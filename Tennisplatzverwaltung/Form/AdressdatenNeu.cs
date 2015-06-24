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
using System.Collections;

namespace Tennisplatzverwaltung
{
    public partial class AdressdatenNeu : Form
    {
        DBConnect db = null;
        ArrayList arr_personendaten = null;
        KeyValuePair<int, String> kv;

        public AdressdatenNeu(DBConnect db)
        {
            InitializeComponent();
            this.db = db;

            load_personendaten();
            refresh_lsb();
            
        }

        private void load_personendaten() 
        {
            MySqlDataReader reader = null;
            String sql = null;
            arr_personendaten = new ArrayList();

            sql = "select p.* " +
                  "  from personendaten p " +
                  "  	  left join adressdaten a " +
                  "  	    on p.person_id = a.person_id " +
                  " where a.person_id is null ";
            try
            {
                reader = db.executeQuery(sql);
                while (reader.Read())
                {
                    int key = reader.GetInt16("person_id");
                    String value = reader.GetInt16("person_id") + " | " + reader.GetString("vorname") + " " +
                        reader.GetString("nachname") + ", " + reader.GetDateTime("geburtstag").ToShortDateString();
                    kv = new KeyValuePair<int, String>(key, value);
                    arr_personendaten.Add(kv);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Laden der Personendaten! " + ex.Message);
            }
        }

        private void refresh_lsb()
        {
            lsb_neuanlage.Items.Clear();

            foreach (KeyValuePair<int,String> kv in arr_personendaten)
            {
                lsb_neuanlage.Items.Add(kv.Value);
            }
        }

        private void btn_neuanlage_abbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_neuanlage_ok_Click(object sender, EventArgs e)
        {
            if (lsb_neuanlage.SelectedIndex >= 0)
            {
                AdressdatenEinzel a = new AdressdatenEinzel(db, ((KeyValuePair<int, String>)arr_personendaten[lsb_neuanlage.SelectedIndex]).Key);
                a.ShowDialog();
                this.Close();
            }
        }
    }
}
