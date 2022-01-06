using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private AdminLoginForm lgnForm;
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Seyidova");
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBox1.SelectedItem.ToString();
            MessageBox.Show(selectedState);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            AdminLoginForm lgnForm = new AdminLoginForm(this);
            
            string login = "admin";
            if (textBox2.Text == login)
            {
                lgnForm.Show();
                this.Hide();
            }
            else MessageBox.Show("Не верно введен логин");
            textBox2.Text = "";

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string login;
            bool T = true;
            login = comboBox1.Text ;
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

            if (T == true)
            {
                reader.Close();
                MessageBox.Show("Такого пользователя не существует");
                comboBox1.Text = "";
               
            }
            else
            {
                
               
                reader.Close();
                File.WriteAllText("UserAKT.txt", "");
                FileStream file2 = new FileStream("UserAKT.txt", FileMode.Create);
                StreamWriter writer2 = new StreamWriter(file2);
                writer2.WriteLine(login);
                writer2.Close();
                UserLoginForm User_Login_Form = new UserLoginForm();
                User_Login_Form.Show();
                this.Hide();

            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
    }
            
            
        }


 
