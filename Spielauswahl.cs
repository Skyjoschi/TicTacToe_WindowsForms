﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_T2
{

    public partial class Spielauswahl : Form
    {
        TicTacToe_Gameboard gameboard = new TicTacToe_Gameboard();
        public Spielauswahl()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // These are some comments, and a new command:
            this.Close();
            // this was added manually afterwards
        }

        private void btnAuswahl_Click(object sender, EventArgs e)
        {
            string result = "";
            if (rb1.Checked)
            {
                result += "TicTacToe";
                gameboard.ShowDialog();
            }
            else
            {
                this.Close();
            }
        }

    }
}
