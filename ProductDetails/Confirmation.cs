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
    public partial class Confirmation : Form
    {
        public Confirmation()
        {
            InitializeComponent();
        }

        public static Form lastopen;

        private void YesBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void NoBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            lastopen.Show();
        }
    }
}
