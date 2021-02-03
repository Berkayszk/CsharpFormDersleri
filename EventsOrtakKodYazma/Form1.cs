using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsOrtakKodYazma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = "0";textBox3.Text = "1";radioButton1.Checked = true;
            textBox4.Enabled = false; textBox5.Enabled = false;
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double birimfiyati = Convert.ToDouble(textBox2.Text);
                int adeti = Convert.ToInt32(textBox3.Text);
                double tutar = birimfiyati * adeti;
                double kdv = 0;
                if (radioButton1.Checked==true)
                {
                    kdv = tutar * 0.25;

                }
                if (radioButton2.Checked == true)
                {
                    kdv = tutar * 0.18;

                }
                if (radioButton3.Checked == true)
                {
                    kdv = tutar * 0.8;

                }
                tutar = tutar + kdv;
                if (checkBox1.Checked==true)
                {
                    tutar = tutar - (tutar*0.1);
                }
                textBox4.Text = Convert.ToString(kdv);
                textBox5.Text = Convert.ToString(tutar);
            }
            catch (Exception)
            {

                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text+" "+textBox2.Text+" "+textBox3.Text+" "+textBox4.Text+" "+textBox5.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
