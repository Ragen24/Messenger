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
                    //int senderId = MainData.userID;
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
                    com.CommandText = string.Format("INSERT INTO Messages(Sender_id, Recipient_id, Header, Text, Date) VALUES('{0}', '{1}', '{2}', '{3}', '{4}')",
                                                    MainData.userID, recipId, header, messageText, GetDateWithoutMilliseconds(DateTime.Now));
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
            Close();
        }

        private String GetDateWithoutMilliseconds(DateTime d)
        {

            string z = (d.Year + "-" + d.Month + "-" + d.Day + " " + d.Hour + ":" + d.Minute + ":" + d.Second);
            MessageBox.Show(z);
            return z;
        }
    }
}
