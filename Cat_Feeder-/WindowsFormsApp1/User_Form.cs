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
    public partial class User_Form : Form
    {
        public User_Form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Change_scheduleForm Change_scheduleForm = new Change_scheduleForm();
            Change_scheduleForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            feeder_controlForm Create_scheduleForm = new feeder_controlForm();
            Create_scheduleForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Check_the_scheduleForm check_The_ScheduleForm = new Check_the_scheduleForm();
            check_The_ScheduleForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            feedForm feedForm = new feedForm();
            feedForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Get_infoForm Get_infoForm = new Get_infoForm();
            Get_infoForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
