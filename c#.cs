using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sifre
{
    class Program
    {
        static void Main(string[] args)
        {
            string dogruSifre = "kerem1234";
            int denemeHakki = 3;

            while (denemeHakki > 0)
            {
                Console.Write("Lütfen Şifreyi Girin: ");
                string girilenSifre = Console.ReadLine();

                if (girilenSifre == dogruSifre)
                {
                    Console.WriteLine("Şifre Doğru. Giriş Yapıldı!");
                    break;
                }
                else
                {
                    denemeHakki--;
                    if (denemeHakki == 0)
                    {
                        Console.WriteLine("Giriş hakkınız kalmadı. Program sonlandırılıyor.");
                    }
                    else
                    {
                        Console.WriteLine($"Yanlış şifre. Kalan deneme hakkınız: {denemeHakki}");
                    }
                }
                Console.ReadLine();
            }
        }
    }
}
