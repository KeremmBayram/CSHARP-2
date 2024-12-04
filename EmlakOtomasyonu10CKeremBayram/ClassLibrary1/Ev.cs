using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Ev
    {
        public static List<Ev> evler = new List<Ev>(1000);
        public static int sehir = 0;
        public static int id = 1;


        public int OdaSayisi { get; set; }
        public int KatNumarasi { get; set; }
        public string Semt { get; set; }
        public DateTime YapimTarihi { get; set; }
        public bool Aktif { get; set; }
        public decimal EmlakNumarasi { get; set; }
        public decimal Alan { get; set; }
        public int Yas { get; set; }

        public int TuruSayi = 0;
        public string Turu { get; set; }
        public string Il { get; set; }
        public enum turu
        {
            Daire, Dubleks, Bahceli, Mustakil, Rezidans, Villa
        }
        DateTime dt = DateTime.Now;
        public Ev(

           int OdaSayisi = 1,
           int KatNumarasi = 0,
           string Il = "İstanbul",
           string Semt = "Ümraniye",
           decimal Alan = 10,
           int TuruSayi = 0,
           string turu = "Satilik",
           bool Aktif = true,
           DateTime dt = new DateTime())
        {
            this.Il = Il;
            if (OdaSayisi >= 1)
            {
                this.OdaSayisi = OdaSayisi;
            }
            else
            {
                this.OdaSayisi = 0;
                this.KatNumarasi = KatNumarasi;
                this.Semt = Semt;
                if (Alan > 0)
                {
                    this.Alan = Alan;
                }
                else
                {
                    this.Alan = 0;
                }
                if (DateTime.Now > dt)
                {
                    this.YapimTarihi = dt;
                }
                else
                {
                    this.YapimTarihi = DateTime.Now;
                }
                Yas = DateTime.Now.Year - YapimTarihi.Year;
                EmlakNumarasi = Convert.ToDecimal(Convert.ToInt32(sehir.ToString() + YapimTarihi.Year.ToString()) * 1000 + id);
                this.TuruSayi = TuruSayi;
                this.Turu = turu;
                this.Aktif = Aktif;
            }
        }
        virtual public string EvBilgileri()
        {
            return string.Format("Oda Sayisi: {0} Kat Numarası: {1} Semt: {2} Alan: {3} Türü: {4} Yaşı: {5}", OdaSayisi, KatNumarasi, Semt, Alan, (turu)TuruSayi, Yas);
        }
        public static int FiyatHesapla(int odaSayisi, string turu)
        {
            string dosyaYol = "../../odaUcreti.txt";
            int katsayi = 1;
            if (!File.Exists(dosyaYol))
            {
                katsayi = 200;
                return katsayi * odaSayisi;
            }
            FileStream fs = new FileStream(dosyaYol, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs, Encoding.GetEncoding("windows-1254"));
            string yazi = sw.ReadLine();
            while (yazi != null)
            {
                string[] dizi = yazi.Split('|');
                if (dizi[0].Equals(turu))
                {
                    katsayi = int.Parse(dizi[1]);
                    yazi = sw.ReadLine();
                }
            }
            sw.Close();
            fs.Close();
            return katsayi * odaSayisi;
        }
    }

    public class KiralikEv : Ev
    {
        public decimal Kira, Depozito;

        public KiralikEv(int odaSayisi, int katNumarasi, string il, string semt, decimal alan, int turuSayi, string turu, bool aktif, DateTime yapimTarihi, decimal kira = 800, decimal depozito = 100) : base(odaSayisi, katNumarasi, il, semt, alan, turuSayi, turu, aktif, yapimTarihi)
        {
            if (kira > 0)
            {
                this.Kira = kira;
            }
            else
            {
                this.Kira = 0;
            }
            if (depozito > 0)
            {
                this.Depozito = depozito;
            }
            else
            {
                this.Depozito = 0;
            }
        }
        public KiralikEv(int odaSayisi, int katNumarasi, string il, string semt, decimal alan, int turuSayi, string turu, bool aktif, DateTime yapimTarihi, decimal kira = 800, decimal depozito = 100, decimal emlakNumarasi = 1111111) : base(odaSayisi, katNumarasi, il, semt, alan, turuSayi, turu, aktif, yapimTarihi)
        {

        }
        public class SatilikEv : Ev
        {
            public decimal Fiyat;

            public SatilikEv(int odaSayisi, int katNumarasi, string il, string semt, decimal alan, int turuSayi, string turu, bool aktif, DateTime yapimTarihi, decimal fiyat = 800, decimal emlakNumarasi = 11111) : base(odaSayisi, katNumarasi, il, semt, alan, turuSayi, turu, aktif, yapimTarihi)
            {
                if (fiyat > 0)
                {
                    this.Fiyat = fiyat;
                }
                else
                {
                    this.Fiyat = 0;
                }
            }
        }
    }
}
