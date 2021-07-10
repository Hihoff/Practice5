namespace Практика5
{
    partial class MainForm1
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Label();
            this.Profile = new System.Windows.Forms.Label();
            this.auction = new System.Windows.Forms.Label();
            this.autorization = new System.Windows.Forms.Label();
            this.register = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.label_top = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.MainPanel.Controls.Add(this.Exit);
            this.MainPanel.Controls.Add(this.Profile);
            this.MainPanel.Controls.Add(this.auction);
            this.MainPanel.Controls.Add(this.autorization);
            this.MainPanel.Controls.Add(this.register);
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(800, 450);
            this.MainPanel.TabIndex = 1;
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(12, 262);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(55, 18);
            this.Exit.TabIndex = 11;
            this.Exit.Text = "Выход";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Profile
            // 
            this.Profile.AutoSize = true;
            this.Profile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Profile.Location = new System.Drawing.Point(12, 125);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(181, 18);
            this.Profile.TabIndex = 10;
            this.Profile.Text = "Профиль(Не работает)";
            // 
            // auction
            // 
            this.auction.AutoSize = true;
            this.auction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.auction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.auction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.auction.Location = new System.Drawing.Point(12, 159);
            this.auction.Name = "auction";
            this.auction.Size = new System.Drawing.Size(177, 18);
            this.auction.TabIndex = 9;
            this.auction.Text = "Аукцион(Не работает)";
            // 
            // autorization
            // 
            this.autorization.AutoSize = true;
            this.autorization.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.autorization.Cursor = System.Windows.Forms.Cursors.Hand;
            this.autorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.autorization.Location = new System.Drawing.Point(12, 228);
            this.autorization.Name = "autorization";
            this.autorization.Size = new System.Drawing.Size(166, 18);
            this.autorization.TabIndex = 8;
            this.autorization.Text = "Смена пользователя";
            this.autorization.Click += new System.EventHandler(this.Autorization_Click);
            // 
            // register
            // 
            this.register.AutoSize = true;
            this.register.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.register.Location = new System.Drawing.Point(12, 195);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(105, 18);
            this.register.TabIndex = 7;
            this.register.Text = "Регистрация";
            this.register.Click += new System.EventHandler(this.Register_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Controls.Add(this.label_top);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 76);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(777, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(1166, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(20, 20);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "X";
            // 
            // label_top
            // 
            this.label_top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_top.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_top.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label_top.Location = new System.Drawing.Point(0, 0);
            this.label_top.Name = "label_top";
            this.label_top.Size = new System.Drawing.Size(800, 76);
            this.label_top.TabIndex = 0;
            this.label_top.Text = "Главное меню";
            this.label_top.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm1";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label label_top;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label register;
        private System.Windows.Forms.Label autorization;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label Profile;
        private System.Windows.Forms.Label auction;
    }
}