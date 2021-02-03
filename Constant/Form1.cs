using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double KDV_ORANİ = 0.18, OTV_ORANİ = 0.45;
            double fiyat = 0, kdv_tutari = 0, otv_tutari =0, toplam = 0;
            fiyat = Convert.ToDouble(textBox1.Text);
            kdv_tutari = fiyat * KDV_ORANİ;
            otv_tutari = fiyat * OTV_ORANİ;
            textBox2.Text =Convert.ToString(kdv_tutari);
            textBox3.Text = Convert.ToString(otv_tutari);
            toplam = otv_tutari + kdv_tutari + fiyat;
            textBox4.Text = Convert.ToString(toplam);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
