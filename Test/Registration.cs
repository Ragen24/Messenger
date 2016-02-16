using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        // Проверка валидности вводимых данных
        private bool IsValid(string login, string name, string surname, string email, string password, string passwordConfirm)
        {
            // Регулярки для имени/фамилии, логина, пароля и Email.
            string patternName = @"^[а-яА-ЯёЁa-zA-Z]+$";
            string patternLogin = @"^[а-яА-ЯёЁa-zA-Z][а-яА-ЯёЁa-zA-Z0-9-_\.]{1,20}$";
            string patternPassword = @"^[a-zA-Z0-9]+$";
            string patternEmail = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
            // Переменные для проверки уникальности логина и Email'a.
            bool unicLog;
            bool unicEmail;

            // Проверка логина
            Match isMatch = Regex.Match(login, patternLogin, RegexOptions.IgnoreCase);
            if (!isMatch.Success)
            {
                MessageBox.Show("Логин должн содержать цифры и символы руского и/или латинского алфавита и начинаться с буквы.");
                Login_TextBox.Text = "";
                Login_TextBox.Focus();
                return false;
            }

            // Проверка логина на уникальность
            using (SqlConnection con = new SqlConnection("Data Source=RAGEN;Initial Catalog=Test;Integrated Security=True"))
            {
                con.Open();
                using (SqlCommand com = con.CreateCommand())
                {
                    com.CommandText = string.Format("SELECT * FROM Accounts WHERE Login = '{0}'", login);
                    com.CommandType = CommandType.Text;
                    SqlDataReader readerLog = com.ExecuteReader();
                    unicLog = readerLog.HasRows;
                    readerLog.Close();
                    com.CommandText = string.Format("SELECT * FROM Accounts WHERE Email = '{0}'", email);
                    com.CommandType = CommandType.Text;
                    SqlDataReader readerEmail = com.ExecuteReader();
                    unicEmail = readerEmail.HasRows;
                    readerEmail.Close();
                    com.ExecuteNonQuery();
                }
                con.Close();
            }

            if (unicLog)
            {
                MessageBox.Show("Такой логин уже используется.");
                Login_TextBox.Text = "";
                Login_TextBox.Focus();
                return false;
            }
            if (unicEmail)
            {
                MessageBox.Show("Такой Email уже используется.");
                Email_TextBox.Text = "";
                Email_TextBox.Focus();
                return false;
            }

            // Проверка именни
            isMatch = Regex.Match(name, patternName, RegexOptions.IgnoreCase);
            if (!isMatch.Success) 
            {
                MessageBox.Show("Имя должно содержать символы руского и/или латинского алфавита.");
                Name_TextBox.Text = "";
                Name_TextBox.Focus();
                return false;
            }
  
            // Проверка фамилии
            isMatch = Regex.Match(surname, patternName, RegexOptions.IgnoreCase);
            if (!isMatch.Success) 
            {
                MessageBox.Show("Фамилия должна содержать символы руского и/или латинского алфавита.");
                Surname_TextBox.Text = "";
                Surname_TextBox.Focus();
                return false;
            }

            // Проверка email
            isMatch = Regex.Match(email, patternEmail, RegexOptions.IgnoreCase);
            if (!isMatch.Success)
            {
                MessageBox.Show("Некорректный Email");
                Email_TextBox.Text = "";
                Email_TextBox.Focus();
                return false;
            }

            // Проверка пароля
            isMatch = Regex.Match(password, patternPassword, RegexOptions.IgnoreCase);
            if (!isMatch.Success)
            {
                MessageBox.Show("Пароль должен содержать цифры и символы латинского алфавита.");
                Password_MTextBox.Text = "";
                PasswordConfirm_MTextBox.Text = "";
                Password_MTextBox.Focus();
                return false;
            }

            // Проверка на соответствия пароля и подтверждения пароля
            if (password != passwordConfirm)
            {
                MessageBox.Show("Поля пароля и подтверждения пароля не совпадают.");
                Password_MTextBox.Text = "";
                PasswordConfirm_MTextBox.Text = "";
                Password_MTextBox.Focus();
                return false;
            }
            
            return true;
        }

        // Метод преведения имени и фамилии к нужному формату(первая буква в верхнем регистре, остальные в нижнем)
        public static string Capitalize(string text)
        {
            char[] v = text.ToCharArray();
            string s = v[0].ToString().ToUpper();
            for (int b = 1; b < v.Length; b++)
                s += v[b].ToString().ToLower();
            return s;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValid(Login_TextBox.Text, Name_TextBox.Text, Surname_TextBox.Text, Email_TextBox.Text, Password_MTextBox.Text, PasswordConfirm_MTextBox.Text) == false) return;
            using (SqlConnection con = new SqlConnection("Data Source=RAGEN;Initial Catalog=Test;Integrated Security=True"))
            {
                con.Open();
                using (SqlCommand com = con.CreateCommand())
                {

                    var login = Login_TextBox.Text;
                    var name = Name_TextBox.Text;
                    var surname = Surname_TextBox.Text;
                    name = Capitalize(name);
                    surname = Capitalize(surname);
                    var email = Email_TextBox.Text;
                    var password = Password_MTextBox.Text;
                    com.CommandText = string.Format("INSERT INTO Accounts(Login, Name, Surname, Email, Password, IncMessagesInd, SentMessagesInd) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', 0, 0)",
                                                    login, name, surname, email, password);
                    com.CommandType = CommandType.Text;
                    com.ExecuteNonQuery();
                }
                con.Close();
            }
            Close();

        }

        private void Registration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDataSet.Accounts' table. You can move, or remove it, as needed.
            this.accountsTableAdapter.Fill(this.testDataSet.Accounts);

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
