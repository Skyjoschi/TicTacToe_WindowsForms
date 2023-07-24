namespace TicTacToe_T2
{
    partial class TicTacToe_Gameboard
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
            lbl_Tic = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            b9 = new Button();
            b8 = new Button();
            b7 = new Button();
            b6 = new Button();
            b5 = new Button();
            b4 = new Button();
            b3 = new Button();
            b2 = new Button();
            b1 = new Button();
            lbl_Anweisung = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_Tic
            // 
            lbl_Tic.AutoSize = true;
            lbl_Tic.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Tic.Location = new Point(185, 9);
            lbl_Tic.Name = "lbl_Tic";
            lbl_Tic.Size = new Size(298, 62);
            lbl_Tic.TabIndex = 0;
            lbl_Tic.Text = "TIC TAC TOE";
            lbl_Tic.Click += label1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(b9, 2, 2);
            tableLayoutPanel1.Controls.Add(b8, 1, 2);
            tableLayoutPanel1.Controls.Add(b7, 0, 2);
            tableLayoutPanel1.Controls.Add(b6, 2, 1);
            tableLayoutPanel1.Controls.Add(b5, 1, 1);
            tableLayoutPanel1.Controls.Add(b4, 0, 1);
            tableLayoutPanel1.Controls.Add(b3, 2, 0);
            tableLayoutPanel1.Controls.Add(b2, 1, 0);
            tableLayoutPanel1.Controls.Add(b1, 0, 0);
            tableLayoutPanel1.Location = new Point(117, 82);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(415, 372);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // b9
            // 
            b9.Dock = DockStyle.Fill;
            b9.FlatAppearance.BorderSize = 5;
            b9.FlatStyle = FlatStyle.Flat;
            b9.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            b9.Location = new Point(279, 251);
            b9.Name = "b9";
            b9.Size = new Size(133, 118);
            b9.TabIndex = 8;
            b9.UseVisualStyleBackColor = true;
            b9.Click += button_Click;
            // 
            // b8
            // 
            b8.Dock = DockStyle.Fill;
            b8.FlatAppearance.BorderSize = 5;
            b8.FlatStyle = FlatStyle.Flat;
            b8.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            b8.Location = new Point(141, 251);
            b8.Name = "b8";
            b8.Size = new Size(132, 118);
            b8.TabIndex = 7;
            b8.UseVisualStyleBackColor = true;
            b8.Click += button_Click;
            // 
            // b7
            // 
            b7.Dock = DockStyle.Fill;
            b7.FlatAppearance.BorderSize = 5;
            b7.FlatStyle = FlatStyle.Flat;
            b7.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            b7.Location = new Point(3, 251);
            b7.Name = "b7";
            b7.Size = new Size(132, 118);
            b7.TabIndex = 6;
            b7.UseVisualStyleBackColor = true;
            b7.Click += button_Click;
            // 
            // b6
            // 
            b6.Dock = DockStyle.Fill;
            b6.FlatAppearance.BorderSize = 5;
            b6.FlatStyle = FlatStyle.Flat;
            b6.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            b6.Location = new Point(279, 127);
            b6.Name = "b6";
            b6.Size = new Size(133, 118);
            b6.TabIndex = 5;
            b6.UseVisualStyleBackColor = true;
            b6.Click += button_Click;
            // 
            // b5
            // 
            b5.Dock = DockStyle.Fill;
            b5.FlatAppearance.BorderSize = 5;
            b5.FlatStyle = FlatStyle.Flat;
            b5.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            b5.Location = new Point(141, 127);
            b5.Name = "b5";
            b5.Size = new Size(132, 118);
            b5.TabIndex = 4;
            b5.UseVisualStyleBackColor = true;
            b5.Click += button_Click;
            // 
            // b4
            // 
            b4.Dock = DockStyle.Fill;
            b4.FlatAppearance.BorderSize = 5;
            b4.FlatStyle = FlatStyle.Flat;
            b4.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            b4.Location = new Point(3, 127);
            b4.Name = "b4";
            b4.Size = new Size(132, 118);
            b4.TabIndex = 3;
            b4.UseVisualStyleBackColor = true;
            b4.Click += button_Click;
            // 
            // b3
            // 
            b3.Dock = DockStyle.Fill;
            b3.FlatAppearance.BorderSize = 5;
            b3.FlatStyle = FlatStyle.Flat;
            b3.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            b3.Location = new Point(279, 3);
            b3.Name = "b3";
            b3.Size = new Size(133, 118);
            b3.TabIndex = 2;
            b3.UseVisualStyleBackColor = true;
            b3.Click += button_Click;
            // 
            // b2
            // 
            b2.Dock = DockStyle.Fill;
            b2.FlatAppearance.BorderSize = 5;
            b2.FlatStyle = FlatStyle.Flat;
            b2.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            b2.Location = new Point(141, 3);
            b2.Name = "b2";
            b2.Size = new Size(132, 118);
            b2.TabIndex = 1;
            b2.UseVisualStyleBackColor = true;
            b2.Click += button_Click;
            // 
            // b1
            // 
            b1.Dock = DockStyle.Fill;
            b1.FlatAppearance.BorderSize = 5;
            b1.FlatStyle = FlatStyle.Flat;
            b1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            b1.Location = new Point(3, 3);
            b1.Name = "b1";
            b1.Size = new Size(132, 118);
            b1.TabIndex = 0;
            b1.UseVisualStyleBackColor = true;
            b1.Click += button_Click;
            // 
            // lbl_Anweisung
            // 
            lbl_Anweisung.AutoSize = true;
            lbl_Anweisung.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Anweisung.Location = new Point(243, 477);
            lbl_Anweisung.Name = "lbl_Anweisung";
            lbl_Anweisung.Size = new Size(147, 28);
            lbl_Anweisung.TabIndex = 7;
            lbl_Anweisung.Text = "Spielanweisung";
            // 
            // TicTacToe_Gameboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 538);
            Controls.Add(lbl_Anweisung);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(lbl_Tic);
            Name = "TicTacToe_Gameboard";
            Text = "TicTacToe_Gameboard";
            Load += TicTacToe_Gameboard_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Tic;
        private TableLayoutPanel tableLayoutPanel1;
        private Button b1;
        private Button b9;
        private Button b8;
        private Button b7;
        private Button b6;
        private Button b5;
        private Button b4;
        private Button b3;
        private Button b2;
        private Label lbl_Anweisung;
    }
}