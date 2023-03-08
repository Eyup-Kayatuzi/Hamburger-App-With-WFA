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
    public partial class MenuEkle : Form
    {
        Form2 Form2form2;
        public MenuEkle()
        {
            InitializeComponent();
        }
        public MenuEkle(Form2 f2):this()
        {
            Form2form2 = f2;    
        }

        private void MenuEkle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                Form2form2.mn.MenuEkle(Form2form2, textBox1.Text, Convert.ToDouble(numericUpDown1.Value));
            }
            else
            {
                MessageBox.Show("Menü adı boş olamaz");
            }
            
        }
    }
}
