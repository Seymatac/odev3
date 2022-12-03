using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    enum Gunler : byte
    {
        pazartesi,
        salı,
        carsamba,
        persembe,
        cuma,
        cumartesi,
        pazar
    }
    class Numaralandirma
    {
        public static void Main()
        {
            Console.WriteLine((int)Gunler.pazartesi); // 0
            Console.WriteLine((int)Gunler.pazar);     // 6
            Console.ReadKey();
        }
    }

