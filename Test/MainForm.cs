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
    public partial class MainForm : Form
    {
        public static MainForm classMainForm;

        public MainData.Messages[][] messages = new MainData.Messages[2][];
        public MainData.Messages[] incMessages = new MainData.Messages[0];
        public MainData.Messages[] sentMessages = new MainData.Messages[0];

        public MainForm()
        {
            classMainForm = this;
            InitializeComponent();
        }

        

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDataSet.Messages' table. You can move, or remove it, as needed.
            this.messagesTableAdapter.Fill(this.testDataSet.Messages);
            // TODO: This line of code loads data into the 'testDataSet.Accounts' table. You can move, or remove it, as needed.
            this.accountsTableAdapter.Fill(this.testDataSet.Accounts);
            messages[0] = new MainData.Messages[0];
            messages[1] = new MainData.Messages[0];
            

            using (SqlConnection con = new SqlConnection("Data Source=RAGEN;Initial Catalog=Test;Integrated Security=True"))
            {
                con.Open();
                using (SqlCommand com = con.CreateCommand())
                {
                    com.CommandText = string.Format("SELECT Name, Surname, Email FROM Accounts WHERE ID = '{0}'",
                                                   MainData.userID);
                    com.CommandType = CommandType.Text;
                    SqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        Name_Lable.Text = (reader.GetString(0) + " " + reader.GetString(1));
                        Email_Lable.Text = reader.GetString(2);
                    }
                    reader.Close();

                    // Отправленные
                    com.CommandText = string.Format("SELECT Sender_id, Recipient_id, Header, Text, Date FROM Messages WHERE Sender_id = '{0}'",
                                                   MainData.userID);
                    com.CommandType = CommandType.Text;
                    reader = com.ExecuteReader();

                    while (reader.Read())
                    {
                        MainData.lastSentMsgDate = reader.GetDateTime(4);
                        AddMessage(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4), 0);
                        SentMessages_ListView.Items.Add(new ListViewItem(new string[] { reader.GetString(2), reader.GetDateTime(4).ToString() }));
                    }
                    reader.Close();

                    // Входящие
                    com.CommandText = string.Format("SELECT Sender_id, Recipient_id, Header, Text, Date FROM Messages WHERE Recipient_id = '{0}'",
                                                   MainData.userID);
                    com.CommandType = CommandType.Text;
                    reader = com.ExecuteReader();
                    
                    while (reader.Read())
                    {
                        MainData.lastIncMsgDate = reader.GetDateTime(4);
                        AddMessage(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4), 1);
                        IncMessages_ListView.Items.Add(new ListViewItem(new string[] { reader.GetString(2), reader.GetDateTime(4).ToString() }));
                    }
                    reader.Close();
                    com.ExecuteNonQuery();
                }
                con.Close();
            }
        }

        public void AddMessage(int sender_id, int recipient_id, string header, string text, DateTime date, int index)
        {
            Array.Resize(ref messages[index], messages[index].Length + 1);
            messages[index][messages[index].Length - 1] = new MainData.Messages();
            messages[index][messages[index].Length - 1].sender_id = sender_id;
            messages[index][messages[index].Length - 1].recipient_id = recipient_id;
            messages[index][messages[index].Length - 1].header = header;
            messages[index][messages[index].Length - 1].text = text;
            messages[index][messages[index].Length - 1].date = date;
        }

        private void Name_Lable_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignIn signInForm = new SignIn();
            this.Close();
            signInForm.ShowDialog();
        }

        private void Email_Lable_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogIn.classLogIn.Close();
        }

        private void WriteMessage_But_Click(object sender, EventArgs e)
        {
            WriteMessage writeMessageForm = new WriteMessage();
            writeMessageForm.ShowDialog();
        }

        private void SentMessages_ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainData.selectedMessage = -1;

            if (SentMessages_ListView.SelectedIndices.Count > 0)
                MainData.selectedMessage = SentMessages_ListView.SelectedIndices[0];

            if (MainData.selectedMessage < 0) return;

            MainData.messageType = 0;
            MessageView messageViewForm = new MessageView();
            messageViewForm.ShowDialog();
        }

        private void IncMessages_ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainData.selectedMessage = -1;

            if (IncMessages_ListView.SelectedIndices.Count > 0)
              MainData.selectedMessage = IncMessages_ListView.SelectedIndices[0];

            if (MainData.selectedMessage < 0) return;

            MainData.messageType = 1;
            MessageView messageViewForm = new MessageView();
            messageViewForm.ShowDialog();
        }

        private void Refresh_But_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=RAGEN;Initial Catalog=Test;Integrated Security=True"))
            {
                con.Open();
                using (SqlCommand com = con.CreateCommand())
                {
                    com.CommandText = string.Format("SELECT Sender_id, Recipient_id, Header, Text, Date FROM Messages WHERE Recipient_id = '{0}' AND Date > '{1}'",
                                                   MainData.userID,  MainData.GetDateWithoutMilliseconds(MainData.lastIncMsgDate));
                    com.CommandType = CommandType.Text;
                    SqlDataReader reader = com.ExecuteReader();

                    while (reader.Read())
                    {
                        AddMessage(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4), 1);
                        IncMessages_ListView.Items.Add(new ListViewItem(new string[] { reader.GetString(2), reader.GetDateTime(4).ToString() }));
                    }
                    reader.Close();
                    com.ExecuteNonQuery();
                }
                con.Close();
            }
        }

        public void RefreshSent()
        {
            using (SqlConnection con = new SqlConnection("Data Source=RAGEN;Initial Catalog=Test;Integrated Security=True"))
            {
                con.Open();
                using (SqlCommand com = con.CreateCommand())
                {
                    com.CommandText = string.Format("SELECT Sender_id, Recipient_id, Header, Text, Date FROM Messages WHERE Sender_id = '{0}' AND Date > '{1}'",
                                                   MainData.userID,  MainData.GetDateWithoutMilliseconds(MainData.lastSentMsgDate));
                    com.CommandType = CommandType.Text;
                    SqlDataReader reader = com.ExecuteReader();

                    while (reader.Read())
                    {
                        AddMessage(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4), 0);
                        SentMessages_ListView.Items.Add(new ListViewItem(new string[] { reader.GetString(2), reader.GetDateTime(4).ToString() }));
                    }
                    reader.Close();
                    com.ExecuteNonQuery();
                }
                con.Close();
            }
        }
    }
}
