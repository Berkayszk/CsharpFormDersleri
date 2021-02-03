using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, result;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            result = a + b;
            textBox3.Text = Convert.ToString(result);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            MessageBox.Show("Hoşgeldiniz : "+ DateTime.Now);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a, b, result;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            result = a - b;
            textBox3.Text = Convert.ToString(result);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a, b, result;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            result = a / b;
            textBox3.Text = Convert.ToString(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a, b, result;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            result = a * b;
            textBox3.Text = Convert.ToString(result);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
