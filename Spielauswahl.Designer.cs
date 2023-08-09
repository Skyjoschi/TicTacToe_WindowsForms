namespace TicTacToe_T2
{
    partial class Spielauswahl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSpielauswahl = new Label();
            rb1 = new RadioButton();
            rb2 = new RadioButton();
            btnAuswahl = new Button();
            SuspendLayout();
            // 
            // lblSpielauswahl
            // 
            lblSpielauswahl.AutoSize = true;
            lblSpielauswahl.Location = new Point(128, 43);
            lblSpielauswahl.Name = "lblSpielauswahl";
            lblSpielauswahl.Size = new Size(94, 20);
            lblSpielauswahl.TabIndex = 1;
            lblSpielauswahl.Text = "SPIELE FÜR 2";
            lblSpielauswahl.Click += label2_Click;
            // 
            // rb1
            // 
            rb1.AutoSize = true;
            rb1.Location = new Point(128, 78);
            rb1.Name = "rb1";
            rb1.Size = new Size(94, 24);
            rb1.TabIndex = 2;
            rb1.TabStop = true;
            rb1.Text = "TicTacToe";
            rb1.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            rb2.AutoSize = true;
            rb2.Location = new Point(127, 108);
            rb2.Name = "rb2";
            rb2.Size = new Size(95, 24);
            rb2.TabIndex = 3;
            rb2.TabStop = true;
            rb2.Text = "Hangman";
            rb2.UseVisualStyleBackColor = true;
            // 
            // btnAuswahl
            // 
            btnAuswahl.Location = new Point(66, 138);
            btnAuswahl.Name = "btnAuswahl";
            btnAuswahl.Size = new Size(214, 29);
            btnAuswahl.TabIndex = 5;
            btnAuswahl.Text = "Auswahl treffen";
            btnAuswahl.UseVisualStyleBackColor = true;
            btnAuswahl.Click += btnAuswahl_Click;
            // 
            // DialogForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 301);
            Controls.Add(btnAuswahl);
            Controls.Add(rb2);
            Controls.Add(rb1);
            Controls.Add(lblSpielauswahl);
            Name = "DialogForm";
            Text = "DialogForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblSpielauswahl;
        private RadioButton rb1;
        private RadioButton rb2;
        private Button btnAuswahl;
    }
}