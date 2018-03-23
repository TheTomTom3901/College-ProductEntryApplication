using System;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProductDetails
{
    public partial class ProductDetails : Form
    {
        public ProductDetails()
        {
            InitializeComponent();
        }

        private string directory;
        private string code;
        private string description;
        private double price;
        private double vat;
        private double total;

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            code = ProductCodeText.Text;
            description = DescriptionText.Text;
            price = (double)PriceValue.Value;
            vat = price * 0.2;
            VATText.Text = "£" + vat.ToString();
            total = price + vat;
            TotalText.Text = "£" + total.ToString();
        }

        private void AccessDatabaseButton_Click(object sender, EventArgs e)
        {
            if(DirectoryText.Text != "")
            {
                if (ProductCodeText.Text != "" && DescriptionText.Text != "" && VATText.Text != "" && TotalText.Text != "")
                {
                    OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + directory);
                    OleDbCommand cmd = con.CreateCommand();
                    con.Open();
                    cmd.CommandText = "Insert into ProductDetails(Code,Description,Price,VAT,Total)Values('" + code + "','" + description + "','" + price + "','" + vat + "','" + total + "')";
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Database entry added with product code " + code, "Database updated successfully");
                    con.Close();
                }
                else
                {
                    EmptyFields.Show();
                }
            }
            else
            {
                MessageBox.Show("No database has been selected");
            }
        }

        private void OpenDB_Click(object sender, EventArgs e)
        {
            if(DirectoryText.Text != "")
            {
                Process.Start(directory);
            }
            else
            {
                MessageBox.Show("No database has been selected");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ProductCodeText.Clear();
            DescriptionText.Clear();
            PriceValue.Value = 75;
            VATText.Clear();
            TotalText.Clear();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (openFileDialog1.FileName.EndsWith(".accdb"))
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

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            Hide();
        }
    }
}
