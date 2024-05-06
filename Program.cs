using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rastgele = new Random();
            int tahminedileceksayi = rastgele.Next(0,11);
            int tahminedilensayi = -1;


            while (tahminedileceksayi != tahminedilensayi)
            {
                Console.WriteLine("lütfen 0-10 arası bir sayı giriniz");
                tahminedilensayi = Convert.ToInt32(Console.ReadLine());

                if (tahminedilensayi == tahminedileceksayi)
                {
                    Console.WriteLine("tahmininiz doğru");

                }
                else if (tahminedilensayi < tahminedileceksayi)
                {
                    Console.WriteLine("lütfen daha büyük bir sayı giriniz");
                }
                else 
                {
                    Console.WriteLine("lütfen daha küçük bir sayı giriniz");
                }
                
            }
            
            Console.Read();
        }
        
    }
}
