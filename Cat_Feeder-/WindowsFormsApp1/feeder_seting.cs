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
    public partial class feeder_seting : Form
    {
        public feeder_seting()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Feed_Type feedType = new Feed_Type();
            feedType.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Monitoring monitoring = new Monitoring();
            monitoring.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMetka formMetka = new FormMetka();
            formMetka.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        

        private void button2_Click_1(object sender, EventArgs e)
        {
            Create_Schedule_Form Create_Schedule_Form = new Create_Schedule_Form();
            Create_Schedule_Form.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            feeder_controlForm feeder_cF = new feeder_controlForm();
            feeder_cF.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Feeder_Type feederType = new Feeder_Type();
            feederType.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ManualControl ManualControl = new ManualControl();
            ManualControl.Show();
            this.Hide();
        }
    }
}
