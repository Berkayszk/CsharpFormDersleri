using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //elle eklemek için 
            comboBox1.Items.Add("Böyle de eklenebilir");
            //dizi ile birlikte ekleme
            String[] markalar = { "Araba","Ödül","ekledim","bunları","elle" };
            comboBox1.Items.AddRange(markalar);

        }
    }
}
