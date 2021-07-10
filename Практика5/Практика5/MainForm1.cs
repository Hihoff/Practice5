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
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm1 loginform1 = new LoginForm1();
            loginform1.Show();
        }

        private void Autorization_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm1 registerform1 = new RegisterForm1();
            registerform1.Show();
        }
    }
}
