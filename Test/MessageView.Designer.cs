namespace Test
{
    partial class MessageView
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
            this.SenderName_Lable = new System.Windows.Forms.Label();
            this.RecipientName_Lable = new System.Windows.Forms.Label();
            this.Text_Lable = new System.Windows.Forms.Label();
            this.Header_Lable = new System.Windows.Forms.Label();
            this.Reply_But = new System.Windows.Forms.Button();
            this.Date_Lable = new System.Windows.Forms.Label();
            this.DeleteMsg_But = new System.Windows.Forms.Button();
            this.Back_But = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SenderName_Lable
            // 
            this.SenderName_Lable.AutoSize = true;
            this.SenderName_Lable.Location = new System.Drawing.Point(22, 33);
            this.SenderName_Lable.Name = "SenderName_Lable";
            this.SenderName_Lable.Size = new System.Drawing.Size(49, 13);
            this.SenderName_Lable.TabIndex = 0;
            this.SenderName_Lable.Text = "От кого:";
            // 
            // RecipientName_Lable
            // 
            this.RecipientName_Lable.AutoSize = true;
            this.RecipientName_Lable.Location = new System.Drawing.Point(22, 56);
            this.RecipientName_Lable.Name = "RecipientName_Lable";
            this.RecipientName_Lable.Size = new System.Drawing.Size(36, 13);
            this.RecipientName_Lable.TabIndex = 1;
            this.RecipientName_Lable.Text = "Кому:";
            // 
            // Text_Lable
            // 
            this.Text_Lable.Location = new System.Drawing.Point(22, 102);
            this.Text_Lable.Name = "Text_Lable";
            this.Text_Lable.Size = new System.Drawing.Size(800, 352);
            this.Text_Lable.TabIndex = 2;
            this.Text_Lable.Text = "Текст";
            // 
            // Header_Lable
            // 
            this.Header_Lable.AutoSize = true;
            this.Header_Lable.Location = new System.Drawing.Point(22, 79);
            this.Header_Lable.Name = "Header_Lable";
            this.Header_Lable.Size = new System.Drawing.Size(61, 13);
            this.Header_Lable.TabIndex = 3;
            this.Header_Lable.Text = "Заголовок";
            // 
            // Reply_But
            // 
            this.Reply_But.Location = new System.Drawing.Point(750, 472);
            this.Reply_But.Name = "Reply_But";
            this.Reply_But.Size = new System.Drawing.Size(75, 23);
            this.Reply_But.TabIndex = 4;
            this.Reply_But.Text = "Ответить";
            this.Reply_But.UseVisualStyleBackColor = true;
            this.Reply_But.Click += new System.EventHandler(this.Reply_But_Click);
            // 
            // Date_Lable
            // 
            this.Date_Lable.AutoSize = true;
            this.Date_Lable.Location = new System.Drawing.Point(25, 472);
            this.Date_Lable.Name = "Date_Lable";
            this.Date_Lable.Size = new System.Drawing.Size(33, 13);
            this.Date_Lable.TabIndex = 5;
            this.Date_Lable.Text = "Дата";
            // 
            // DeleteMsg_But
            // 
            this.DeleteMsg_But.Location = new System.Drawing.Point(648, 472);
            this.DeleteMsg_But.Name = "DeleteMsg_But";
            this.DeleteMsg_But.Size = new System.Drawing.Size(75, 23);
            this.DeleteMsg_But.TabIndex = 6;
            this.DeleteMsg_But.Text = "Удалить";
            this.DeleteMsg_But.UseVisualStyleBackColor = true;
            this.DeleteMsg_But.Click += new System.EventHandler(this.DeleteMsg_But_Click);
            // 
            // Back_But
            // 
            this.Back_But.Location = new System.Drawing.Point(538, 472);
            this.Back_But.Name = "Back_But";
            this.Back_But.Size = new System.Drawing.Size(75, 23);
            this.Back_But.TabIndex = 7;
            this.Back_But.Text = "Назад";
            this.Back_But.UseVisualStyleBackColor = true;
            // 
            // MessageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 511);
            this.Controls.Add(this.Back_But);
            this.Controls.Add(this.DeleteMsg_But);
            this.Controls.Add(this.Date_Lable);
            this.Controls.Add(this.Reply_But);
            this.Controls.Add(this.Header_Lable);
            this.Controls.Add(this.Text_Lable);
            this.Controls.Add(this.RecipientName_Lable);
            this.Controls.Add(this.SenderName_Lable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MessageView";
            this.Text = "MessageView";
            this.Load += new System.EventHandler(this.MessageView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SenderName_Lable;
        private System.Windows.Forms.Label RecipientName_Lable;
        private System.Windows.Forms.Label Text_Lable;
        private System.Windows.Forms.Label Header_Lable;
        private System.Windows.Forms.Button Reply_But;
        private System.Windows.Forms.Label Date_Lable;
        private System.Windows.Forms.Button DeleteMsg_But;
        private System.Windows.Forms.Button Back_But;
    }
}