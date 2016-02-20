using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class LogIn : Form
    {
        static public LogIn classMainForm;
        

        public LogIn()
        {
            InitializeComponent();
        }

        private void Registration_But_Click(object sender, EventArgs e)
        {
            Registration RegForm = new Registration();
            RegForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void SignIn_But_Click(object sender, EventArgs e)
        {
            SignIn signInForm = new SignIn();
            signInForm.Show();
        }
    }
}
