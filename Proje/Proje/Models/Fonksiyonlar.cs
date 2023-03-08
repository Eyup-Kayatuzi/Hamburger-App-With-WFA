using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje.Models
{
    internal class Fonksiyonlar
    {
        public static void UpdateLabel(Label lbl, dynamic vl)
        {
            lbl.Text = vl.ToString();
        }
        public static void AddToListBox(ListBox lst, string data)
        {
            lst.Items.Add(data);
        }
        public static void AddToComboBox(ComboBox cb, Dictionary<string, double> lst)
        {
            cb.Items.Clear();
            foreach (var item in lst)
            {
                cb.Items.Add(new MenuAyarlari { Isim = item.Key.ToString(), Fiyat = item.Value });
            }
            cb.SelectedIndex = 0;
        }
        public static void AddSingleMenu(ComboBox cb, string str, double fiyat)
        {
            cb.Items.Add(new MenuAyarlari { Isim = str, Fiyat = fiyat });
        }
        public static double ToplamTutarYaz(ComboBox cb, Boyut byt, NumericUpDown nmr)
        {
            double dondur;
            if (byt == Boyut.Kucuk)
            {
                dondur = (cb.SelectedItem as MenuAyarlari).Fiyat;
            }
            else if (byt == Boyut.Orta)
            {
                dondur = (cb.SelectedItem as MenuAyarlari).Fiyat + 5;
            }
            else
            {
                dondur = (cb.SelectedItem as MenuAyarlari).Fiyat + 10;
            }
            return dondur * Convert.ToDouble(nmr.Value);

        }
        public static void CheckForAllRadioBut(Object crt, ref string str, ref Boyut byt)
        {
            foreach (var item in (dynamic)crt)
            {
                if ((item as RadioButton).Checked == true)
                {
                    str += (item as RadioButton).Text + "Boy" + " (";
                    Enum.TryParse((item as RadioButton).Text, out byt);
                    break;
                }

            }
        }
        public static DialogResult SendMessage(string msj, string title, MessageBoxButtons btn)
        {
            DialogResult result = MessageBox.Show(msj, title, btn);
            if (result == DialogResult.Yes)
            {
                return DialogResult.Yes;
            }
            else if (result == DialogResult.Cancel)
            {
                return DialogResult.Cancel;
            }
            else
            {
                return DialogResult.No;
            }
        }
        public static void CheckForAllCheckBox(Object crt, ref string str)
        {
            foreach (var item in (dynamic)crt)
            {
                if ((item as CheckBox).Checked == true)
                {
                    str += (item as CheckBox).Text + " ";

                }
            }
        }
        public static double CheckForExtraOpt(Object crt, NumericUpDown nmr)
        {
            double dondur = 0;
            foreach (var item in (dynamic)crt)
            {
                if ((item as CheckBox).Checked == true)
                {
                    if (Ekstra.EksMalzemeListesi.ContainsKey((item as CheckBox).Text))
                    {
                        dondur += Ekstra.EksMalzemeListesi[(item as CheckBox).Text];
                    }
                }
            }
            return dondur * Convert.ToDouble(nmr.Value);
        }
        public static void MakeUnCheckForAllCheckBox(Object crt)
        {
            foreach (var item in (dynamic)crt)
            {
                if (item is CheckBox)
                {
                    if ((item as CheckBox).Checked == true)
                    {
                        (item as CheckBox).Checked = false;
                    }
                }

            }
        }

    }
}
