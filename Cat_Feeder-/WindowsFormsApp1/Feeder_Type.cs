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
    public partial class Feeder_Type : Form
    {
        public Feeder_Type()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void checkBox_Click(object sender, EventArgs e)
        {
            CheckBox chbx = sender as CheckBox;
            chbx.Checked = !chbx.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)

            {
               

         
                File.WriteAllText("FeederType.txt", "");
                FileStream file2 = new FileStream("FeederType.txt", FileMode.Create);
                StreamWriter writer2 = new StreamWriter(file2);
               
                writer2.WriteLine("el");
                writer2.Close();


                MessageBox.Show("Тип кормушки выбран! ");
                feeder_seting feeder_Seting = new feeder_seting();
                feeder_Seting.Show();
                this.Hide();
            }

            if (checkBox2.Checked)
            {
                

                
                File.WriteAllText("FeederType.txt", "");
                FileStream file2 = new FileStream("FeederType.txt", FileMode.Create);
                StreamWriter writer2 = new StreamWriter(file2);
             
                writer2.WriteLine("mex");
                writer2.Close();


                MessageBox.Show("Тип кормушки выбран! ");
                feeder_seting feeder_Seting = new feeder_seting();
                feeder_Seting.Show();
                this.Hide();
            }

        
    }

        private void button2_Click(object sender, EventArgs e)
        {
            feeder_seting fedset = new feeder_seting();
            fedset.Show();
            this.Hide();
        }
    }
}
