using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.haftaOrnek4_Enumaration
{
    enum notu : byte { basarisiz, basarili }
    class Program
    {
        static void Main()
        {
            notu a = notu.basarili;
            if (a == (notu)1)
            Console.Write("Başarılısınız");
            else
            Console.Write("Başarısızsınız");
            Console.ReadKey();
        }
    }
}
