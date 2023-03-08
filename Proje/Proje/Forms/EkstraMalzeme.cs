using Proje.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje.Forms
{
    public partial class EkstraMalzeme : Form
    {
        Form2 Frm2;
        Ekstra Etr;
        public EkstraMalzeme()
        {
            InitializeComponent();
            Etr= new Ekstra();
        }
        public EkstraMalzeme(Form2 frm2): this()
        {
            Frm2 = frm2;    
        }
        private void EkstraMalzeme_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {

                Etr.MalzemeEkle(Frm2, textBox1.Text, Convert.ToDouble(numericUpDown1.Value));
            }
            else
            {
                MessageBox.Show("Ekstra malzeme adı boş olamaz");
            }
        }
    }
}
