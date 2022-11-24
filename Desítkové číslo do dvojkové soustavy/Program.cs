using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binární_čísla
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte číslo od 0 do 15");
            int dec = int.Parse(Console.ReadLine());
            if (dec < 0 || dec > 15)
            {
                Console.WriteLine("Chyba zadání");
                Console.ReadLine();
            }
            else
            {
                string bin = Convert.ToString(dec, 2);
                Console.WriteLine("Zadané čísla {0} je ve dvojkové soustavě {1}", dec, bin);
                Console.ReadLine();
            }
        }
    }
}   