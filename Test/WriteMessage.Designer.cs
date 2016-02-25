namespace Test
{
    partial class WriteMessage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Message_TextBox = new System.Windows.Forms.TextBox();
            this.RecipName_TextBox = new System.Windows.Forms.TextBox();
            this.Header_TextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Кому";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Заголовок";
            // 
            // Message_TextBox
            // 
            this.Message_TextBox.Location = new System.Drawing.Point(25, 79);
            this.Message_TextBox.Multiline = true;
            this.Message_TextBox.Name = "Message_TextBox";
            this.Message_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Message_TextBox.Size = new System.Drawing.Size(800, 378);
            this.Message_TextBox.TabIndex = 2;
            // 
            // RecipName_TextBox
            // 
            this.RecipName_TextBox.Location = new System.Drawing.Point(89, 30);
            this.RecipName_TextBox.Name = "RecipName_TextBox";
            this.RecipName_TextBox.Size = new System.Drawing.Size(736, 20);
            this.RecipName_TextBox.TabIndex = 0;
            // 
            // Header_TextBox
            // 
            this.Header_TextBox.Location = new System.Drawing.Point(89, 53);
            this.Header_TextBox.Name = "Header_TextBox";
            this.Header_TextBox.Size = new System.Drawing.Size(736, 20);
            this.Header_TextBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(750, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Отправить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(664, 472);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // WriteMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 511);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Header_TextBox);
            this.Controls.Add(this.RecipName_TextBox);
            this.Controls.Add(this.Message_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "WriteMessage";
            this.Text = "WriteMessage";
            this.Load += new System.EventHandler(this.WriteMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Message_TextBox;
        private System.Windows.Forms.TextBox RecipName_TextBox;
        private System.Windows.Forms.TextBox Header_TextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}