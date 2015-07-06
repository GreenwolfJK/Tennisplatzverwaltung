using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tennisplatzverwaltung
{
    class Buchungscheck
    {
        int platznr;
        DateTime wunschtermin;
        Time start;
        Time ende;
        String playerName;

        DBConnect db = new DBConnect();

        public Buchungscheck()
        {
            this.platznr = 1;
            this.wunschtermin = DateTime.Today;
            this.start = new Time(11, 15);
            this.ende = new Time(12, 30);
            this.playerName = "Erna Engel";
        }

        public Buchungscheck(int _platznr, DateTime _wunschtermin, Time _start, Time _ende, String _playerName)
        {
            this.platznr = _platznr;
            this.wunschtermin = _wunschtermin;
            this.start = _start;
            this.ende = _ende;
            this.playerName = _playerName;
            MessageBox.Show("Platznummer: " + this.platznr);
        }

        public bool checkBuchung()
        {
            bool dbopen = db.openDatabase();
            MySqlDataReader reader = db.executeQuery("SELECT datum_start, datum_end FROM buchungen WHERE platz_id = " + platznr);
            if (reader.HasRows)
            {
                Zeitspanne check = new Zeitspanne(this.start, this.ende);

                while (reader.Read())
                {
                    Time DataStart = new Time(reader.GetDateTime(0).Hour, reader.GetDateTime(0).Minute);
                    Time DataEnd = new Time(reader.GetDateTime(1).Hour, reader.GetDateTime(1).Minute);
                    Zeitspanne check2 = new Zeitspanne(DataStart, DataEnd);

                    if (check.checkOverlap(check2))
                    {
                        MessageBox.Show("Es liegt eine Überschneidung vor");
                        return false;
                    }
                }
            }

            MessageBox.Show("Es liegt keine Überschneidung vor");
            return true;
        }
    }
}
