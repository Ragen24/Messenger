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
    public partial class LogIn : Form
    {
        static public LogIn classLogIn;
        

        public LogIn()
        {
            classLogIn = this;
            InitializeComponent();
        }

        private void Registration_But_Click(object sender, EventArgs e)
        {
            Registration RegForm = new Registration();
            this.Hide();
            RegForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void SignIn_But_Click(object sender, EventArgs e)
        {
            SignIn signInForm = new SignIn();
            this.Hide();
            signInForm.ShowDialog();
        }
    }
}
