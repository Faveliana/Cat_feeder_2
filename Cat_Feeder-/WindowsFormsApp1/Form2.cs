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
    public partial class Form2 : Form
    {
        bool NS = true;
        public Form2()
        {
            InitializeComponent();
        }

        bool N = true;
        int j = 0;
        int d = 0;
        private object rnd;


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User_Form User_form = new User_Form();
            User_form.Show();
            this.Hide();

        }



        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;



        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Days = textBox2.Text;
            string Hours = textBox1.Text;
            int eatFeed=0;
            FileStream feedtype = new FileStream("Feedertype.txt", FileMode.Open);
            StreamReader readerfeedtype = new StreamReader(feedtype);
            string type;
            string typeline;
            type= readerfeedtype.ReadLine();
            string[] splitLineType = type.Split(' ');
            typeline = splitLineType[0];
            if (typeline=="mex") 
            {
                Random rnd2 = new Random();

                eatFeed = rnd2.Next(120, 200);
            }
            else 
            {
                eatFeed = 180;
            }
            readerfeedtype.Close();
            File.AppendAllText("FileINFO.txt", "\n" + "Началась симуляция " + Days + "дней" + Hours + "часов");
            FileStream dayfile = new FileStream("Schedule_time_file_day.txt", FileMode.Open);
            StreamReader readerday = new StreamReader(dayfile);
            string DayLine;
            string DayLineFile;
            DayLine = readerday.ReadLine();
            string[] splitLineDay = DayLine.Split('&');
            DayLineFile = splitLineDay[0];
            int DayLineFileDay = Convert.ToInt16(DayLineFile);
            readerday.Close();

            FileStream hoursfile = new FileStream("Schedule_time_file.txt", FileMode.Open);
            StreamReader readerhours = new StreamReader(hoursfile);
            string HoursLine;
            int[] array=new int[10];
             HoursLine = readerhours.ReadLine();
            int i = 0;
            while (readerhours.ReadLine()!=null) {
                string[] splitLineHours = HoursLine.Split('&');
                string mes = splitLineHours[0];
               
                i++;
                 array[i] = Convert.ToInt16(mes);
            }
            
            readerhours.Close();



            int DaysInt = Convert.ToInt16(Days);
            int HoursInt = Convert.ToInt16(Hours);
            int Time = HoursInt + DaysInt * 24;
            
            FileStream file1 = new FileStream("eat.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file1);
            string line;
            line = reader.ReadLine();
            string eatTXT = null;


            string[] splitLine = line.Split('&');
            eatTXT = splitLine[0];

            int eatTXTint = Convert.ToInt16(eatTXT);
            Random rnd = new Random();
            int eatCat = -1 * rnd.Next(100, 200) *(Time/8) ;
            int SumCat = eatTXTint + eatCat;
            for (int k=0;k<=DayLineFileDay ;k++) {
                for (int j = 0; j <= i; j++)
                {
                    if ((Time - array[j] > 0))
                    {
                        SumCat = SumCat + eatFeed;
                    }
                }
            }
            if (SumCat < 0)
            {
                SumCat = 0;
            }
            if (SumCat > 3000)
            {
                SumCat = 3000;
            }
            string SumSTR = SumCat.ToString();
            reader.Close();


            FileStream file2 = new FileStream("eat.txt", FileMode.Create);
            StreamWriter writer2 = new StreamWriter(file2);

            writer2.WriteLine(SumSTR + "&");
            writer2.Close();


            MessageBox.Show("Прошло"+Days+" дней"+Hours+" часов");
            
           


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

      
    }
}
