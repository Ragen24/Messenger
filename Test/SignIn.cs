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
            int accIndex = -1;
            using (SqlConnection con = new SqlConnection("Data Source=RAGEN;Initial Catalog=Test;Integrated Security=True"))
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
                        accIndex = reader.GetInt32(0);
                    }
                    reader.Close();
                    com.ExecuteNonQuery();

                    MainData.userID = accIndex;               
                }
                con.Close();
            }

            return true;
        }

        private void Confirm_But_Click(object sender, EventArgs e)
        {
            if (IsValid(Login_TextBox.Text, Password_MTextBox.Text) == false) return;

            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
            /*using (SqlConnection con = new SqlConnection("Data Source=RAGEN;Initial Catalog=Test;Integrated Security=True"))
            {
                con.Open();
                using (SqlCommand com = con.CreateCommand())
                {
                    com.CommandText = string.Format("SELECT * FROM Accounts WHERE Login = '{0}'", login);
                    com.CommandType = CommandType.Text;
                    SqlDataReader readerLog = com.ExecuteReader();
                    //unicLog = readerLog.HasRows;
                    readerLog.Close();
                    com.CommandText = string.Format("SELECT * FROM Accounts WHERE Email = '{0}'", email);
                    com.CommandType = CommandType.Text;
                    SqlDataReader readerEmail = com.ExecuteReader();
                    //unicEmail = readerEmail.HasRows;
                    readerEmail.Close();
                    com.ExecuteNonQuery();
                }
                con.Close();
            }*/
        }
    }
}
