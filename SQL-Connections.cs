using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace TicTacToe_WindowsForms
{
    static class SQL_Connections
    {
        public static bool CheckLogin(string id, string pw)
        {
            using (var connection = new SqliteConnection("Data Source=database.db"))
            {
                bool access_granted = false;
                if (ProofReal(id))
                {
                    connection.Open();
                    var command = connection.CreateCommand();
                    command.CommandText =
                    @"
                    SELECT userName, userPassword
                    FROM tblUser
                    WHERE userName = $id
                ";
                    command.Parameters.AddWithValue("$id", id);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var name = reader.GetString(0);
                            var pwText = reader.GetString(1);
                            if (pwText == pw)
                            {
                                MessageBox.Show($"Welcome  {id}!, your PW: {pwText}");
                                access_granted = true;
                            }
                            else
                            {
                                MessageBox.Show("Wrong PW. Access denied. Try again.");
                            }
                        }
                    }
                    connection.Close();
                }
                return access_granted;
            }

        }
        public static void CheckRegistry(string name_1, string pw_1)
        {
            using (var con = new SqliteConnection("Data Source=database.db"))
            {
                con.Open();
                // Prüfen, ob Benutzer schon vorhanden
                var cmd_1 = con.CreateCommand();
                //string Query_1 = $"SELECT userName FROM tblUser WHERE userName = {name_1}";
                //SqliteCommand cmd_1 = new SqliteCommand(Query_1, con);
                cmd_1.CommandText =
                    @"SELECT COUNT (userName)
                    FROM tblUser
                    WHERE userName = $name_1
                    ";
                cmd_1.Parameters.AddWithValue("$name_1", name_1);
                int RowCount = 0;
                RowCount = Convert.ToInt32(cmd_1.ExecuteScalar());
                // zum Zeigen ob wirklich 0 RowCount
                // MessageBox.Show($"{RowCount}");
                if (RowCount > 0)
                {
                    MessageBox.Show($"Der Benutzer {name_1} existiert schon." +
                        $"\n Try again.");

                }
                else
                {
                    // neuen Benutzer hinzufügen
                    string Query = "INSERT INTO tblUser (userName,userPassword) VALUES('" + name_1 + "','" + pw_1 + "')";
                    SqliteCommand cmd = new SqliteCommand(Query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Registrierung erfolgreich.");
                    // aber warum wird er immer bei userID 4 angelegt?
                    // Warum erweitert sich die Datenbank nicht darüber hinaus?
                }
            }
        }
        public static bool ProofReal(string name_1)
        {
            bool already_existing = false;
            using (var con = new SqliteConnection("Data Source=database.db"))
            {
                con.Open();
                // Prüfen, ob Benutzer schon vorhanden
                var cmd_1 = con.CreateCommand();
                cmd_1.CommandText =
                    @"SELECT COUNT (userName)
                    FROM tblUser
                    WHERE userName = $name_1
                    ";
                cmd_1.Parameters.AddWithValue("$name_1", name_1);
                int RowCount = 0;
                RowCount = Convert.ToInt32(cmd_1.ExecuteScalar());
                // zum Zeigen ob wirklich 0 RowCount
                // MessageBox.Show($"{RowCount}");
                if (RowCount > 0)
                {
                    already_existing = true;
                }
                else
                {
                    // Benutzer noch unbekannt
                    MessageBox.Show("Benutzername unbekannt.");

                }
            }
            return already_existing;
        }
        public static void FillData(string id, bool win)
        {

        }
    }
}
