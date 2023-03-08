using Proje.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Models
{
    internal class Ekstra
    {
        public static Dictionary<string, double> EksMalzemeListesi;
        public Ekstra()
        {
            EksMalzemeListesi= new Dictionary<string, double>();
        }
        public void MalzemeEkle(Form2 frm, string str, double fiyat)
        {
            if (EksMalzemeListesi.ContainsKey(str))
            {
                EksMalzemeListesi[str] = fiyat;
            }
            else
            {
                EksMalzemeListesi.Add(str, fiyat);
                frm.mn.AddExtraOpt(frm, str);
            }
        }

    }
}
