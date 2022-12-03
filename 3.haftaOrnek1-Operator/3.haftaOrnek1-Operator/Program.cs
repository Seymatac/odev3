using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.haftaOrnek1_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2; int b = 3; int c = 6; int d = 1;

            Console.WriteLine(" (a<b) && (c<d) = " + ((a<b) && (c<d))); //False
            Console.WriteLine(" (a<b) || (c<d) = " + ((a < b) || (c < d))); //True
            Console.WriteLine(" !(a<b) = " + (!(a<b))); //False
            Console.WriteLine(" (a<b) & (c<d) = " + ((a < b) & (c < d))); //False
            Console.WriteLine(" (a<b) | (c<d) = " + ((a < b) | (c < d))); //True
            Console.WriteLine(" (a<b) ^ (c<d) = " + ((a < b) ^ (c < d))); //True
            Console.ReadKey();
        }
    }
}
