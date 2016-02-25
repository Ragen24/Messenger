namespace Test
{
    partial class SignIn
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
            this.Login_TextBox = new System.Windows.Forms.TextBox();
            this.Email_Lable = new System.Windows.Forms.Label();
            this.Password_Lable = new System.Windows.Forms.Label();
            this.Confirm_But = new System.Windows.Forms.Button();
            this.Back_But = new System.Windows.Forms.Button();
            this.Password_MTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Login_TextBox
            // 
            this.Login_TextBox.Location = new System.Drawing.Point(111, 49);
            this.Login_TextBox.Name = "Login_TextBox";
            this.Login_TextBox.Size = new System.Drawing.Size(119, 20);
            this.Login_TextBox.TabIndex = 0;
            // 
            // Email_Lable
            // 
            this.Email_Lable.Location = new System.Drawing.Point(53, 49);
            this.Email_Lable.Name = "Email_Lable";
            this.Email_Lable.Size = new System.Drawing.Size(52, 20);
            this.Email_Lable.TabIndex = 2;
            this.Email_Lable.Text = "Логин";
            // 
            // Password_Lable
            // 
            this.Password_Lable.Location = new System.Drawing.Point(53, 76);
            this.Password_Lable.Name = "Password_Lable";
            this.Password_Lable.Size = new System.Drawing.Size(52, 20);
            this.Password_Lable.TabIndex = 3;
            this.Password_Lable.Text = "Пароль";
            // 
            // Confirm_But
            // 
            this.Confirm_But.Location = new System.Drawing.Point(155, 116);
            this.Confirm_But.Name = "Confirm_But";
            this.Confirm_But.Size = new System.Drawing.Size(75, 23);
            this.Confirm_But.TabIndex = 4;
            this.Confirm_But.Text = "Войти";
            this.Confirm_But.UseVisualStyleBackColor = true;
            this.Confirm_But.Click += new System.EventHandler(this.Confirm_But_Click);
            // 
            // Back_But
            // 
            this.Back_But.Location = new System.Drawing.Point(56, 116);
            this.Back_But.Name = "Back_But";
            this.Back_But.Size = new System.Drawing.Size(75, 23);
            this.Back_But.TabIndex = 5;
            this.Back_But.Text = "Назад";
            this.Back_But.UseVisualStyleBackColor = true;
            this.Back_But.Click += new System.EventHandler(this.Back_But_Click);
            // 
            // Password_MTextBox
            // 
            this.Password_MTextBox.Location = new System.Drawing.Point(111, 75);
            this.Password_MTextBox.Name = "Password_MTextBox";
            this.Password_MTextBox.PasswordChar = '*';
            this.Password_MTextBox.Size = new System.Drawing.Size(119, 20);
            this.Password_MTextBox.TabIndex = 6;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 158);
            this.Controls.Add(this.Password_MTextBox);
            this.Controls.Add(this.Back_But);
            this.Controls.Add(this.Confirm_But);
            this.Controls.Add(this.Password_Lable);
            this.Controls.Add(this.Email_Lable);
            this.Controls.Add(this.Login_TextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Login_TextBox;
        private System.Windows.Forms.Label Email_Lable;
        private System.Windows.Forms.Label Password_Lable;
        private System.Windows.Forms.Button Confirm_But;
        private System.Windows.Forms.Button Back_But;
        private System.Windows.Forms.MaskedTextBox Password_MTextBox;
    }
}