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
    public partial class ManualControl : Form
    {
        public ManualControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Feeder_Type feeder_setting = new Feeder_Type();
            feeder_setting.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream file1 = new FileStream("eat.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file1);

            string line;
            line = reader.ReadLine();

            string eatTXT = null;

            
                string[] splitLine = line.Split('&');
                eatTXT = splitLine[0];
            
            int eatTXTint = Convert.ToInt16(eatTXT);
            string eat;
            eat = textBox1.Text;
            int eatint = Convert.ToInt16(eat);
            int Sum = eatint + eatTXTint;
            string SumSTR = Sum.ToString();
            reader.Close();
           
            FileStream file2 = new FileStream("eat.txt", FileMode.Create);
            StreamWriter writer2 = new StreamWriter(file2);

            writer2.WriteLine(SumSTR+"&");
            writer2.Close();


            MessageBox.Show("Корм добавлен");
            

        }
    }
}
