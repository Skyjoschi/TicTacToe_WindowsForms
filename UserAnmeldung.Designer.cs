namespace TicTacToe_WindowsForms
{
    partial class UserAnmeldung
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
            lblUser1 = new Label();
            InputUsername = new MaskedTextBox();
            InputPW1 = new MaskedTextBox();
            lblPW1 = new Label();
            btnRegistry = new Button();
            btnLogin = new Button();
            lblU1 = new Label();
            SuspendLayout();
            // 
            // lblUser1
            // 
            lblUser1.AutoSize = true;
            lblUser1.Location = new Point(41, 71);
            lblUser1.Name = "lblUser1";
            lblUser1.Size = new Size(107, 20);
            lblUser1.TabIndex = 0;
            lblUser1.Text = "Benutzername:";
            lblUser1.Click += label1_Click;
            // 
            // InputUsername
            // 
            InputUsername.Location = new Point(181, 68);
            InputUsername.Name = "InputUsername";
            InputUsername.Size = new Size(125, 27);
            InputUsername.TabIndex = 1;
            // 
            // InputPW1
            // 
            InputPW1.Location = new Point(181, 105);
            InputPW1.Name = "InputPW1";
            InputPW1.PasswordChar = '*';
            InputPW1.Size = new Size(125, 27);
            InputPW1.TabIndex = 2;
            // 
            // lblPW1
            // 
            lblPW1.AutoSize = true;
            lblPW1.Location = new Point(79, 108);
            lblPW1.Name = "lblPW1";
            lblPW1.Size = new Size(69, 20);
            lblPW1.TabIndex = 3;
            lblPW1.Text = "Passwort:";
            // 
            // btnRegistry
            // 
            btnRegistry.Location = new Point(181, 187);
            btnRegistry.Name = "btnRegistry";
            btnRegistry.Size = new Size(131, 29);
            btnRegistry.TabIndex = 5;
            btnRegistry.Text = "Neu Registrieren";
            btnRegistry.UseVisualStyleBackColor = true;
            btnRegistry.Click += btnRegistry_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(200, 152);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblU1
            // 
            lblU1.AutoSize = true;
            lblU1.Location = new Point(127, 24);
            lblU1.Name = "lblU1";
            lblU1.Size = new Size(50, 20);
            lblU1.TabIndex = 6;
            lblU1.Text = "User 1";
            // 
            // UserAnmeldung
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 359);
            Controls.Add(lblU1);
            Controls.Add(btnLogin);
            Controls.Add(btnRegistry);
            Controls.Add(lblPW1);
            Controls.Add(InputPW1);
            Controls.Add(InputUsername);
            Controls.Add(lblUser1);
            Name = "UserAnmeldung";
            Text = "UserAnmeldung";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUser1;
        private MaskedTextBox InputUsername;
        private MaskedTextBox InputPW1;
        private Label lblPW1;
        private Button btnRegistry;
        private Button btnLogin;
        private Label lblU1;
    }
}