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
    public partial class Check_status : Form
    {
        public Check_status()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            adminForm adF = new adminForm();
            adF.Show();
            this.Hide();
        }

        private void Check_status_Load(object sender, EventArgs e)
        {

        }
    }
}
