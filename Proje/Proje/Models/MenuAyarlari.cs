using Proje.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje.Models
{
    public class MenuAyarlari
    {
        Form2 F2;
        public string Isim { get; set; }
        public double Fiyat { get; set; }

        public Dictionary<string, double> YemekListesi;
        public MenuAyarlari()
        {

            YemekListesi = new Dictionary<string, double>() { { "Steakhouse", 65 }, { "Big King Chicken", 50 }, { "BigKing", 55 }, { "Whooper", 52 }, { "Whooper Jr.", 44 }, { "Chicken Royal", 51 } };
        }
        public MenuAyarlari(Form2 f2)
        {
            F2 = f2;
        }
        public void AddNewCheckBox(Form2 fr2, string ism)
        {
            CheckBox chc = new CheckBox();
            chc.Text = ism;
            chc.Font = new Font("Arial Narrow", 12, FontStyle.Bold); //Arial Narrow, 8.25pt, style=Bold
            fr2.flowLayoutPanel1.Controls.Add(chc);
        }
        
        public void AddExtraOpt(Form2 fr2, string str)
        {
            AddNewCheckBox(fr2, str);
        }
        public void MenuEkle(Form2 f2, string isim, double fiyat)
        {
            if (YemekListesi.ContainsKey(isim))
            {
                YemekListesi[isim] = fiyat;
                Fonksiyonlar.AddToComboBox(f2.cmb_MalzemeSecimi, YemekListesi);
            }
            else
            {
                YemekListesi.Add(isim, fiyat);
                Fonksiyonlar.AddSingleMenu(f2.cmb_MalzemeSecimi, isim, fiyat);
            }

        }
        public void DefaultMenuItems(ListBox lst, ComboBox cmb, Object obj, NumericUpDown nmr, Label lbl,
            out double toplamTutar, RadioButton rd)
        {
            lst.Items.Clear();
            cmb.SelectedIndex = 0;
            Fonksiyonlar.MakeUnCheckForAllCheckBox(obj);
            nmr.Value = 1;
            lbl.Text = string.Empty;
            toplamTutar = 0;
            rd.Checked = true;
        }
    }
}
