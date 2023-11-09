
namespace Computer_Performance_Windows_Chart
{
    partial class TicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToe));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A1 = new MetroFramework.Controls.MetroButton();
            this.B1 = new MetroFramework.Controls.MetroButton();
            this.A2 = new MetroFramework.Controls.MetroButton();
            this.A3 = new MetroFramework.Controls.MetroButton();
            this.B2 = new MetroFramework.Controls.MetroButton();
            this.B3 = new MetroFramework.Controls.MetroButton();
            this.C1 = new MetroFramework.Controls.MetroButton();
            this.C2 = new MetroFramework.Controls.MetroButton();
            this.C3 = new MetroFramework.Controls.MetroButton();
            this.draw_label = new System.Windows.Forms.Label();
            this.X_Count = new System.Windows.Forms.Label();
            this.Draw_Count = new System.Windows.Forms.Label();
            this.O_Count = new System.Windows.Forms.Label();
            this.player1_label = new MetroFramework.Controls.MetroTextBox();
            this.player2_label = new MetroFramework.Controls.MetroTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(30, 92);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(489, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // A1
            // 
            this.A1.Location = new System.Drawing.Point(34, 151);
            this.A1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(134, 123);
            this.A1.TabIndex = 1;
            this.A1.Click += new System.EventHandler(this.button_click);
            this.A1.MouseEnter += new System.EventHandler(this.mouse_enter);
            this.A1.MouseLeave += new System.EventHandler(this.mouse_leave);
            // 
            // B1
            // 
            this.B1.Location = new System.Drawing.Point(34, 312);
            this.B1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(134, 123);
            this.B1.TabIndex = 2;
            this.B1.Click += new System.EventHandler(this.button_click);
            this.B1.MouseEnter += new System.EventHandler(this.mouse_enter);
            this.B1.MouseLeave += new System.EventHandler(this.mouse_leave);
            // 
            // A2
            // 
            this.A2.Location = new System.Drawing.Point(208, 151);
            this.A2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(134, 123);
            this.A2.TabIndex = 3;
            this.A2.Click += new System.EventHandler(this.button_click);
            this.A2.MouseEnter += new System.EventHandler(this.mouse_enter);
            this.A2.MouseLeave += new System.EventHandler(this.mouse_leave);
            // 
            // A3
            // 
            this.A3.Location = new System.Drawing.Point(384, 151);
            this.A3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(134, 123);
            this.A3.TabIndex = 4;
            this.A3.Click += new System.EventHandler(this.button_click);
            this.A3.MouseEnter += new System.EventHandler(this.mouse_enter);
            this.A3.MouseLeave += new System.EventHandler(this.mouse_leave);
            // 
            // B2
            // 
            this.B2.Location = new System.Drawing.Point(208, 312);
            this.B2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(134, 123);
            this.B2.TabIndex = 5;
            this.B2.Click += new System.EventHandler(this.button_click);
            this.B2.MouseEnter += new System.EventHandler(this.mouse_enter);
            this.B2.MouseLeave += new System.EventHandler(this.mouse_leave);
            // 
            // B3
            // 
            this.B3.Location = new System.Drawing.Point(384, 312);
            this.B3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(134, 123);
            this.B3.TabIndex = 6;
            this.B3.Click += new System.EventHandler(this.button_click);
            this.B3.MouseEnter += new System.EventHandler(this.mouse_enter);
            this.B3.MouseLeave += new System.EventHandler(this.mouse_leave);
            // 
            // C1
            // 
            this.C1.Location = new System.Drawing.Point(34, 458);
            this.C1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(134, 123);
            this.C1.TabIndex = 7;
            this.C1.Click += new System.EventHandler(this.button_click);
            this.C1.MouseEnter += new System.EventHandler(this.mouse_enter);
            this.C1.MouseLeave += new System.EventHandler(this.mouse_leave);
            // 
            // C2
            // 
            this.C2.Location = new System.Drawing.Point(208, 458);
            this.C2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(134, 123);
            this.C2.TabIndex = 8;
            this.C2.Click += new System.EventHandler(this.button_click);
            this.C2.MouseEnter += new System.EventHandler(this.mouse_enter);
            this.C2.MouseLeave += new System.EventHandler(this.mouse_leave);
            // 
            // C3
            // 
            this.C3.Location = new System.Drawing.Point(384, 458);
            this.C3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(134, 123);
            this.C3.TabIndex = 9;
            this.C3.Click += new System.EventHandler(this.button_click);
            this.C3.MouseEnter += new System.EventHandler(this.mouse_enter);
            this.C3.MouseLeave += new System.EventHandler(this.mouse_leave);
            // 
            // draw_label
            // 
            this.draw_label.AutoSize = true;
            this.draw_label.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.draw_label.Location = new System.Drawing.Point(228, 643);
            this.draw_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.draw_label.MaximumSize = new System.Drawing.Size(114, 22);
            this.draw_label.MinimumSize = new System.Drawing.Size(114, 22);
            this.draw_label.Name = "draw_label";
            this.draw_label.Size = new System.Drawing.Size(114, 22);
            this.draw_label.TabIndex = 11;
            this.draw_label.Text = "Total Draws";
            this.draw_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // X_Count
            // 
            this.X_Count.AutoSize = true;
            this.X_Count.Location = new System.Drawing.Point(96, 685);
            this.X_Count.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.X_Count.Name = "X_Count";
            this.X_Count.Size = new System.Drawing.Size(18, 20);
            this.X_Count.TabIndex = 13;
            this.X_Count.Text = "0";
            // 
            // Draw_Count
            // 
            this.Draw_Count.AutoSize = true;
            this.Draw_Count.Location = new System.Drawing.Point(273, 685);
            this.Draw_Count.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Draw_Count.Name = "Draw_Count";
            this.Draw_Count.Size = new System.Drawing.Size(18, 20);
            this.Draw_Count.TabIndex = 14;
            this.Draw_Count.Text = "0";
            // 
            // O_Count
            // 
            this.O_Count.AutoSize = true;
            this.O_Count.Location = new System.Drawing.Point(441, 685);
            this.O_Count.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.O_Count.Name = "O_Count";
            this.O_Count.Size = new System.Drawing.Size(18, 20);
            this.O_Count.TabIndex = 15;
            this.O_Count.Text = "0";
            // 
            // player1_label
            // 
            this.player1_label.Location = new System.Drawing.Point(34, 643);
            this.player1_label.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.player1_label.Name = "player1_label";
            this.player1_label.Size = new System.Drawing.Size(153, 35);
            this.player1_label.TabIndex = 16;
            this.player1_label.Text = "Player 1";
            // 
            // player2_label
            // 
            this.player2_label.Location = new System.Drawing.Point(384, 643);
            this.player2_label.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.player2_label.Name = "player2_label";
            this.player2_label.Size = new System.Drawing.Size(153, 35);
            this.player2_label.TabIndex = 17;
            this.player2_label.Text = "Player 2";
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 743);
            this.Controls.Add(this.player2_label);
            this.Controls.Add(this.player1_label);
            this.Controls.Add(this.O_Count);
            this.Controls.Add(this.Draw_Count);
            this.Controls.Add(this.X_Count);
            this.Controls.Add(this.draw_label);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TicTacToe";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.Text = "Tic-Tac Toe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private MetroFramework.Controls.MetroButton A1;
        private MetroFramework.Controls.MetroButton B1;
        private MetroFramework.Controls.MetroButton A2;
        private MetroFramework.Controls.MetroButton A3;
        private MetroFramework.Controls.MetroButton B2;
        private MetroFramework.Controls.MetroButton B3;
        private MetroFramework.Controls.MetroButton C1;
        private MetroFramework.Controls.MetroButton C2;
        private MetroFramework.Controls.MetroButton C3;
        private System.Windows.Forms.Label draw_label;
        private System.Windows.Forms.Label X_Count;
        private System.Windows.Forms.Label Draw_Count;
        private System.Windows.Forms.Label O_Count;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private MetroFramework.Controls.MetroTextBox player1_label;
        private MetroFramework.Controls.MetroTextBox player2_label;
    }
}