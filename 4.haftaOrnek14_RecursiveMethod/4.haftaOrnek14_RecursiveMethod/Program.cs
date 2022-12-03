using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.haftaOrnek14_RecursiveMethod
{
    class faktoriyel
    {
        static int Faktoriyel(int a)
        {
            if (a == 0)
            return 1;
            return a * Faktoriyel(a - 1); // rekürsif yapı.
        }
        static void Main()
        {
            Console.Write(" Herhangi bir sayı giriniz = ");
            int fak_deg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Sayının faktöriyeli = " + Faktoriyel(fak_deg));
            Console.ReadKey();
        }
    }
}