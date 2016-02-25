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
    public partial class MessageView : Form
    {
        public MessageView()
        {
            InitializeComponent();
        }

        private void Reply_But_Click(object sender, EventArgs e)
        {
            if (MainData.messageType == 0)
                MainData.replyId = MainForm.classMainForm.messages[MainData.messageType][MainData.selectedMessage].recipient_id;
            else if (MainData.messageType == 1)
                MainData.replyId = MainForm.classMainForm.messages[MainData.messageType][MainData.selectedMessage].sender_id;
            MainData.reply = true;
            WriteMessage writeMessageForm = new WriteMessage();
            this.Close();
            writeMessageForm.ShowDialog();
        }

        private void MessageView_Load(object sender, EventArgs e)
        {
            string senderName = "";
            string senderSurname = "";
            string recipientName = "";
            string recipientSurname = "";

            using (SqlConnection con = new SqlConnection("Data Source=RAGEN;Initial Catalog=Test;Integrated Security=True"))
            {
                con.Open();
                using (SqlCommand com = con.CreateCommand())
                {
                    // Имя и фамилия отправителя.
                    com.CommandText = string.Format("SELECT Name, Surname FROM Accounts WHERE ID = '{0}'",
                                                    MainForm.classMainForm.messages[MainData.messageType][MainData.selectedMessage].sender_id);
                    com.CommandType = CommandType.Text;
                    SqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        senderName = reader.GetString(0);
                        senderSurname = reader.GetString(1);
                    }
                    reader.Close();

                    // Имя и фамилия получателя
                    com.CommandText = string.Format("SELECT Name, Surname FROM Accounts WHERE ID = '{0}'",
                                                    MainForm.classMainForm.messages[MainData.messageType][MainData.selectedMessage].recipient_id);
                    com.CommandType = CommandType.Text;
                    reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        recipientName = reader.GetString(0);
                        recipientSurname = reader.GetString(1);
                    }
                    reader.Close();
                    com.ExecuteNonQuery();
                }
                con.Close();
            }

            SenderName_Lable.Text = SenderName_Lable.Text + " " + senderName + " " + senderSurname;
            RecipientName_Lable.Text = RecipientName_Lable.Text + " " + recipientName + " " + recipientSurname;
            Header_Lable.Text = MainForm.classMainForm.messages[MainData.messageType][MainData.selectedMessage].header.ToString();
            Text_Lable.Text = MainForm.classMainForm.messages[MainData.messageType][MainData.selectedMessage].text.ToString();
            Date_Lable.Text = MainForm.classMainForm.messages[MainData.messageType][MainData.selectedMessage].date.ToString();
        }

        private void DeleteMsg_But_Click(object sender, EventArgs e)
        {
            /*using (SqlConnection con = new SqlConnection("Data Source=RAGEN;Initial Catalog=Test;Integrated Security=True"))
             {
                 con.Open();
                 using (SqlCommand com = con.CreateCommand())
                 {
                     com.CommandText = string.Format("DELETE FROM Messages WHERE ID = '{0}'",
                                                     MainForm.classMainForm.messages[MainData.messageType][MainData.selectedMessage].sender_id);
                     com.CommandType = CommandType.Text;
                     com.ExecuteNonQuery();
                 }
                 con.Close();
             }*/
        }
    }
}
