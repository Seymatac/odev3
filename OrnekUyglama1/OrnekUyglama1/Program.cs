using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekUyglama1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = {54, 2145, 2154, 2, 54, 1212, 15, 025, 15450, 14572};
            foreach (int dzi in dizi)
            {
                Console.WriteLine(dzi + " ");
            }
            Console.WriteLine("*****************");
            Console.WriteLine("Dizinin tersten yazılışı = ");
            Array.Reverse(dizi);
            foreach (int dzi in dizi)
            {
                Console.WriteLine(dzi + " ");
            }
            Console.ReadKey();
        }
    }
}
