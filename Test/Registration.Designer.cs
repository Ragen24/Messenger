namespace Test
{
    partial class Registration
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
            this.Name_TextBox = new System.Windows.Forms.TextBox();
            this.Surname_TextBox = new System.Windows.Forms.TextBox();
            this.Email_TextBox = new System.Windows.Forms.TextBox();
            this.Confirm_But = new System.Windows.Forms.Button();
            this.Password_MTextBox = new System.Windows.Forms.MaskedTextBox();
            this.PasswordConfirm_MTextBox = new System.Windows.Forms.MaskedTextBox();
            this.Login_TextBox = new System.Windows.Forms.TextBox();
            this.Login_Lable = new System.Windows.Forms.Label();
            this.Name_Lable = new System.Windows.Forms.Label();
            this.Surname_Lable = new System.Windows.Forms.Label();
            this.Email_Lable = new System.Windows.Forms.Label();
            this.Password_Lable = new System.Windows.Forms.Label();
            this.PasswordConfirm_Lable = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incMessagesIndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sentMessagesIndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet = new Test.TestDataSet();
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountsTableAdapter = new Test.TestDataSetTableAdapters.AccountsTableAdapter();
            this.accountsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.Location = new System.Drawing.Point(306, 93);
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Name_TextBox.TabIndex = 1;
            // 
            // Surname_TextBox
            // 
            this.Surname_TextBox.Location = new System.Drawing.Point(306, 119);
            this.Surname_TextBox.Name = "Surname_TextBox";
            this.Surname_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Surname_TextBox.TabIndex = 2;
            // 
            // Email_TextBox
            // 
            this.Email_TextBox.Location = new System.Drawing.Point(306, 145);
            this.Email_TextBox.Name = "Email_TextBox";
            this.Email_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Email_TextBox.TabIndex = 3;
            // 
            // Confirm_But
            // 
            this.Confirm_But.Location = new System.Drawing.Point(306, 259);
            this.Confirm_But.Name = "Confirm_But";
            this.Confirm_But.Size = new System.Drawing.Size(100, 23);
            this.Confirm_But.TabIndex = 6;
            this.Confirm_But.Text = "Подтвердить";
            this.Confirm_But.UseVisualStyleBackColor = true;
            this.Confirm_But.Click += new System.EventHandler(this.button1_Click);
            // 
            // Password_MTextBox
            // 
            this.Password_MTextBox.Location = new System.Drawing.Point(306, 171);
            this.Password_MTextBox.Name = "Password_MTextBox";
            this.Password_MTextBox.PasswordChar = '*';
            this.Password_MTextBox.Size = new System.Drawing.Size(100, 20);
            this.Password_MTextBox.TabIndex = 4;
            // 
            // PasswordConfirm_MTextBox
            // 
            this.PasswordConfirm_MTextBox.Location = new System.Drawing.Point(306, 197);
            this.PasswordConfirm_MTextBox.Name = "PasswordConfirm_MTextBox";
            this.PasswordConfirm_MTextBox.PasswordChar = '*';
            this.PasswordConfirm_MTextBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordConfirm_MTextBox.TabIndex = 5;
            this.PasswordConfirm_MTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // Login_TextBox
            // 
            this.Login_TextBox.Location = new System.Drawing.Point(306, 67);
            this.Login_TextBox.Name = "Login_TextBox";
            this.Login_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Login_TextBox.TabIndex = 0;
            // 
            // Login_Lable
            // 
            this.Login_Lable.Location = new System.Drawing.Point(188, 67);
            this.Login_Lable.Name = "Login_Lable";
            this.Login_Lable.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.Login_Lable.Size = new System.Drawing.Size(100, 20);
            this.Login_Lable.TabIndex = 14;
            this.Login_Lable.Text = "Логин";
            // 
            // Name_Lable
            // 
            this.Name_Lable.Location = new System.Drawing.Point(188, 93);
            this.Name_Lable.Name = "Name_Lable";
            this.Name_Lable.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.Name_Lable.Size = new System.Drawing.Size(100, 20);
            this.Name_Lable.TabIndex = 15;
            this.Name_Lable.Text = "Имя";
            // 
            // Surname_Lable
            // 
            this.Surname_Lable.Location = new System.Drawing.Point(188, 119);
            this.Surname_Lable.Name = "Surname_Lable";
            this.Surname_Lable.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.Surname_Lable.Size = new System.Drawing.Size(100, 20);
            this.Surname_Lable.TabIndex = 16;
            this.Surname_Lable.Text = "Фамилия";
            // 
            // Email_Lable
            // 
            this.Email_Lable.Location = new System.Drawing.Point(188, 145);
            this.Email_Lable.Name = "Email_Lable";
            this.Email_Lable.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.Email_Lable.Size = new System.Drawing.Size(100, 20);
            this.Email_Lable.TabIndex = 17;
            this.Email_Lable.Text = "Email";
            // 
            // Password_Lable
            // 
            this.Password_Lable.Location = new System.Drawing.Point(188, 171);
            this.Password_Lable.Name = "Password_Lable";
            this.Password_Lable.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.Password_Lable.Size = new System.Drawing.Size(100, 20);
            this.Password_Lable.TabIndex = 18;
            this.Password_Lable.Text = "Пароль";
            // 
            // PasswordConfirm_Lable
            // 
            this.PasswordConfirm_Lable.Location = new System.Drawing.Point(188, 200);
            this.PasswordConfirm_Lable.Name = "PasswordConfirm_Lable";
            this.PasswordConfirm_Lable.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.PasswordConfirm_Lable.Size = new System.Drawing.Size(100, 30);
            this.PasswordConfirm_Lable.TabIndex = 19;
            this.PasswordConfirm_Lable.Text = "Подтверждение пароля";
            this.PasswordConfirm_Lable.Click += new System.EventHandler(this.label5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.incMessagesIndDataGridViewTextBoxColumn,
            this.sentMessagesIndDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.accountsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(499, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 20;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // incMessagesIndDataGridViewTextBoxColumn
            // 
            this.incMessagesIndDataGridViewTextBoxColumn.DataPropertyName = "IncMessagesInd";
            this.incMessagesIndDataGridViewTextBoxColumn.HeaderText = "IncMessagesInd";
            this.incMessagesIndDataGridViewTextBoxColumn.Name = "incMessagesIndDataGridViewTextBoxColumn";
            // 
            // sentMessagesIndDataGridViewTextBoxColumn
            // 
            this.sentMessagesIndDataGridViewTextBoxColumn.DataPropertyName = "SentMessagesInd";
            this.sentMessagesIndDataGridViewTextBoxColumn.HeaderText = "SentMessagesInd";
            this.sentMessagesIndDataGridViewTextBoxColumn.Name = "sentMessagesIndDataGridViewTextBoxColumn";
            // 
            // accountsBindingSource1
            // 
            this.accountsBindingSource1.DataMember = "Accounts";
            this.accountsBindingSource1.DataSource = this.testDataSet;
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
            // accountsBindingSource2
            // 
            this.accountsBindingSource2.DataMember = "Accounts";
            this.accountsBindingSource2.DataSource = this.testDataSet;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(814, 402);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PasswordConfirm_Lable);
            this.Controls.Add(this.Password_Lable);
            this.Controls.Add(this.Email_Lable);
            this.Controls.Add(this.Surname_Lable);
            this.Controls.Add(this.Name_Lable);
            this.Controls.Add(this.Login_Lable);
            this.Controls.Add(this.Login_TextBox);
            this.Controls.Add(this.PasswordConfirm_MTextBox);
            this.Controls.Add(this.Password_MTextBox);
            this.Controls.Add(this.Confirm_But);
            this.Controls.Add(this.Email_TextBox);
            this.Controls.Add(this.Surname_TextBox);
            this.Controls.Add(this.Name_TextBox);
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name_TextBox;
        private System.Windows.Forms.TextBox Surname_TextBox;
        private System.Windows.Forms.TextBox Email_TextBox;
        private System.Windows.Forms.Button Confirm_But;
        private TestDataSet testDataSet;
        private System.Windows.Forms.BindingSource accountsBindingSource;
        private TestDataSetTableAdapters.AccountsTableAdapter accountsTableAdapter;
        private System.Windows.Forms.MaskedTextBox Password_MTextBox;
        private System.Windows.Forms.MaskedTextBox PasswordConfirm_MTextBox;
        private System.Windows.Forms.BindingSource accountsBindingSource1;
        private System.Windows.Forms.TextBox Login_TextBox;
        private System.Windows.Forms.Label Login_Lable;
        private System.Windows.Forms.Label Name_Lable;
        private System.Windows.Forms.Label Surname_Lable;
        private System.Windows.Forms.Label Email_Lable;
        private System.Windows.Forms.Label Password_Lable;
        private System.Windows.Forms.Label PasswordConfirm_Lable;
        private System.Windows.Forms.BindingSource accountsBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incMessagesIndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sentMessagesIndDataGridViewTextBoxColumn;
    }
}