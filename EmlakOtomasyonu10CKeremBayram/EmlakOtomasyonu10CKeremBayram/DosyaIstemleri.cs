
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using ClassLibrary1;
using static ClassLibrary.Ev;
using static ClassLibrary.KiralikEv;

namespace EmlakOtomasyonu10CKeremBayram
{
    class DosyaIstemleri
    {
        public static void DosyaIdBelirleme()
        {
            FileStream fs = new FileStream("../../satilik.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string yazi = sr.ReadLine();

            while (yazi != null)
            {
                yazi = sr.ReadLine();
                Console.WriteLine("+1 Satilik");
                Ev.id += 1;
            }
            sr.Close();
            fs.Close();

            fs = new FileStream("../../kiralik.txt", FileMode.Open, FileAccess.Read);
            sr = new StreamReader(fs);
            yazi = sr.ReadLine();
            while (yazi != null)
            {
                yazi = sr.ReadLine();
                Console.WriteLine("+1 Kiralik");
                Ev.id += 1;
            }
            sr.Close();
            fs.Close();
        }
        public static List<Kullanici> DosyaOkuma(string Dosyayolu)
        {
            FileStream fs = new FileStream(Dosyayolu, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            List<Kullanici> kullanicilar = new List<Kullanici>();
            string yazi = sr.ReadLine();

            while (yazi != null)
            {
                string[] parca = yazi.Split('|');
                kullanicilar.Add(new Kullanici(parca[0], parca[1]));
                yazi = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
            return kullanicilar;
        }
        public static List<string> DosyaOkumaSemt(string Dosyayolu, string il)
        {
            FileStream fs = new FileStream(Dosyayolu, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            List<string> semtler = new List<string>();
            string yazi = sr.ReadLine();
            while (yazi != null)
            {
                string[] parca = yazi.Split('|');
                if (il.Equals(parca[0]))
                {
                    semtler.Add(parca[1]);
                }
            }
            fs.Flush();
            sr.Close();
            fs.Close();
            return semtler;
        }
        public static void DosyaSatilikYazmak(string Dosyayolu, string durum)
        {
            if (!File.Exists(Dosyayolu))
            {
                File.Create(Dosyayolu);
            }
            FileStream fs = new FileStream(Dosyayolu, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            
            foreach( SatilikEv ev in SatilikEv.evler)
            {
                if (ev.Turu.Equals("Satilik"))
                {
                    sw.WriteLine(ev.EmlakNumarasi + "|" + ev.OdaSayisi + "|" + ev.KatNumarasi + "|" + ev.Il + "|" + ev.Semt + "|" + ev.Alan + "|" + ev.TuruSayi + "|" + ev.Aktif + "|" + ev.YapimTarihi + "|" + ev.Fiyat);
                }
            }
            sw.Close();
            fs.Close();
        }
        public static List<SatilikEv> DosyaSatilikEvOkuma()
        {
            List<SatilikEv> evler = new List<SatilikEv>();
            string dosya_yolu = @"../../satilik.txt";

            if (!File.Exists(dosya_yolu))
            {
                MessageBox.Show("Satilik Dosya Bulunamadı");
            }
            else
            {
                FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string yazi = sr.ReadLine();
                while (yazi != null) 
                { 

                }
            }
            return evler; 
        }
    }
}