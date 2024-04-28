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
            Console.WriteLine("lütfen ilk sayıyı giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("lütfen ikinci sayıyı giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int toplam;

            Console.WriteLine(toplam = sayi1 + sayi2);
            Console.Read();
        }
    }
}
