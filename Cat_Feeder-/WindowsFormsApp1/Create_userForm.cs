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
    public partial class Create_userForm : Form
    {
        public Create_userForm()
        {
            InitializeComponent();
        }

        private void Create_userForm_Load(object sender, EventArgs e)
        {

        }
        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void button1_Click(object sender, EventArgs e)
        {
            string login;
            bool T = true;
            login = textBox1.Text ;
            FileStream file1 = new FileStream("log_file.txt", FileMode.Open, FileAccess.ReadWrite);
            StreamReader reader = new StreamReader(file1);
            string line;

            while (((line = reader.ReadLine()) != null))
            {

                string[] splitLine = line.Split(' ');


                string loginTXT = splitLine[0] ;

                if (login != loginTXT)
                {

                    T = true;

                }
                else
                {

                    T = false;

                    break;
                }

            }

            if (T == false)
            {
                MessageBox.Show("Такой пользователь уже есть");
                textBox1.Text = "";
                reader.Close();
            }
            else
            {
                MessageBox.Show("Пользовтель успешно создан");
                StreamWriter writer = new StreamWriter(file1);
                writer.WriteLine("\n"+login);
                writer.Close();
                adminForm AdminForm = new adminForm();
                AdminForm.Show();
                this.Hide();
                File.AppendAllText("FileINFO.txt", "\n" + "Создана новый пользователь" + login);
                File.AppendAllText("FileINFO.txt", "\n" + "Создан пользователь"+login);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            adminForm adF = new adminForm();
            adF.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}


