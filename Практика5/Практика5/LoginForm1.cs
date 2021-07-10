using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика5
{
    public partial class LoginForm1 : Form
    {
        public LoginForm1()
        {
            InitializeComponent();

            this.password_autorization.AutoSize = false;
            this.password_autorization.Size = new Size(this.password_autorization.Width, 44);
            
            this.login_autorization.AutoSize = false;
            this.login_autorization.Size = new Size(this.login_autorization.Width, 44);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point LastPoint;
        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.X;
            }
        }
        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void Label_Top_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.X;
            }
        }
        private void Label_Top_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {

            DB db = new DB();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users1` WHERE 'login' = @login AND 'password' = @password", db.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login_autorization.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password_autorization.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                MainForm1 mainform1 = new MainForm1();
                mainform1.Show();
            }
            else
               MessageBox.Show("No"); 
            
        }

        private void register_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm1 registerform1 = new RegisterForm1();
            registerform1.Show();
        }
    }
}

