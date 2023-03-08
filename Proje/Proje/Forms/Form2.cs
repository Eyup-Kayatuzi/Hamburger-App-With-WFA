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
    public partial class Form2 : Form
    {
        public MenuAyarlari mn;
        TumSiparis Ts;
        public double ToplamTutar;
        
        public Form2()
        {
            InitializeComponent();
            mn = new MenuAyarlari();
        }
        public Form2(TumSiparis ts) : this()
        {
            Ts = ts;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmb_MalzemeSecimi.DisplayMember = "Isim";
            cmb_MalzemeSecimi.ValueMember = "Fiyat";
            Fonksiyonlar.AddToComboBox(cmb_MalzemeSecimi, mn.YemekListesi);
            ToplamTutar = 0;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string siparis = string.Empty;
            Boyut byt = Boyut.Kucuk;

            siparis += (cmb_MalzemeSecimi.SelectedItem as MenuAyarlari).Isim + " ";
            siparis += $"x {numericUpDown1.Value} Adet, ";
            Fonksiyonlar.CheckForAllRadioBut(panel1.Controls, ref siparis, ref byt);
            Fonksiyonlar.CheckForAllCheckBox(flowLayoutPanel1.Controls, ref siparis);
            siparis += ")";
            DialogResult result = Fonksiyonlar.SendMessage($"Toplam Sipariş Tutarı: {ToplamTutar + Fonksiyonlar.ToplamTutarYaz(cmb_MalzemeSecimi, byt, numericUpDown1) + Fonksiyonlar.CheckForExtraOpt(flowLayoutPanel1.Controls, numericUpDown1)} Satın Almayı Tamamlamak İstermisiniz?", "Sipariş Bilgisi", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                ToplamTutar += Fonksiyonlar.ToplamTutarYaz(cmb_MalzemeSecimi, byt, numericUpDown1) + Fonksiyonlar.CheckForExtraOpt(flowLayoutPanel1.Controls, numericUpDown1);
                Siparis.Ciro += ToplamTutar;
                Siparis.EkMalzemeTutar += Fonksiyonlar.CheckForExtraOpt(flowLayoutPanel1.Controls, numericUpDown1);
                Fonksiyonlar.UpdateLabel(Ts.lbl_Ciro, Siparis.Ciro);
                Fonksiyonlar.UpdateLabel(Ts.lbl_EkstraMalzemeGel, Siparis.EkMalzemeTutar);
                Fonksiyonlar.UpdateLabel(Ts.lbl_SatilanUrunAd, ++Siparis.SatilanUrunAdedi);
                Fonksiyonlar.UpdateLabel(Ts.lbl_SiparisSayisi, ++Siparis.SiparisAdedi);
                Fonksiyonlar.AddToListBox(Ts.listBox1, siparis);
                mn.DefaultMenuItems(listBox1, cmb_MalzemeSecimi, flowLayoutPanel1.Controls, numericUpDown1, lbl_ToplamTutar, out ToplamTutar, rd_Kucuk);
                 
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Siparişe Devam Edilecektir");
                ToplamTutar += Fonksiyonlar.ToplamTutarYaz(cmb_MalzemeSecimi, byt, numericUpDown1) + Fonksiyonlar.CheckForExtraOpt(flowLayoutPanel1.Controls, numericUpDown1);
                Siparis.EkMalzemeTutar += Fonksiyonlar.CheckForExtraOpt(flowLayoutPanel1.Controls, numericUpDown1);
                lbl_ToplamTutar.Text = ToplamTutar.ToString();
                Fonksiyonlar.AddToListBox(listBox1, siparis);
                Fonksiyonlar.AddToListBox(Ts.listBox1, siparis);
                Fonksiyonlar.UpdateLabel(Ts.lbl_SiparisSayisi, ++Siparis.SiparisAdedi);
                
            }
            else
            {

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fonksiyonlar.UpdateLabel(Ts.lbl_Ciro, Siparis.Ciro);
            Fonksiyonlar.UpdateLabel(Ts.lbl_EkstraMalzemeGel, Siparis.EkMalzemeTutar);
            Fonksiyonlar.UpdateLabel(Ts.lbl_SatilanUrunAd, ++Siparis.SatilanUrunAdedi);
            mn.DefaultMenuItems(listBox1, cmb_MalzemeSecimi, flowLayoutPanel1.Controls, numericUpDown1, lbl_ToplamTutar, out ToplamTutar, rd_Kucuk);
        }
    }
}
