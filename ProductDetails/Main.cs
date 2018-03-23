using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductDetails
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void ProductButton_Click(object sender, EventArgs e)
        {
            ProductDetails products = new ProductDetails();
            products.Show();
            Hide();
        }

        private void DatabaseButton_Click(object sender, EventArgs e)
        {
            DatabaseInfo db = new DatabaseInfo();
            db.Show();
            Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Confirmation.lastopen = this;
            this.Hide();
            Confirmation confirm = new Confirmation();
            confirm.Show();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            Hide();
        }
    }
}
