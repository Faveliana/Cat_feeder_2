using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Feed_Type : Form
    {
        public Feed_Type()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)

            {
              
               
               
                File.WriteAllText("FeedType.txt", "");
                FileStream file2 = new FileStream("FeedType.txt", FileMode.Create);
                StreamWriter writer2 = new StreamWriter(file2);
                writer2.WriteLine("suhoy");
                writer2.Close();


                MessageBox.Show("Тип корма выбран! ");
                feeder_seting feeder_Seting = new feeder_seting();
                feeder_Seting.Show();
                this.Hide();
            }

            if (checkBox2.Checked)
            {
               
                
                File.WriteAllText("FeedType.txt", "");
                FileStream file2 = new FileStream("FeedType.txt", FileMode.Create);
                StreamWriter writer2 = new StreamWriter(file2);
           
                writer2.WriteLine("zhidkiy");
                writer2.Close();


                MessageBox.Show("Тип корма выбран! ");
                feeder_seting feeder_Seting = new feeder_seting();
                feeder_Seting.Show();
                this.Hide();
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            feeder_seting fedSet = new feeder_seting();
            fedSet.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
