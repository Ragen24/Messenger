namespace Test
{
    partial class MainForm
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
            this.SuspendLayout();
            // 
            // Registration_But
            // 
            this.Registration_But.Location = new System.Drawing.Point(30, 378);
            this.Registration_But.Name = "Registration_But";
            this.Registration_But.Size = new System.Drawing.Size(100, 23);
            this.Registration_But.TabIndex = 0;
            this.Registration_But.Text = "Регистрация";
            this.Registration_But.UseVisualStyleBackColor = true;
            this.Registration_But.Click += new System.EventHandler(this.Registration_But_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 425);
            this.Controls.Add(this.Registration_But);
            this.Name = "MainForm";
            this.Text = "Messanger";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Registration_But;
    }
}

