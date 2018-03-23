namespace ProductDetails
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LoginButton = new System.Windows.Forms.Button();
            this.UsernameText = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.RequirmentError = new System.Windows.Forms.Label();
            this.TitleText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ShowPassword = new System.Windows.Forms.Button();
            this.ForgotPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(143, 82);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // UsernameText
            // 
            this.UsernameText.Location = new System.Drawing.Point(75, 56);
            this.UsernameText.Name = "UsernameText";
            this.UsernameText.Size = new System.Drawing.Size(100, 20);
            this.UsernameText.TabIndex = 1;
            this.UsernameText.Text = "Username";
            this.UsernameText.Enter += new System.EventHandler(this.UsernameText_Enter);
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(190, 56);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(100, 20);
            this.PasswordText.TabIndex = 2;
            this.PasswordText.Text = "Password";
            this.PasswordText.Enter += new System.EventHandler(this.PasswordText_Enter);
            // 
            // RequirmentError
            // 
            this.RequirmentError.AutoSize = true;
            this.RequirmentError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequirmentError.ForeColor = System.Drawing.Color.Red;
            this.RequirmentError.Location = new System.Drawing.Point(90, 115);
            this.RequirmentError.Name = "RequirmentError";
            this.RequirmentError.Size = new System.Drawing.Size(186, 16);
            this.RequirmentError.TabIndex = 3;
            this.RequirmentError.Text = "Incorrect login information";
            this.RequirmentError.Visible = false;
            // 
            // TitleText
            // 
            this.TitleText.AutoSize = true;
            this.TitleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TitleText.Location = new System.Drawing.Point(54, 20);
            this.TitleText.Name = "TitleText";
            this.TitleText.Size = new System.Drawing.Size(275, 24);
            this.TitleText.TabIndex = 4;
            this.TitleText.Text = "iTecCrawley Database Login";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(318, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShowPassword
            // 
            this.ShowPassword.BackColor = System.Drawing.Color.White;
            this.ShowPassword.Location = new System.Drawing.Point(270, 56);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(20, 20);
            this.ShowPassword.TabIndex = 6;
            this.ShowPassword.TabStop = false;
            this.ShowPassword.Text = "+";
            this.ShowPassword.UseVisualStyleBackColor = false;
            this.ShowPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShowPassword_MouseDown);
            this.ShowPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShowPassword_MouseUp);
            // 
            // ForgotPassword
            // 
            this.ForgotPassword.AutoSize = true;
            this.ForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgotPassword.ForeColor = System.Drawing.Color.Blue;
            this.ForgotPassword.Location = new System.Drawing.Point(3, 141);
            this.ForgotPassword.Name = "ForgotPassword";
            this.ForgotPassword.Size = new System.Drawing.Size(128, 16);
            this.ForgotPassword.TabIndex = 7;
            this.ForgotPassword.Text = "Forgotten Password";
            this.ForgotPassword.Click += new System.EventHandler(this.ForgotPassword_Click);
            this.ForgotPassword.MouseHover += new System.EventHandler(this.ForgotPassword_MouseHover);
            // 
            // Login
            // 
            this.AcceptButton = this.LoginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(370, 159);
            this.Controls.Add(this.ForgotPassword);
            this.Controls.Add(this.ShowPassword);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TitleText);
            this.Controls.Add(this.RequirmentError);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.UsernameText);
            this.Controls.Add(this.LoginButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox UsernameText;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.Label RequirmentError;
        private System.Windows.Forms.Label TitleText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ShowPassword;
        private System.Windows.Forms.Label ForgotPassword;
    }
}

