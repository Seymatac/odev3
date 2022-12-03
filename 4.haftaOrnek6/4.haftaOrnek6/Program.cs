using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.haftaOrnek6
{
    class Program
    {
        static int BuyukBul(int a, int b)
        {
            if (a > b)
            return a;
                     return b;
        }
        static void Main(string[] args)
        {
         int s1, s2;
            Console.Write("Birinci sayıyı girin. ");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı girin. ");
            s2 = Convert.ToInt32(Console.ReadLine());

            int enbuyuk = BuyukBul(s1, s2);
            Console.WriteLine("En büyük {0}'dir", enbuyuk);
            Console.ReadKey();
        }
    }
}
