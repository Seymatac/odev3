using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.haftaOrnek_NameSpace
{
    class Deneme
    {
        public int a;
        public int b;

        public Deneme(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public static int Topla(int x, int y) {
            return x + y;
        }}}
    class Program
    {
        static void Main(string[] args)
        {
            _7.haftaOrnek_NameSpace.Deneme d = new _7.haftaOrnek_NameSpace.Deneme(1, 2);
            Console.WriteLine(d.a); // 1
            Console.WriteLine(_7.haftaOrnek_NameSpace.Deneme.Topla(2, 3)); // 5
            Console.ReadKey();
        }
    }

