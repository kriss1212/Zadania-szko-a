
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _1_potegowanie
{
    internal class Program
    {
        public static void Main()
        {
            int a, b, wynik = 1;
            Console.WriteLine("Wpisz pdstawę");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Wpisz wykładnik");
            b = int.Parse(Console.ReadLine());

            while (b > 0)
            {
                wynik *= a;
                b--;
            }
            Console.WriteLine();
            Console.WriteLine(wynik);
        }
    }
}
