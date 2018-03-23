namespace ProductDetails
{
    partial class ProductDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductDetails));
            this.BackButton = new System.Windows.Forms.Button();
            this.AccessDatabaseButton = new System.Windows.Forms.Button();
            this.OpenDB = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.DirectoryButton = new System.Windows.Forms.Button();
            this.DirectoryText = new System.Windows.Forms.TextBox();
            this.ProductCodeLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.VATLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.PriceValue = new System.Windows.Forms.NumericUpDown();
            this.VATText = new System.Windows.Forms.TextBox();
            this.DescriptionText = new System.Windows.Forms.RichTextBox();
            this.TotalText = new System.Windows.Forms.TextBox();
            this.ProductCodeText = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.EmptyFields = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.ClearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PriceValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(381, 220);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(47, 23);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AccessDatabaseButton
            // 
            this.AccessDatabaseButton.Location = new System.Drawing.Point(324, 39);
            this.AccessDatabaseButton.Name = "AccessDatabaseButton";
            this.AccessDatabaseButton.Size = new System.Drawing.Size(107, 23);
            this.AccessDatabaseButton.TabIndex = 1;
            this.AccessDatabaseButton.Text = "Query Database";
            this.AccessDatabaseButton.UseVisualStyleBackColor = true;
            this.AccessDatabaseButton.Click += new System.EventHandler(this.AccessDatabaseButton_Click);
            // 
            // OpenDB
            // 
            this.OpenDB.Location = new System.Drawing.Point(324, 12);
            this.OpenDB.Name = "OpenDB";
            this.OpenDB.Size = new System.Drawing.Size(107, 23);
            this.OpenDB.TabIndex = 3;
            this.OpenDB.Text = "Open Database";
            this.OpenDB.UseVisualStyleBackColor = true;
            this.OpenDB.Click += new System.EventHandler(this.OpenDB_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // DirectoryButton
            // 
            this.DirectoryButton.Location = new System.Drawing.Point(12, 217);
            this.DirectoryButton.Name = "DirectoryButton";
            this.DirectoryButton.Size = new System.Drawing.Size(20, 23);
            this.DirectoryButton.TabIndex = 4;
            this.DirectoryButton.Text = ":";
            this.DirectoryButton.UseVisualStyleBackColor = true;
            this.DirectoryButton.Click += new System.EventHandler(this.DirectoryButton_Click);
            // 
            // DirectoryText
            // 
            this.DirectoryText.Location = new System.Drawing.Point(37, 219);
            this.DirectoryText.Name = "DirectoryText";
            this.DirectoryText.ReadOnly = true;
            this.DirectoryText.Size = new System.Drawing.Size(164, 20);
            this.DirectoryText.TabIndex = 5;
            // 
            // ProductCodeLabel
            // 
            this.ProductCodeLabel.AutoSize = true;
            this.ProductCodeLabel.Location = new System.Drawing.Point(12, 12);
            this.ProductCodeLabel.Name = "ProductCodeLabel";
            this.ProductCodeLabel.Size = new System.Drawing.Size(72, 13);
            this.ProductCodeLabel.TabIndex = 6;
            this.ProductCodeLabel.Text = "Product Code";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(12, 41);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.DescriptionLabel.TabIndex = 7;
            this.DescriptionLabel.Text = "Description";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(15, 104);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(31, 13);
            this.PriceLabel.TabIndex = 8;
            this.PriceLabel.Text = "Price";
            // 
            // VATLabel
            // 
            this.VATLabel.AutoSize = true;
            this.VATLabel.Location = new System.Drawing.Point(15, 132);
            this.VATLabel.Name = "VATLabel";
            this.VATLabel.Size = new System.Drawing.Size(28, 13);
            this.VATLabel.TabIndex = 9;
            this.VATLabel.Text = "VAT";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(15, 159);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(31, 13);
            this.TotalLabel.TabIndex = 10;
            this.TotalLabel.Text = "Total";
            // 
            // PriceValue
            // 
            this.PriceValue.DecimalPlaces = 2;
            this.PriceValue.Location = new System.Drawing.Point(52, 104);
            this.PriceValue.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.PriceValue.Minimum = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.PriceValue.Name = "PriceValue";
            this.PriceValue.Size = new System.Drawing.Size(90, 20);
            this.PriceValue.TabIndex = 11;
            this.PriceValue.ThousandsSeparator = true;
            this.PriceValue.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // VATText
            // 
            this.VATText.Enabled = false;
            this.VATText.Location = new System.Drawing.Point(52, 132);
            this.VATText.Name = "VATText";
            this.VATText.ReadOnly = true;
            this.VATText.Size = new System.Drawing.Size(90, 20);
            this.VATText.TabIndex = 12;
            // 
            // DescriptionText
            // 
            this.DescriptionText.Location = new System.Drawing.Point(78, 41);
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.Size = new System.Drawing.Size(125, 55);
            this.DescriptionText.TabIndex = 13;
            this.DescriptionText.Text = "";
            // 
            // TotalText
            // 
            this.TotalText.Enabled = false;
            this.TotalText.Location = new System.Drawing.Point(52, 159);
            this.TotalText.Name = "TotalText";
            this.TotalText.ReadOnly = true;
            this.TotalText.Size = new System.Drawing.Size(90, 20);
            this.TotalText.TabIndex = 14;
            // 
            // ProductCodeText
            // 
            this.ProductCodeText.Location = new System.Drawing.Point(91, 12);
            this.ProductCodeText.Name = "ProductCodeText";
            this.ProductCodeText.Size = new System.Drawing.Size(100, 20);
            this.ProductCodeText.TabIndex = 15;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(37, 185);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 16;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // EmptyFields
            // 
            this.EmptyFields.AutoSize = true;
            this.EmptyFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmptyFields.ForeColor = System.Drawing.Color.Red;
            this.EmptyFields.Location = new System.Drawing.Point(300, 65);
            this.EmptyFields.Name = "EmptyFields";
            this.EmptyFields.Size = new System.Drawing.Size(128, 15);
            this.EmptyFields.TabIndex = 17;
            this.EmptyFields.Text = "There are empty fields";
            this.EmptyFields.Visible = false;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(160, 112);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(268, 96);
            this.pictureBox.TabIndex = 18;
            this.pictureBox.TabStop = false;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(336, 220);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(39, 23);
            this.ClearButton.TabIndex = 19;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(440, 250);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.EmptyFields);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.ProductCodeText);
            this.Controls.Add(this.TotalText);
            this.Controls.Add(this.DescriptionText);
            this.Controls.Add(this.VATText);
            this.Controls.Add(this.PriceValue);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.VATLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.ProductCodeLabel);
            this.Controls.Add(this.DirectoryText);
            this.Controls.Add(this.DirectoryButton);
            this.Controls.Add(this.OpenDB);
            this.Controls.Add(this.AccessDatabaseButton);
            this.Controls.Add(this.BackButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Register";
            ((System.ComponentModel.ISupportInitialize)(this.PriceValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button AccessDatabaseButton;
        private System.Windows.Forms.Button OpenDB;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button DirectoryButton;
        private System.Windows.Forms.TextBox DirectoryText;
        private System.Windows.Forms.Label ProductCodeLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label VATLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.NumericUpDown PriceValue;
        private System.Windows.Forms.TextBox VATText;
        private System.Windows.Forms.RichTextBox DescriptionText;
        private System.Windows.Forms.TextBox TotalText;
        private System.Windows.Forms.TextBox ProductCodeText;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label EmptyFields;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button ClearButton;
    }
}