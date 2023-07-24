namespace TicTacToe_T2
{
    public partial class Form1 : Form
    {
        // neues DialogFenster initialiseren
        DialogForm dialog = new DialogForm();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lbl1.Text = "Hello World!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ruft neues Fenster auf
            dialog.ShowDialog();
        }
    }
}