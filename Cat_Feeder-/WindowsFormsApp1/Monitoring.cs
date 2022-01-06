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
    public partial class Monitoring : Form
    {
        int koef = 1;
        public Monitoring()
        {
            InitializeComponent();

            
        }
        void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void Monitoring_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();


            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                string text = File.ReadAllText(filename);
                textBox1.Text = text;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            User_Form UsFor = new User_Form();
            UsFor.Show();
            this.Hide();
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        // обработчик события Tick таймера


    }
}
