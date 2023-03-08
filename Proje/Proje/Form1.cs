using Proje.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class Form1 : Form
    {
        Form2 F2;
        TumSiparis TS;
        MenuEkle ME;
        EkstraMalzeme EXM;
        public Form1()
        {
            InitializeComponent();

            TS = new TumSiparis();
            TS.MdiParent = this;
            F2 = new Form2(TS);
            F2.MdiParent = this;
            ME = new MenuEkle(F2);
            ME.MdiParent = this;  
            EXM = new EkstraMalzeme(F2);
            EXM.MdiParent = this;   
        }

        private void siparişYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void siparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (ActiveMdiChild != null)
                ActiveMdiChild.Hide();
            F2.Show();
            //F2.BringToFront();
        }

        private void siparişBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Hide();
            TS.Show();
            //TS.BringToFront();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menüEjkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Hide();
            ME.Show();
        }

        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Hide();
            EXM.Show();
        }
    }
}
