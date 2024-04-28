using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dgunu = new DateTime(2009, 10, 23);
            DateTime simdi = DateTime.Today;
            int yas = simdi.Year - dgunu.Year;
            if(dgunu > simdi.AddYears(-yas));
            yas--;

            Console.WriteLine(yas);
            Console.ReadLine();
        }
    }
}
