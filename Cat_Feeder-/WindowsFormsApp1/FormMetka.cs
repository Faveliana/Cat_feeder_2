using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormMetka : Form
    {
        public FormMetka()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            string FeedStar = textBox1.Text+" ";
            string FeedNew = textBox2.Text+" ";
            FileStream file1 = new FileStream("feeder_file.txt", FileMode.Open, FileAccess.ReadWrite);
            StreamReader reader = new StreamReader(file1);
            string line=null;
            bool T = true;
            while (((line = reader.ReadLine()) != null))
            {

                string[] splitLine = line.Split(' ');


                string loginTXT = splitLine[0] ;

                if (FeedStar != loginTXT)
                {

                    T = true;

                }
                else
                {

                    T = false;

                    break;
                }

            }

            if (!T)
            {
                MessageBox.Show("Такого названия нет");
                textBox1.Text = "";
                reader.Close();
            }
            else
            {
                MessageBox.Show("Название изменено");
                reader.Close();
                var tempFile = Path.GetTempFileName();
                var linesToKeep = File.ReadLines("feeder_file.txt").Where(l => l != FeedStar);

                File.WriteAllLines(tempFile, linesToKeep);

                File.Delete("feeder_file.txt");
                File.Move(tempFile, "feeder_file.txt");

                File.AppendAllText("feeder_file.txt", FeedNew+" ");
                feeder_seting feeder_Seting = new feeder_seting();
                feeder_Seting.Show();
                this.Hide();
                File.WriteAllText("name_feeder_for_type.txt", FeedNew);
                File.AppendAllText("FileINFO.txt", "\n" + "Кормушка" + FeedStar + "изменена на"+FeedNew);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            feeder_seting feeds = new feeder_seting();
            feeds.Show();
            this.Hide();
        }
    }

    }

