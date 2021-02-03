using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = "";
            if (checkBox1.Checked==true)
            {
                result = result + "," + checkBox1.Text;
            }
            if (checkBox2.Checked == true)
            {
                result = result + "," + checkBox2.Text;
            }
            if (checkBox3.Checked == true)
            {
                result = result + "," + checkBox3.Text;
            }
            if (checkBox4.Checked == true)
            {
                result = result + "," + checkBox4.Text;
            }
            label2.Text = result.Substring(1);
        }
    }
}
