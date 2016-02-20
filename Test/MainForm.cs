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
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDataSet.Messages' table. You can move, or remove it, as needed.
            this.messagesTableAdapter.Fill(this.testDataSet.Messages);
            // TODO: This line of code loads data into the 'testDataSet.Accounts' table. You can move, or remove it, as needed.
            this.accountsTableAdapter.Fill(this.testDataSet.Accounts);
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
                    com.ExecuteNonQuery();

                    //MainData.userID = accIndex;
                }
                con.Close();
            }
        }

        private void Name_Lable_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Email_Lable_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void WriteMessage_But_Click(object sender, EventArgs e)
        {
            WriteMessage writeMessageForm = new WriteMessage();
            writeMessageForm.Show();
        }
    }
}
