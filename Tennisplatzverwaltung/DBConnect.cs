﻿using System;
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
        MySqlConnection connection = null;
        MySqlCommand statement = null;
        //private String myConnectionString = "SERVER=localhost;" +
        //                                    "DATABASE=tennis;" +
        //                                    "UID=tennis;" +
        //                                    "PASSWORD=tennis;";
        private String myConnectionString = "SERVER=h2440804.stratoserver.net;" +
                                            "DATABASE=Tennisplatzverwaltung;" +
                                            "UID=tennisjogis;" +
                                            "PASSWORD=Bauhausifi11a;";

        // Verindung wird mit Connection String zur MySQL Datenbank aufgesetzt
        public DBConnect()
        {
            connection = new MySqlConnection(myConnectionString);
        }

        // Öffnet die Datenbankverbindung
        public bool openDatabase()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error has occured:\n" + e1.Message);
                return false;
            }
        }

        // Setzt einen normalen Query ab und gibt das Ergebnis im Reader zurück
        public MySqlDataReader executeQuery(string sql)
        {
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = sql;
            MySqlDataReader reader;
            reader = command.ExecuteReader();
            return reader;
        }

        // PreparedStatements zum Modifizieren der Tabellen; SQL-Injection versichert
        public void prepareStatement(String sql)
        {
            this.statement = new MySqlCommand(sql, connection);
        }

        // Füllt das Statement mit den Parametern
        public void addParamToStatement(String pos, Object param)
        {
            statement.Parameters.AddWithValue(pos, param);
        }

        // Setzt das Statement ab
        public void executeStatement()
        {
            statement.ExecuteNonQuery();
        }

        // Schliesst die Verbindung
        public bool closeDatabase()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (Exception e2)
            {
                MessageBox.Show("Error has occured:\n" + e2.Message);
                return false;
            }
        }

        public DataTable fillTable(string sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable tbl = new DataTable();
            da.Fill(tbl);
            return tbl;
        }

        public bool writeIntoDatabase(DataTable tbl, string cbItem)
        {
            bool success = false;

            using (MySqlCommand sqlCom = new MySqlCommand("SELECT * FROM " + cbItem, connection))
            {
                MySqlDataAdapter da = new MySqlDataAdapter(sqlCom);
                MySqlCommandBuilder cmb = new MySqlCommandBuilder(da);

                da.InsertCommand = cmb.GetInsertCommand();
                da.DeleteCommand = cmb.GetDeleteCommand();
                da.UpdateCommand = cmb.GetUpdateCommand();

                tbl.PrimaryKey = new DataColumn[] { tbl.Columns[0] };

                try
                {
                    da.Update(tbl);
                    success = true;
                }
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

        public int checkPersonId(int personId)
        {
            using (MySqlCommand cmd = new MySqlCommand("SELECT EXISTS(SELECT 1 FROM personendaten WHERE person_id = @personId LIMIT 1)", connection))
            {
                cmd.Parameters.AddWithValue("personId", personId);
                try 
	            {
                    var requestResult = cmd.ExecuteScalar();

                    int result = Convert.ToInt32(requestResult.ToString());

                    return result;
	            }
	            catch (Exception ex)
	            {
		            MessageBox.Show("Error has occured!" + ex.Message);

                    int result = 0;

                    return result;
	            }
            
            }
        }
    }
}
