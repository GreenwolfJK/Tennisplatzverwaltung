using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Tennisplatzverwaltung
{
    public class DBConnect
    {
        //Instanzieren von MysqlConnection, MySqlCommand und des ConnectionStrings mit entsprechenden Server Informationen
        MySqlConnection connection = null;
        MySqlCommand statement = null;
        private String myConnectionString = "SERVER=h2440804.stratoserver.net;" +
                                            "DATABASE=Tennisplatzverwaltung;" +
                                            "UID=tennisjogis;" +
                                            "PASSWORD=Bauhausifi11a;";

        //Konstruktor
        public DBConnect()
        {
            connection = new MySqlConnection(myConnectionString);
        }

        //Öffnen der Datenbankverbindung
        public bool openDatabase()
        {
            try
            {
                connection.Open();
                return true;
            }
            //Falls keine Verbindung möglich
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
                return false;
            }
        }

        public MySqlDataReader executeQuery(string sql)
        {
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = sql;
            MySqlDataReader reader;
            reader = command.ExecuteReader();
            return reader;
        }

        public void prepareStatement(String sql)
        {
            this.statement = new MySqlCommand(sql, connection);
        }

        public void addParamToStatement(String pos, Object param)
        {
            statement.Parameters.AddWithValue(pos, param);
        }

        public void executeStatement()
        {
            statement.ExecuteNonQuery();
        }

        //Schliessen der Datenbankverbindung
        public bool closeDatabase()
        {
            try
            {
                connection.Close();
                return true;
            }
            //Falls Schliessen nicht möglich
            catch (Exception e2)
            {
                MessageBox.Show("Error has occured!" + e2.Message);
                return false;
            }
        }

        //Befüllen eines DataTables, Übergabe eines SQL Statements als Parameter
        public DataTable fillTable(string sql)
        {
            //Initialisieren eines MySqlCommand und MySqlDataAdapter mit entsprechenden Parametern
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            //Konstruieren des DataTables, befüllen des Tables durch DataAdapter und Zurückgeben
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            return tbl;
        }

        //Schreiben der Änderungen im DGV in die Datenbank
        public bool writeIntoDatabase(DataTable tbl, string cbItem)
        {
            //Rückgabewert
            bool success = false;

            //Modulare Erstellung des Select Statements entsprechend des aktuell ausgewählten Tables
            using (MySqlCommand sqlCom = new MySqlCommand("SELECT * FROM " + cbItem, connection))
            {
                //Erzeugen und Initialisieren eine DataAdapters und CommandBuilders
                MySqlDataAdapter da = new MySqlDataAdapter(sqlCom);
                MySqlCommandBuilder cmb = new MySqlCommandBuilder(da);

                //Zuweisen der vom CommandBuilder erstellten Insert, Delete und Update Commands and den DataAdapter
                da.InsertCommand = cmb.GetInsertCommand();
                da.DeleteCommand = cmb.GetDeleteCommand();
                da.UpdateCommand = cmb.GetUpdateCommand();

                //Zuweisen eines Primary Keys an das übergebene DataTable Objekt
                tbl.PrimaryKey = new DataColumn[] { tbl.Columns[0] };

                try
                {
                    //Versuche mit DataAdapter Änderungen in die Datenbank zu updaten
                    da.Update(tbl);
                    success = true;
                }
                //Falls nicht möglich, success -> false + Fehlermeldung
                catch (Exception ex)
                {
                    MessageBox.Show("Error has occured!" + ex.Message);
                    success = false;
                }
            }
            return success;
        }

        public int getPersonId (string vorname, string nachname)
        {
            int personID = 0;
            using (MySqlCommand cmd = new MySqlCommand("SELECT person_id FROM personendaten WHERE vorname = @vorname AND nachname = @nachname", connection))
            {
                cmd.Parameters.AddWithValue("vorname", vorname);
                cmd.Parameters.AddWithValue("nachname", nachname);
                try 
	            {	   
		            MySqlDataReader reader = cmd.ExecuteReader();
                       
                    while(reader.Read())
                    {
                        personID = reader.GetInt32(0);
                    }
                reader.Close();
	            }
	            catch (Exception ex)
	            {
		            MessageBox.Show("Error has occured!" + ex.Message);
	            }
            
            }
            return personID;
        }
    }
}
