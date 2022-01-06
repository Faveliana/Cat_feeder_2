using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class adminForm : Form
    {
        public adminForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Create_userForm Create_userForm = new Create_userForm();
            Create_userForm.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            add_feederForm add_feederForm = new add_feederForm();
            add_feederForm.Show();
            this.Hide();
        }

        private void eventLog1_EntryWritten(object sender, System.Diagnostics.EntryWrittenEventArgs e)
        {

        }

        private void check_the_status_Click(object sender, EventArgs e)
        {
            Check_status Check_status = new Check_status();
            Check_status.Show();
            this.Hide();


        }

        private void get_info_Click(object sender, EventArgs e)
        {
            Get_infoForm Get_infoForm = new Get_infoForm();
            Get_infoForm.Show();
            this.Hide();
        }

        private void button1_Click_2(object sender, EventArgs e)

        {

            Application.Exit();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
