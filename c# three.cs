using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayi1, sayi2, toplam, fark, carpim, bolum;
            Console.Write("1. Sayı : ");
            sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2. Sayı : ");
            sayi2 = Convert.ToDouble(Console.ReadLine());
            toplam = sayi1 + sayi2;
            fark = sayi1 - sayi2;
            carpim = sayi1 * sayi2;
            bolum = sayi1 / sayi2;
            Console.WriteLine("{0} ve {1} Sayısının Toplamı : {2}", sayi1, sayi2, toplam);
            Console.WriteLine("{0} ve {1} Sayısının Farkı : {2}", sayi1, sayi2, fark);
            Console.WriteLine("{0} ve {1} Sayısının Çarpımı : {2}", sayi1, sayi2, carpim);
            Console.WriteLine("{0} ve {1} Sayısının Bölümü : {2}", sayi1, sayi2, bolum);
            Console.ReadKey();
        }
    }
}
