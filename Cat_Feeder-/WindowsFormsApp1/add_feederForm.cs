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
    public partial class add_feederForm : Form
    {
        public add_feederForm()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string feeder;
            bool T = true;
            feeder = textBox1.Text + " ";
            FileStream file1 = new FileStream("feeder_file.txt", FileMode.Open, FileAccess.ReadWrite);
            StreamReader reader = new StreamReader(file1);
            string line ;
           
            while (((line = reader.ReadLine()) != null))
            {
                
                    string[] splitLine = line.Split(' ');
                
                
                    string loginTXT = splitLine[0] + " ";
                
                if (feeder != loginTXT)
                    {
                    
                    T =true;
                        
                    }
                    else
                    {
                    
                    T = false;
                    
                    break;
                }
           
            }
            
            if (T == false)
            {
                MessageBox.Show("Такая кормушка уже есть");
                textBox1.Text = "";
                reader.Close();
            }
            else 
            {
                MessageBox.Show("Кормушка успешно создана ");
               
                StreamWriter writer = new StreamWriter(file1);
                writer.WriteLine("/n"+feeder);
                writer.Close();
                adminForm AdminForm = new adminForm();
                AdminForm.Show();
                this.Hide();
                File.AppendAllText("FileINFO.txt", "\n" + "Создана новая кормушка"+feeder);


            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminForm adFor = new adminForm();
            adFor.Show();
            Hide();
        }
    }
}