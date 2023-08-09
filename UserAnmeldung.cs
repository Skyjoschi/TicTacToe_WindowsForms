using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe_T2;

namespace TicTacToe_WindowsForms
{
    public partial class UserAnmeldung : Form
    {
        // neues DialogFenster initialiseren
        Spielauswahl dialog = new Spielauswahl();
        public UserAnmeldung()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            dialog.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (var connection = new SqliteConnection("Data Source=database.db"))
            {
                string id = InputUsername.Text;
                string pw = InputPW1.Text;
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
                            dialog.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Access denied. Try again.");
                        }
                    }
                }
                connection.Close();
            }
        }

        private void btnRegistry_Click(object sender, EventArgs e)
        {
            using (var con = new SqliteConnection("Data Source=database.db"))
            {

                try
                {
                    con.Open();
                    // Prüfen, ob Benutzer schon vorhanden.
                    try
                    {
                        string Query_1 = $"SELECT userName FROM tblUser WHERE userName = {InputUsername.Text}";
                        SqliteCommand cmd_1 = new SqliteCommand(Query_1, con);
                        cmd_1.CommandText = Query_1;
                        using (var reader = cmd_1.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var name = reader.GetString(0);
                                if (name == InputUsername.Text)
                                {
                                    MessageBox.Show($"Der Benutzer {InputUsername.Text} existiert schon." +
                                        $"\n Try again.");
                                }
                            }
                        }
                    } 
                    catch (Exception ex) 
                    {
                        // neuen Benutzer hinzufügen
                        string Query = "INSERT INTO tblUser (userName,userPassword) VALUES('" + InputUsername.Text + "','" + InputPW1.Text + "')";
                        SqliteCommand cmd = new SqliteCommand(Query, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Registriertung erfolgreich.");
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
