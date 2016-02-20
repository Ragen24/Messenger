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
            this.components = new System.ComponentModel.Container();
            this.Name_Lable = new System.Windows.Forms.Label();
            this.Email_Lable = new System.Windows.Forms.Label();
            this.ChangeUser_But = new System.Windows.Forms.Button();
            this.Exit_But = new System.Windows.Forms.Button();
            this.testDataSet = new Test.TestDataSet();
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountsTableAdapter = new Test.TestDataSetTableAdapters.AccountsTableAdapter();
            this.D = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.testDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.accountsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.messagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.messagesTableAdapter = new Test.TestDataSetTableAdapters.MessagesTableAdapter();
            this.WriteMessage_But = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            this.D.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Name_Lable
            // 
            this.Name_Lable.AutoSize = true;
            this.Name_Lable.Location = new System.Drawing.Point(693, 22);
            this.Name_Lable.Name = "Name_Lable";
            this.Name_Lable.Size = new System.Drawing.Size(60, 13);
            this.Name_Lable.TabIndex = 0;
            this.Name_Lable.Text = "User Name";
            this.Name_Lable.Click += new System.EventHandler(this.Name_Lable_Click);
            // 
            // Email_Lable
            // 
            this.Email_Lable.AutoSize = true;
            this.Email_Lable.Location = new System.Drawing.Point(693, 47);
            this.Email_Lable.Name = "Email_Lable";
            this.Email_Lable.Size = new System.Drawing.Size(57, 13);
            this.Email_Lable.TabIndex = 1;
            this.Email_Lable.Text = "User Email";
            this.Email_Lable.Click += new System.EventHandler(this.Email_Lable_Click);
            // 
            // ChangeUser_But
            // 
            this.ChangeUser_But.Location = new System.Drawing.Point(790, 72);
            this.ChangeUser_But.Name = "ChangeUser_But";
            this.ChangeUser_But.Size = new System.Drawing.Size(75, 23);
            this.ChangeUser_But.TabIndex = 2;
            this.ChangeUser_But.Text = "button1";
            this.ChangeUser_But.UseVisualStyleBackColor = true;
            this.ChangeUser_But.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exit_But
            // 
            this.Exit_But.Location = new System.Drawing.Point(790, 102);
            this.Exit_But.Name = "Exit_But";
            this.Exit_But.Size = new System.Drawing.Size(75, 23);
            this.Exit_But.TabIndex = 3;
            this.Exit_But.Text = "button2";
            this.Exit_But.UseVisualStyleBackColor = true;
            this.Exit_But.Click += new System.EventHandler(this.button2_Click);
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "TestDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountsBindingSource
            // 
            this.accountsBindingSource.DataMember = "Accounts";
            this.accountsBindingSource.DataSource = this.testDataSet;
            // 
            // accountsTableAdapter
            // 
            this.accountsTableAdapter.ClearBeforeFill = true;
            // 
            // D
            // 
            this.D.Controls.Add(this.tabPage1);
            this.D.Controls.Add(this.tabPage2);
            this.D.Location = new System.Drawing.Point(33, 102);
            this.D.Multiline = true;
            this.D.Name = "D";
            this.D.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.D.SelectedIndex = 0;
            this.D.Size = new System.Drawing.Size(739, 393);
            this.D.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(731, 367);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Входящие";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.messagesBindingSource, "Header", true));
            this.listBox1.DataSource = this.messagesBindingSource;
            this.listBox1.DisplayMember = "Message_id";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(731, 368);
            this.listBox1.TabIndex = 0;
            this.listBox1.ValueMember = "Header";
            // 
            // testDataSetBindingSource
            // 
            this.testDataSetBindingSource.DataSource = this.testDataSet;
            this.testDataSetBindingSource.Position = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(731, 374);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Отправленные";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // accountsBindingSource1
            // 
            this.accountsBindingSource1.DataMember = "Accounts";
            this.accountsBindingSource1.DataSource = this.testDataSet;
            // 
            // messagesBindingSource
            // 
            this.messagesBindingSource.DataMember = "Messages";
            this.messagesBindingSource.DataSource = this.testDataSetBindingSource;
            // 
            // messagesTableAdapter
            // 
            this.messagesTableAdapter.ClearBeforeFill = true;
            // 
            // WriteMessage_But
            // 
            this.WriteMessage_But.Location = new System.Drawing.Point(33, 42);
            this.WriteMessage_But.Name = "WriteMessage_But";
            this.WriteMessage_But.Size = new System.Drawing.Size(75, 23);
            this.WriteMessage_But.TabIndex = 5;
            this.WriteMessage_But.Text = "Написать";
            this.WriteMessage_But.UseVisualStyleBackColor = true;
            this.WriteMessage_But.Click += new System.EventHandler(this.WriteMessage_But_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 540);
            this.Controls.Add(this.WriteMessage_But);
            this.Controls.Add(this.D);
            this.Controls.Add(this.Exit_But);
            this.Controls.Add(this.ChangeUser_But);
            this.Controls.Add(this.Email_Lable);
            this.Controls.Add(this.Name_Lable);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            this.D.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.testDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name_Lable;
        private System.Windows.Forms.Label Email_Lable;
        private System.Windows.Forms.Button ChangeUser_But;
        private System.Windows.Forms.Button Exit_But;
        private TestDataSet testDataSet;
        private System.Windows.Forms.BindingSource accountsBindingSource;
        private TestDataSetTableAdapters.AccountsTableAdapter accountsTableAdapter;
        private System.Windows.Forms.TabControl D;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource testDataSetBindingSource;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingSource accountsBindingSource1;
        private System.Windows.Forms.BindingSource messagesBindingSource;
        private TestDataSetTableAdapters.MessagesTableAdapter messagesTableAdapter;
        private System.Windows.Forms.Button WriteMessage_But;
    }
}