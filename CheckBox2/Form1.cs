using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] Added = { "Türkçe", "Almanca", "Fransızca", "Osmanlıca", "İtalyanca", "Portekizce", "Rusça", "Azerice", "Yunanca", "İspanyolca" };
            checkedListBox1.Items.AddRange(Added);
            checkedListBox1.MultiColumn = true;
            checkedListBox1.CheckOnClick = trues
            button2.Enabled = false;
            
            
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label6.Text = textBox1.Text;
            if (radioButton1.Checked == true)
            {
                label8.Text = radioButton1.Text;
            }
            if (radioButton2.Checked == true)
            {
                label8.Text = radioButton2.Text;
            }
            if (radioButton3.Checked == true)
            {
                label8.Text = radioButton3.Text;
            }
            if (radioButton4.Checked == true)
            {
                label8.Text = radioButton4.Text;
            }
            string diller = "";
            for (int i = 0; i <checkedListBox1.CheckedItems.Count; i++)
            {
                diller += ", " + checkedListBox1.CheckedItems[i];
            }
            diller = diller.Substring(2);
            label7.Text = diller;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (textBox3.Text != "")
            {
                if (checkedListBox1.Items.Contains(textBox3.Text))
                {
                    checkedListBox1.Items.Add(textBox3.Text);
                }
                else
                {
                    MessageBox.Show("Belirtilen Dil Zaten Eklidir");
                    textBox3.Text = "";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Remove(checkedListBox1.SelectedItem);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            while (checkedListBox1.CheckedItems.Count>0)
            {
                checkedListBox1.SetItemChecked(checkedListBox1.CheckedIndices[0], false);
            }
        }
    }
}
