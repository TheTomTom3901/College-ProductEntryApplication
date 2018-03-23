namespace ProductDetails
{
    partial class DatabaseInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseInfo));
            this.DataButton = new System.Windows.Forms.Button();
            this.DatabaseOutput = new System.Windows.Forms.DataGridView();
            this.BackButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.DirectoryButton = new System.Windows.Forms.Button();
            this.DirectoryText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // DataButton
            // 
            this.DataButton.Location = new System.Drawing.Point(555, 279);
            this.DataButton.Name = "DataButton";
            this.DataButton.Size = new System.Drawing.Size(75, 23);
            this.DataButton.TabIndex = 0;
            this.DataButton.Text = "Show Data";
            this.DataButton.UseVisualStyleBackColor = true;
            this.DataButton.Click += new System.EventHandler(this.DataButton_Click);
            // 
            // DatabaseOutput
            // 
            this.DatabaseOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatabaseOutput.Location = new System.Drawing.Point(23, 12);
            this.DatabaseOutput.Name = "DatabaseOutput";
            this.DatabaseOutput.Size = new System.Drawing.Size(644, 261);
            this.DatabaseOutput.TabIndex = 1;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(636, 279);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(45, 23);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // DirectoryButton
            // 
            this.DirectoryButton.Location = new System.Drawing.Point(118, 280);
            this.DirectoryButton.Name = "DirectoryButton";
            this.DirectoryButton.Size = new System.Drawing.Size(23, 23);
            this.DirectoryButton.TabIndex = 3;
            this.DirectoryButton.Text = ":";
            this.DirectoryButton.UseVisualStyleBackColor = true;
            this.DirectoryButton.Click += new System.EventHandler(this.DirectoryButton_Click);
            // 
            // DirectoryText
            // 
            this.DirectoryText.Location = new System.Drawing.Point(12, 282);
            this.DirectoryText.Name = "DirectoryText";
            this.DirectoryText.ReadOnly = true;
            this.DirectoryText.Size = new System.Drawing.Size(100, 20);
            this.DirectoryText.TabIndex = 4;
            // 
            // DatabaseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(693, 307);
            this.Controls.Add(this.DirectoryText);
            this.Controls.Add(this.DirectoryButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.DatabaseOutput);
            this.Controls.Add(this.DataButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DatabaseInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Queries";
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DataButton;
        private System.Windows.Forms.DataGridView DatabaseOutput;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button DirectoryButton;
        private System.Windows.Forms.TextBox DirectoryText;
    }
}