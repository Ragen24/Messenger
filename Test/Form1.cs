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
    public partial class MainForm : Form
    {
        //static public MainForm classMainData;
        

        public MainForm()
        {
            //classMainData = this;
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
    }
}
