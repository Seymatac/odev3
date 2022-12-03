using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.haftaOrnek9
{
    class Program
    {
        static void DegerTipAktarım(int sayi)
        {
            sayi = 30;
        }
        static void Main(string[] args)
        {
            int x = 100;
            Console.WriteLine(x); //100

            DegerTipAktarım(x);
            Console.WriteLine(x); //100
            Console.ReadKey();

        }
    }
}
