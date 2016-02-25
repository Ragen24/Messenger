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
        // Для хранения указателя на данный класс
        public static MainForm classMainForm;

        // Двумерный массив для хранения входящих и отправленных сообщений
        public MainData.Messages[][] messages = new MainData.Messages[2][];

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
            // Инициализация 
            messages[0] = new MainData.Messages[0]; // Отправленные
            messages[1] = new MainData.Messages[0]; // Входящие

            // Подключение к SQL Server
            using (SqlConnection con = new SqlConnection("Data Source=192.168.1.65,1433;Initial Catalog=Test;User ID=Ragen; Password=utg1df25fu"))
            {
                con.Open();
                using (SqlCommand com = con.CreateCommand())
                {
                    // Запрос на выборку именни, фамилии и Email текущего пользователя
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

                    // Запрос на выборку отправленных сообщений
                    com.CommandText = string.Format("SELECT * FROM Messages WHERE Sender_id = '{0}'",
                                                   MainData.userID);
                    com.CommandType = CommandType.Text;
                    reader = com.ExecuteReader();

                    while (reader.Read())
                    {
                        // Запись даты и времени последнего отправленного сообщения(для пополнения списка сообщений)
                        MainData.lastSentMsgDate = reader.GetDateTime(5);    
                        // Добавление сообщения в массив и список
                        AddMessage(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetString(3), reader.GetString(4), reader.GetDateTime(5), 0);
                        SentMessages_ListView.Items.Add(new ListViewItem(new string[] { reader.GetString(3), reader.GetDateTime(5).ToString() }));
                    }
                    reader.Close();

                    // Запрос на выборку входящих сообщений
                    com.CommandText = string.Format("SELECT * FROM Messages WHERE Recipient_id = '{0}'",
                                                   MainData.userID);
                    com.CommandType = CommandType.Text;
                    reader = com.ExecuteReader();
                    
                    while (reader.Read())
                    {
                        // Запись даты и времени последнего отправленного сообщения(для пополнения списка сообщений)
                        MainData.lastIncMsgDate = reader.GetDateTime(5);
                        // Добавление сообщения в массив и список
                        AddMessage(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetString(3), reader.GetString(4), reader.GetDateTime(5), 1);
                        IncMessages_ListView.Items.Add(new ListViewItem(new string[] { reader.GetString(3), reader.GetDateTime(5).ToString() }));
                    }
                    reader.Close();
                    com.ExecuteNonQuery();
                }
                con.Close();
            }
        }
        
        // Метод создания экземпляров класса Message хранящих данные о сообщениях
        public void AddMessage(int ID, int sender_id, int recipient_id, string header, string text, DateTime date, int index)
        {
            Array.Resize(ref messages[index], messages[index].Length + 1);
            messages[index][messages[index].Length - 1] = new MainData.Messages();
            messages[index][messages[index].Length - 1].ID = ID;
            messages[index][messages[index].Length - 1].sender_id = sender_id;
            messages[index][messages[index].Length - 1].recipient_id = recipient_id;
            messages[index][messages[index].Length - 1].header = header;
            messages[index][messages[index].Length - 1].text = text;
            messages[index][messages[index].Length - 1].date = date;
        }

        private void Name_Lable_Click(object sender, EventArgs e)
        {

        }

        // Переход к форме SignIn
        private void button1_Click(object sender, EventArgs e)
        {
            SignIn signInForm = new SignIn();
            this.Close();
            signInForm.ShowDialog();
        }

        private void Email_Lable_Click(object sender, EventArgs e)
        {

        }

        // Закрытие приложения
        private void button2_Click(object sender, EventArgs e)
        {
            LogIn.classLogIn.Close();
        }

        // Переход к форме WriteMessage
        private void WriteMessage_But_Click(object sender, EventArgs e)
        {
            WriteMessage writeMessageForm = new WriteMessage();
            writeMessageForm.ShowDialog();
        }

        // Выбор сообщения из списка отправленных
        private void SentMessages_ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Сброс индекса выбранного сообщения
            MainData.selectedMessage = -1;

            if (SentMessages_ListView.SelectedIndices.Count > 0)
                // Нахождение инжекса выбранного сообщения
                MainData.selectedMessage = SentMessages_ListView.SelectedIndices[0];

            if (MainData.selectedMessage < 0) return;
            
            // Указание типа сообщения (0 - отправленные, 1 - полученные)
            MainData.messageType = 0;
            // Открытие просмотра сообщения
            MessageView messageViewForm = new MessageView();
            messageViewForm.ShowDialog();
        }

        // Выбор сообщения из списка входящих
        private void IncMessages_ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Сброс индекса выбранного сообщения
            MainData.selectedMessage = -1;

            if (IncMessages_ListView.SelectedIndices.Count > 0)
                // Нахождение инжекса выбранного сообщения
                MainData.selectedMessage = IncMessages_ListView.SelectedIndices[0];

            if (MainData.selectedMessage < 0) return;

            // Указание типа сообщения (0 - отправленные, 1 - полученные)
            MainData.messageType = 1;
            // Открытие просмотра сообщения
            MessageView messageViewForm = new MessageView();
            messageViewForm.ShowDialog();
        }

        // Обновление списка входящих сообщений
        private void Refresh_But_Click(object sender, EventArgs e)
        {
            // Соединение с БД
            using (SqlConnection con = new SqlConnection("Data Source=192.168.1.65,1433;Initial Catalog=Test;User ID=Ragen; Password=utg1df25fu"))
            {
                con.Open();
                using (SqlCommand com = con.CreateCommand())
                {
                    // Выборка сообщений младше последнего полученного
                    com.CommandText = string.Format("SELECT * FROM Messages WHERE Recipient_id = '{0}' AND Date > '{1}'",
                                                   MainData.userID,  MainData.GetDateWithoutMilliseconds(MainData.lastIncMsgDate));
                    com.CommandType = CommandType.Text;
                    SqlDataReader reader = com.ExecuteReader();

                    while (reader.Read())
                    {
                        // Запись даты и времени последнего отправленного сообщения(для пополнения списка сообщений)
                        MainData.lastIncMsgDate = reader.GetDateTime(5);
                        // Заполнение массива и списка
                        AddMessage(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetString(3), reader.GetString(4), reader.GetDateTime(5), 1);
                        IncMessages_ListView.Items.Add(new ListViewItem(new string[] { reader.GetString(3), reader.GetDateTime(5).ToString() }));
                    }
                    reader.Close();
                    com.ExecuteNonQuery();
                }
                con.Close();
            }
        }

        // Обновление списка отправленных сообщений
        public void RefreshSent()
        {
            using (SqlConnection con = new SqlConnection("Data Source=192.168.1.65,1433;Initial Catalog=Test;User ID=Ragen; Password=utg1df25fu"))
            {
                con.Open();
                using (SqlCommand com = con.CreateCommand())
                {
                    // Выборка сообщений младше последнего отправленного
                    com.CommandText = string.Format("SELECT * FROM Messages WHERE Sender_id = '{0}' AND Date > '{1}'",
                                                   MainData.userID,  MainData.GetDateWithoutMilliseconds(MainData.lastSentMsgDate));
                    com.CommandType = CommandType.Text;
                    SqlDataReader reader = com.ExecuteReader();

                    while (reader.Read())
                    {
                        // Запись даты и времени последнего отправленного сообщения(для пополнения списка сообщений)
                        MainData.lastSentMsgDate = reader.GetDateTime(5);
                        // Добавление сообщения в массив и список
                        AddMessage(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetString(3), reader.GetString(4), reader.GetDateTime(5), 0);
                        SentMessages_ListView.Items.Add(new ListViewItem(new string[] { reader.GetString(3), reader.GetDateTime(5).ToString() }));
                    }
                    reader.Close();
                    com.ExecuteNonQuery();
                }
                con.Close();
            }
        }
    }
}
