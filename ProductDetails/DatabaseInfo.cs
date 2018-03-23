using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductDetails
{
    public partial class DatabaseInfo : Form
    {
        public DatabaseInfo()
        {
            InitializeComponent();
        }

        private string directory;

        private void DataButton_Click(object sender, EventArgs e)
        {
            directory = DirectoryText.Text;
            if (directory != "") {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + directory);
                OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM ProductDetails", con);
                con.Open();
                DataSet dtSet = new DataSet();
                adapter.Fill(dtSet, "ProductDetails");
                DataTable dTable = dtSet.Tables[0];
                DatabaseOutput.DataSource = dtSet.Tables["ProductDetails"].DefaultView;
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT Description from ProductDetails";
                con.Close();
            }
            else
            {
                MessageBox.Show("No database has been selected");
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if(openFileDialog1.FileName.EndsWith(".accdb"))
            {
                directory = openFileDialog1.FileName;
                DirectoryText.Text = directory;
            }
            else
            {
                MessageBox.Show("Selected file is not .accdb");
                e.Cancel = true;
            }
        }

        private void DirectoryButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Hide();
        }
    }
}
