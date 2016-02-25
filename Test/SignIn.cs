using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private bool IsValid(string login, string password)
        {
            MainData.userID = -1;
            // Проверка на наличие такой пары логин/пароль в БД
            using (SqlConnection con = new SqlConnection("Data Source=192.168.1.65,1433;Initial Catalog=Test;User ID=Ragen; Password=utg1df25fu"))
            {
                con.Open();
                using (SqlCommand com = con.CreateCommand())
                {
                    com.CommandText = string.Format("SELECT ID FROM Accounts WHERE Login = '{0}' AND Password = '{1}'",
                                                   login, password);
                    com.CommandType = CommandType.Text;
                    SqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        MainData.userID = reader.GetInt32(0);
                    }
                    reader.Close();
                    com.ExecuteNonQuery();           
                }
                con.Close();               
            }
            if (MainData.userID == -1)
            {
                MessageBox.Show("Логин или пароль введены неверно");
                Login_TextBox.Focus();
                Password_MTextBox.Text = "";
                return false;
            }
            // Введен ли логин
            if (Login_TextBox.Text == "")
            {
                MessageBox.Show("Введите логин");
                Login_TextBox.Focus();
                return false;
            }
            // Введен ли пароль
            if (Password_MTextBox.Text == "")
            {
                MessageBox.Show("Введите пароль");
                Password_MTextBox.Focus();
                return false;
            }

            return true;
        }

        private void Confirm_But_Click(object sender, EventArgs e)
        {
            // Проверка валидности
            if (IsValid(Login_TextBox.Text, Password_MTextBox.Text) == false) return;

            // Открытие главной формы
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
     
        }

        private void Back_But_Click(object sender, EventArgs e)
        {
            LogIn.classLogIn.Show();
            this.Close();
        }
    }
}
