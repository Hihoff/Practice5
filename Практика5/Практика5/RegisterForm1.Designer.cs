namespace Практика5
{
    partial class RegisterForm1
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
            this.buttonRegister = new System.Windows.Forms.Button();
            this.password_register = new System.Windows.Forms.TextBox();
            this.login_register = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseButton1 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.label_top = new System.Windows.Forms.Label();
            this.autorization = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.MainPanel.Controls.Add(this.autorization);
            this.MainPanel.Controls.Add(this.buttonRegister);
            this.MainPanel.Controls.Add(this.password_register);
            this.MainPanel.Controls.Add(this.pictureBox2);
            this.MainPanel.Controls.Add(this.login_register);
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Controls.Add(this.pictureBox1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1019, 525);
            this.MainPanel.TabIndex = 1;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // buttonRegister
            // 
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.buttonRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Location = new System.Drawing.Point(438, 323);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(128, 35);
            this.buttonRegister.TabIndex = 5;
            this.buttonRegister.Text = "Зарегистрироваться";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // password_register
            // 
            this.password_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_register.Location = new System.Drawing.Point(423, 256);
            this.password_register.Name = "password_register";
            this.password_register.Size = new System.Drawing.Size(204, 35);
            this.password_register.TabIndex = 4;
            this.password_register.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password_register.UseSystemPasswordChar = true;
            // 
            // login_register
            // 
            this.login_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_register.Location = new System.Drawing.Point(423, 198);
            this.login_register.Multiline = true;
            this.login_register.Name = "login_register";
            this.login_register.Size = new System.Drawing.Size(204, 39);
            this.login_register.TabIndex = 2;
            this.login_register.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.login_register.Enter += new System.EventHandler(this.login_register_Enter);
            this.login_register.Leave += new System.EventHandler(this.login_register_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.CloseButton1);
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Controls.Add(this.label_top);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1019, 76);
            this.panel2.TabIndex = 0;
            // 
            // CloseButton1
            // 
            this.CloseButton1.AutoSize = true;
            this.CloseButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton1.ForeColor = System.Drawing.Color.White;
            this.CloseButton1.Location = new System.Drawing.Point(987, 9);
            this.CloseButton1.Name = "CloseButton1";
            this.CloseButton1.Size = new System.Drawing.Size(20, 20);
            this.CloseButton1.TabIndex = 2;
            this.CloseButton1.Text = "X";
            this.CloseButton1.Click += new System.EventHandler(this.CloseButton1_Click);
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
            this.label_top.Size = new System.Drawing.Size(1019, 76);
            this.label_top.TabIndex = 0;
            this.label_top.Text = "РЕГИСТРАЦИЯ";
            this.label_top.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_top_MouseDown);
            this.label_top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_top_MouseMove);
            // 
            // autorization
            // 
            this.autorization.AutoSize = true;
            this.autorization.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.autorization.Cursor = System.Windows.Forms.Cursors.Hand;
            this.autorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.autorization.Location = new System.Drawing.Point(461, 148);
            this.autorization.Name = "autorization";
            this.autorization.Size = new System.Drawing.Size(108, 18);
            this.autorization.TabIndex = 7;
            this.autorization.Text = "Авторизация";
            this.autorization.Click += new System.EventHandler(this.autorization_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::Практика5.Properties.Resources.Password;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(375, 256);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Практика5.Properties.Resources.User;
            this.pictureBox1.Location = new System.Drawing.Point(375, 198);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // RegisterForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 525);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm1";
            this.Text = "RegisterForm1";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox password_register;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox login_register;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label label_top;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label CloseButton1;
        private System.Windows.Forms.Label autorization;
    }
}