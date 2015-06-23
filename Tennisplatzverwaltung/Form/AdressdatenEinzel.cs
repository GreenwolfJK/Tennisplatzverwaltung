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
using MySql.Data.MySqlClient;

namespace Tennisplatzverwaltung
{
    public partial class AdressdatenEinzel : Form
    {
        DBConnect db = null;
        int modus = 0; // 0 = Neuanlage, 1 = anzeigen, 2 = ändern, 3 = löschen
        int key;

        //Neuanlage
        public AdressdatenEinzel(DBConnect db, int key)
        {
            this.db = db;
            this.key = key;
            InitializeComponent();

            lbl_ueberschrift.Text = "Adressdaten Neuanlage";
            btn_action.Visible = true;
            btn_action.Text = "anlegen";
            btn_schliessen.Text = "abbrechen";

            try
            {
                String sql = "select person_id, vorname, nachname " +
                             "  from personendaten " +
                             " where person_id = " + key;
                MySqlDataReader reader = db.executeQuery(sql);

                while (reader.Read())
                {
                    txb_id.Text = reader.GetString("person_id");
                    txb_id.ReadOnly = true;
                    txb_vorname.Text = reader.GetString("vorname");
                    txb_vorname.ReadOnly = true;
                    txb_nachname.Text = reader.GetString("nachname");
                    txb_nachname.ReadOnly = true;
                }
                reader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Fehler beim Ändern der Adressdaten!");
            }
        }

        public AdressdatenEinzel(DBConnect db, int modus, Adressdatensatz a)
        {
            this.db = db;
            InitializeComponent();
            this.modus = modus;

            switch (modus)
            {
                case 1:
                    lbl_ueberschrift.Text = "Adressdaten anzeigen";
                    btn_action.Visible = false;
                    txb_id.Text = a.Id;
                    txb_id.ReadOnly = true;
                    txb_vorname.Text = a.Vorname;
                    txb_vorname.ReadOnly = true;
                    txb_nachname.Text = a.Nachname;
                    txb_nachname.ReadOnly = true;
                    txb_strasse.Text = a.Strasse;
                    txb_strasse.ReadOnly = true;
                    txb_plz.Text = a.Plz;
                    txb_plz.ReadOnly = true;
                    txb_ort.Text = a.Ort;
                    txb_ort.ReadOnly = true;
                    break;
                case 2:
                    lbl_ueberschrift.Text = "Adressdaten ändern";
                    lbl_meldung.Text = "Wollen Sie die Adressdaten wirklich ändern?";
                    btn_action.Visible = true;
                    btn_action.Text = "ändern";
                    btn_schliessen.Text = "abbrechen";
                    txb_id.Text = a.Id;
                    txb_id.ReadOnly = true;
                    txb_vorname.Text = a.Vorname;
                    txb_vorname.ReadOnly = true;
                    txb_nachname.Text = a.Nachname;
                    txb_nachname.ReadOnly = true;
                    txb_strasse.Text = a.Strasse;
                    txb_strasse.ReadOnly = false;
                    txb_plz.Text = a.Plz;
                    txb_plz.ReadOnly = false;
                    txb_ort.Text = a.Ort;
                    txb_ort.ReadOnly = false;
                    break;
                case 3:
                    lbl_ueberschrift.Text = "Adressdaten löschen";
                    lbl_meldung.Text = "Wollen Sie die Adressdaten wirklich löschen?";
                    btn_action.Visible = true;
                    btn_action.Text = "löschen";
                    btn_schliessen.Text = "abbrechen";
                    txb_id.Text = a.Id;
                    txb_id.ReadOnly = true;
                    txb_vorname.Text = a.Vorname;
                    txb_vorname.ReadOnly = true;
                    txb_nachname.Text = a.Nachname;
                    txb_nachname.ReadOnly = true;
                    txb_strasse.Text = a.Strasse;
                    txb_strasse.ReadOnly = true;
                    txb_plz.Text = a.Plz;
                    txb_plz.ReadOnly = true;
                    txb_ort.Text = a.Ort;
                    txb_ort.ReadOnly = true;
                    break;
                default:
                    break;
            }
        }

        private bool validateParameter()
        {
            if (txb_strasse.Text.Length == 0)
            {
                return false;
            }
            if (txb_plz.Text.Length == 0)
            {
                return false;
            }
            if (txb_ort.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        private void btn_schliessen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_action_Click(object sender, EventArgs e)
        {
            if (validateParameter())
            {
                switch (modus)
                {
                    case 0:
                        try
                        {
                            String sql = "insert into adressdaten values (?adress_id,?person_id,?strasse,?plz,?ort);";
                            db.prepareStatement(sql);
                            db.addParamToStatement("?adress_id", key);
                            db.addParamToStatement("?person_id", key);
                            db.addParamToStatement("?strasse", txb_strasse.Text.Trim());
                            db.addParamToStatement("?plz", txb_plz.Text.Trim());
                            db.addParamToStatement("?ort", txb_ort.Text.Trim());
                            db.executeStatement();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Fehler beim Anlegen der Adressdaten!" + ex.Message);
                        }
                        this.Close();
                        break;
                    case 2:
                        try
                        {
                            String sql = "update adressdaten " +
                                         "   set strasse = ?strasse, " +
                                         "   	     plz = ?plz, " +
                                         "   	     ort = ?ort " +
                                         " where person_id = " + txb_id.Text;
                            db.prepareStatement(sql);
                            db.addParamToStatement("?strasse", txb_strasse.Text.Trim());
                            db.addParamToStatement("?plz", txb_plz.Text.Trim());
                            db.addParamToStatement("?ort", txb_ort.Text.Trim());
                            db.executeStatement();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Fehler beim Ändern der Adressdaten!");
                        }
                        this.Close();
                        break;
                    case 3:
                        try
                        {
                            String sql = "delete from adressdaten where adress_id = " + txb_id.Text;
                            db.prepareStatement(sql);
                            db.executeStatement();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Fehler beim Löschen der Adressdaten!");
                        }
                        this.Close();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Eingabefeld darf nicht leer sein!");
            }            
        }
    }
}
