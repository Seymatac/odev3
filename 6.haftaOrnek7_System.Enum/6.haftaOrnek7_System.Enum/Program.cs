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
            string[] sabitler = Enum.GetNames(typeof(Gunler));
            foreach (string s in sabitler)
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
