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
    public partial class Create_Schedule_Form : Form
    {
        public Create_Schedule_Form()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Schedule;

            Schedule = textBox1.Text + " ";
            FileStream file1 = new FileStream("Schedule_file.txt", FileMode.Open);
            StreamWriter writer = new StreamWriter(file1);
            writer.WriteLine(Schedule);
            writer.Close();

           
           string Schedule_time1 = textBox2.Text + "&";
            string Schedule_time2 = textBox3.Text + "&";
            string Schedule_time3 = textBox4.Text + "&";
            string Schedule_time4 = textBox5.Text + "&";
            string Schedule_time5 = textBox6.Text + "&";
            string Schedule_time7 = textBox7.Text + "&";
            File.WriteAllText("Schedule_time_file_day.txt", "");
            var file3 = new FileStream("Schedule_time_file_day.txt", FileMode.Open);
            var streamWriter3 = new StreamWriter(file3);
            if (Schedule_time7 != null)
            {
                streamWriter3.Write(Schedule_time7);

            }
            streamWriter3.Close();

            File.WriteAllText("Schedule_time_file.txt","");
            var file2 = new FileStream("Schedule_time_file.txt", FileMode.Open);
            var streamWriter = new StreamWriter(file2);
            if (Schedule_time1!=null) {
                streamWriter.Write(Schedule_time1);
                
            }
            if (Schedule_time2 != null)
            {
                streamWriter.Write("\n" + Schedule_time2);

            }
            if (Schedule_time3 != null)
            {
                streamWriter.Write("\n" + Schedule_time3);

            }
            if (Schedule_time4 != null)
            {
                streamWriter.Write("\n" + Schedule_time4);

            }
            if (Schedule_time5 != null)
            {
                streamWriter.Write("\n" + Schedule_time5);

            }

            streamWriter.Close();
            MessageBox.Show("Расписание успешно создано ");
            File.AppendAllText("FileINFO.txt", "\n" + "Создано расписание"+Schedule);
            Create_Schedule_Form Create_Schedule_Form = new Create_Schedule_Form();
            Create_Schedule_Form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            feeder_seting fedS = new feeder_seting();
            fedS.Show();
            Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Create_Schedule_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
