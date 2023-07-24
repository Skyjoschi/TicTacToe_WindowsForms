using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Media;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe_T2;


namespace TicTacToe_T2
{
    public partial class TicTacToe_Gameboard : Form
    {

        string player = "X";
        short movement = 0;

        public TicTacToe_Gameboard()
        {
            InitializeComponent();
            lbl_Anweisung.Text = "Klicke ein Feld.";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        // setzt Feld automatisch zurück und schließt das Fenster
        private void ResetGameboard(Button bt)
        {
            movement = 0;
            b1.Enabled = true; b1.Text = ""; b1.BackColor = Color.White;
            b2.Enabled = true; b2.Text = ""; b2.BackColor = Color.White;
            b3.Enabled = true; b3.Text = ""; b3.BackColor = Color.White;
            b4.Enabled = true; b4.Text = ""; b4.BackColor = Color.White;
            b5.Enabled = true; b5.Text = ""; b5.BackColor = Color.White;
            b6.Enabled = true; b6.Text = ""; b6.BackColor = Color.White;
            b7.Enabled = true; b7.Text = ""; b7.BackColor = Color.White;
            b8.Enabled = true; b8.Text = ""; b8.BackColor = Color.White;
            b9.Enabled = true; b9.Text = ""; b9.BackColor = Color.White;
            this.Close();
        }

        // Aktion, wenn Feld angeklickt wird. Alle Buttons referenzieren auf diesen Befehl
        private void button_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            bt.Enabled = false;
            if (player == "X" && movement < 9)
            {
                bt.BackColor = Color.Aquamarine;
                bt.Text = $"{player}";
                if (!CheckWin(bt, player))
                {
                    MessageBox.Show($"Spieler {player.ToString().ToUpper()} gewinnt!");
                    ResetGameboard(bt);
                }
                movement++;
                player = "O";
            }
            else if (player == "O" && movement < 9)
            {
                bt.BackColor = Color.Khaki;
                bt.Text = $"{player}";
                if (!CheckWin(bt, player))
                {
                    MessageBox.Show($"Spieler {player.ToString().ToUpper()} gewinnt!");
                    ResetGameboard(bt);
                }
                movement++;
                player = "X";
            }
            else if (movement >= 9)
            {
                MessageBox.Show("Unentschieden!");
                ResetGameboard(bt);
            }

        }

        // prüft bei jedem Klick, ob ein Gewinn vorliegt
        private bool CheckWin(Button bt, string player)
        {
            bt.Text = player;

            bool game = true;
            if (
                //vertikalen
                b1.Text == b2.Text && b1.Text == b3.Text && b1.Text != "" ||
                b4.Text == b5.Text && b4.Text == b6.Text && b4.Text != "" ||
                b7.Text == b8.Text && b7.Text == b9.Text && b7.Text != "" ||

                // horizontalen
                b1.Text == b4.Text && b1.Text == b7.Text && b1.Text != "" ||
                b2.Text == b5.Text && b2.Text == b8.Text && b2.Text != "" ||
                b3.Text == b6.Text && b3.Text == b9.Text && b3.Text != "" ||

                // diagonal geprüft
                b1.Text == b5.Text && b1.Text == b9.Text && b1.Text != "" ||
                b7.Text == b5.Text && b7.Text == b3.Text && b7.Text != ""
                )
            {
                game = false;
            }
            return game;

        }


        private void TicTacToe_Gameboard_Load(object sender, EventArgs e)
        {

        }

        // private Kommentare:

        // Textboxen: Multi-Line, read-only und password-Char setzbar
        // für Datumsanzeige ohne Konflikte: (@\:hh\:mm\:ss)
        // noch DataGridView möglich als Tabelle


    }
}
