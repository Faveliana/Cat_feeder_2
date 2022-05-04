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
    public partial class feeder_controlForm : Form
    {
        public feeder_controlForm()
        {
           
                InitializeComponent();
                comboBox1.Items.Add("Seyidova's");
                comboBox1.Items.Add("кормушка 1");
                comboBox1.Items.Add("кормушка 2");

                comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            

            void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {
                string selectedState = comboBox1.SelectedItem.ToString();
                MessageBox.Show(selectedState);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            feeder_seting feeder_seting = new feeder_seting();
            feeder_seting.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            User_Form fedS = new User_Form();
            fedS.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
