﻿namespace Test
{
    partial class LogIn
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
            this.Registration_But = new System.Windows.Forms.Button();
            this.SignIn_But = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Registration_But
            // 
            this.Registration_But.Location = new System.Drawing.Point(65, 91);
            this.Registration_But.Name = "Registration_But";
            this.Registration_But.Size = new System.Drawing.Size(100, 23);
            this.Registration_But.TabIndex = 1;
            this.Registration_But.Text = "Регистрация";
            this.Registration_But.UseVisualStyleBackColor = true;
            this.Registration_But.Click += new System.EventHandler(this.Registration_But_Click);
            // 
            // SignIn_But
            // 
            this.SignIn_But.Location = new System.Drawing.Point(65, 41);
            this.SignIn_But.Name = "SignIn_But";
            this.SignIn_But.Size = new System.Drawing.Size(100, 23);
            this.SignIn_But.TabIndex = 0;
            this.SignIn_But.Text = "Войти";
            this.SignIn_But.UseVisualStyleBackColor = true;
            this.SignIn_But.Click += new System.EventHandler(this.SignIn_But_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(65, 142);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(100, 23);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 210);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.SignIn_But);
            this.Controls.Add(this.Registration_But);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LogIn";
            this.Text = "Messanger";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Registration_But;
        private System.Windows.Forms.Button SignIn_But;
        private System.Windows.Forms.Button Exit;
    }
}

