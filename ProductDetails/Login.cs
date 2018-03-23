using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductDetails
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(UsernameText.Text == "iTecCrawley" && PasswordText.Text == "admin")
            {
                this.Hide();
                Main main = new Main();
                main.Show();
            }
            else
            {
                RequirmentError.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Confirmation.lastopen = this;
            this.Hide();
            Confirmation confirm = new Confirmation();
            confirm.Show();
        }

        private void PasswordText_Enter(object sender, EventArgs e)
        {
            RequirmentError.Hide();
            if (PasswordText.Text == "Password")
            {
                PasswordText.Clear();
                PasswordText.UseSystemPasswordChar = true;
            }
        }

        private void UsernameText_Enter(object sender, EventArgs e)
        {
            RequirmentError.Hide();
            if (UsernameText.Text == "Username")
            {
                UsernameText.Clear();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            ShowPassword.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void ShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            if (PasswordText.Text != "Password")
            {
                PasswordText.UseSystemPasswordChar = false;
            }
        }

        private void ShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            if (PasswordText.Text != "Password")
            {
                PasswordText.UseSystemPasswordChar = true;
            }
        }

        private void ForgotPassword_MouseHover(object sender, EventArgs e)
        {
            ForgotPassword.Cursor = Cursors.Hand;
        }

        private void ForgotPassword_Click(object sender, EventArgs e)
        {
            Process.Start("https://thetomtom3901.github.io/");
        }
    }
}
