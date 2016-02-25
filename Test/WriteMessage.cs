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
    public partial class WriteMessage : Form
    {
        public WriteMessage()
        {
            InitializeComponent();
        }

        private bool IsValid(string login, string name, string surname, string email, string password, string passwordConfirm)
        {
            if (RecipName_TextBox.Text == "")
            {
                MessageBox.Show("Введите логин получателя");
                RecipName_TextBox.Focus();
                return false;
            }

            if (Header_TextBox.Text == "")
            {
                MessageBox.Show("Введите заголовок сообщения");
                Header_TextBox.Focus();
                return false;
            }

            if (Message_TextBox.Text == "")
            {
                MessageBox.Show("Введите сообщение");
                Message_TextBox.Focus();
                return false;
            }


            return true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=RAGEN;Initial Catalog=Test;Integrated Security=True"))
            {
                con.Open();
                using (SqlCommand com = con.CreateCommand())
                {
                    int recipId = -1;
                    var recipLogin = RecipName_TextBox.Text;
                    var header = Header_TextBox.Text;
                    var messageText = Message_TextBox.Text;
                    com.CommandText = string.Format("SELECT ID FROM Accounts WHERE Login = '{0}'",
                                                   recipLogin);
                    com.CommandType = CommandType.Text;
                    SqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        recipId = reader.GetInt32(0);
                    }
                    reader.Close();

                    com.ExecuteNonQuery();
                    if (recipId == -1)
                    {
                        MessageBox.Show("Пользователь с таким логином не существует");
                        RecipName_TextBox.Text = "";
                        RecipName_TextBox.Focus();
                        con.Close();
                        return;
                    }

                    
                    com.CommandText = string.Format("INSERT INTO Messages(Sender_id, Recipient_id, Header, Text, Date) VALUES('{0}', '{1}', '{2}', '{3}', '{4}')",
                                                    MainData.userID, recipId, header, messageText, MainData.GetDateWithoutMilliseconds(DateTime.Now));
                    com.CommandType = CommandType.Text;
                    com.ExecuteNonQuery();
                    ///
                    com.CommandText = string.Format("UPDATE Accounts SET IncMessagesInd = IncMessagesInd + 1 WHERE ID = '{0}'",
                                                   recipId);
                    com.CommandType = CommandType.Text;
                    com.ExecuteNonQuery();

                    com.CommandText = string.Format("UPDATE Accounts SET SentMessagesInd = SentMessagesInd + 1 WHERE ID = '{0}'",
                                                   MainData.userID);
                    com.CommandType = CommandType.Text;
                    
                    com.ExecuteNonQuery();
                }
                con.Close();
            }
            MainForm.classMainForm.RefreshSent();

            this.Close();
        }

        private void WriteMessage_Load(object sender, EventArgs e)
        {
            if (MainData.reply)
            {
                string recipLogin = "";
                using (SqlConnection con = new SqlConnection("Data Source=RAGEN;Initial Catalog=Test;Integrated Security=True"))
                {
                    con.Open();
                    using (SqlCommand com = con.CreateCommand())
                    {
                        // Имя и фамилия отправителя.
                        com.CommandText = string.Format("SELECT Login FROM Accounts WHERE ID = '{0}'",
                                                        MainData.replyId);
                        com.CommandType = CommandType.Text;
                        SqlDataReader reader = com.ExecuteReader();
                        while (reader.Read())
                        {
                            recipLogin = reader.GetString(0);
                        }
                        reader.Close();
                    }
                    con.Close();
                }

                RecipName_TextBox.Text = recipLogin;
                MainData.replyId = -1;
                MainData.reply = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
