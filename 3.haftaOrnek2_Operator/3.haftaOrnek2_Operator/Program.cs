using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.haftaOrnek2_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2; int b = 3; int c = 6;

            Console.WriteLine(" (a & b) = " + (a & b)); //2
            Console.WriteLine(" (a | b) = " + (a | b)); //3
            Console.WriteLine(" (a ^ b) = " + (a ^ b)); //1
            Console.WriteLine(" ( ~a ) = " + (~a)); //-3
            Console.WriteLine(" ( ~b ) = " + (~b)); //-4
            Console.WriteLine(" ( ~c ) = " + (~c)); //-7
            Console.ReadKey();
        }
    }
}
