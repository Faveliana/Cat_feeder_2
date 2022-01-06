using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Get_infoForm : Form
    {
        public Get_infoForm()
        {
            InitializeComponent();
            
            
        }



        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User_Form UsFor = new User_Form();
            UsFor.Show();
            this.Hide();
        }

        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
