using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("AD",250);
            listView1.Columns.Add("SOYAD", 250);
            listView1.Columns.Add("ÖĞRENCİ NO", 300);
            listView1.Columns.Add("CİNSİYET", 300);
            listView1.Columns.Add("DOĞUM YERİ", 300);
            listView1.Columns.Add("TELEFON NO", 300);
            string[] mezuniyet = { "İlkokul","Ortaokul","Lise","Üniversite" };
            comboBox1.Items.AddRange(mezuniyet);
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ogrnno, ad, soyad,dogum,telno,cinsiyet;
            ogrnno = textBox1.Text;
            ad = textBox2.Text;
            soyad = textBox3.Text;
            dogum = textBox4.Text;
            telno = textBox5.Text;
            cinsiyet = "";
            bool ara = false;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[0].Text==textBox1.Text)
                {
                    ara = true;
                    MessageBox.Show(textBox1.Text + " TC Nolu Kişi Zaten Kayıtlı!!");
                }
            }
            if (radioButton1.Checked == true)
            {
                cinsiyet = radioButton1.Text;
            }
            else if (radioButton2.Checked==true)
            {
                cinsiyet = radioButton2.Text;
            }
            string[] bilgiler = { ogrnno,ad,soyad,dogum,telno,cinsiyet};
            ListViewItem kayit = new ListViewItem(bilgiler);
            listView1.Items.Add(kayit);
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listView1.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            
        }
    }
}
