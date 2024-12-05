using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakOtomasyonu10CKeremBayram
{
    public class Kullanici
    {
        public string KullaniciAdi {  get; set; }
        public string Sifre { get; set; }
        public Kullanici(string user, string password) 
        { 
            this.KullaniciAdi = user;
            this.Sifre = password;
        }
    }
}
