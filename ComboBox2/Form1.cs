using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] combobox = { "Audi","Mercedes-Benz" };
            comboBox1.Items.AddRange(combobox);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text=="Audi")
            {
                comboBox2.Items.Clear();
                string[] audicombo = { "1.5 TFS" };
                comboBox2.Items.AddRange(audicombo);
            }
            if (comboBox1.Text == "Mercedes-Benz")
            {
                comboBox2.Items.Clear();
                string[] mersocombo = { "2.5 TFS" };
                comboBox2.Items.AddRange(mersocombo);
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text== "1.5 TFS")
            {
                comboBox3.Items.Clear();
                string[] audiyil = { "2015","2016","2017","2018","2019","2020" };
                comboBox3.Items.AddRange(audiyil);
            }
            if (comboBox2.Text == "2.5 TFS")
            {
                comboBox3.Items.Clear();
                string[] mersoyil = { "2016", "2017", "2018", "2019", "2020" };
                comboBox3.Items.AddRange(mersoyil);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Markası : "+comboBox1.Text+ " Motor Hacmi : "+comboBox2.Text+" Yılı :  "+comboBox3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
