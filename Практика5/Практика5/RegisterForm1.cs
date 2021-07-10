using MySql.Data.MySqlClient;
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
    public partial class RegisterForm1 : Form
    {
        public RegisterForm1()
        {
            InitializeComponent();

            login_register.Text = "Введите логин";
        }
        private void CloseButton1_Click(object sender, EventArgs e)
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

        private void label_top_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.X;
            }
        }

        private void label_top_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void login_register_Enter(object sender, EventArgs e)
        {
            if (login_register.Text == "Введите логин")
                login_register.Text = "";
        }

        private void login_register_Leave(object sender, EventArgs e)
        {
            if (login_register.Text == "")
                login_register.Text = "Введите логин";
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if(login_register.Text == "Введите логин")
            {
                MessageBox.Show("Введите данные");
                return;
            }

            if (CheckUser())
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users1` (`login`, `password`) VALUES (@login1, @password1)", db.getConnection());

            command.Parameters.Add("@login1", MySqlDbType.VarChar).Value = login_register.Text;
            command.Parameters.Add("@password1", MySqlDbType.VarChar).Value = password_register.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт был создан");
            else
                MessageBox.Show("Аккаунт не был создан");

            db.closeConnection();
        }
        public Boolean CheckUser()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users1` WHERE 'login' = @login", db.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login_register.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("такой логин уже есть, введите другой");
                return true;
            }
            else
                return false;
        }

        private void autorization_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm1 loginform1 = new LoginForm1();
            loginform1.Show();
        }
    }
}
