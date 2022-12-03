using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.haftaOrnek3_WhileDongu
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0; 
            while (i < 5)
            {
             Console.WriteLine("i = " + i);
             i++;
             Console.ReadKey();
            }
        }
    }
}
           /* i = 0
              i = 1
              i = 2
              i = 3
              i = 4 */