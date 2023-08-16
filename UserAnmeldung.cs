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
            if (SQL_Connections.CheckLogin(InputUsername.Text, InputPW1.Text))
            {
                string id = InputUsername.Text;
                string nameTable = "tblScore";
                if (SQL_Connections.AlreadyInTable(id, nameTable))
                {
                    SQL_Connections.UpdateData(id);
                }
                else
                {
                    SQL_Connections.InsertData(id, nameTable, "userNameFor");
                    SQL_Connections.UpdateData(id);
                }
                dialog.ShowDialog();
            }
            
        }

        private void btnRegistry_Click(object sender, EventArgs e)
        {
            SQL_Connections.CheckRegistry(InputUsername.Text, InputPW1.Text);
        }
    }
}
