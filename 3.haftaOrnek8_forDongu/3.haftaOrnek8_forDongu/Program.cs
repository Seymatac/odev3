﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.haftaOrnek8_forDongu
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, a, n;
            Console.WriteLine("Bir sayı girin");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Artım Miktarı");
            a = Convert.ToInt32(Console.ReadLine());
            for (; i < n ;)
            {
                Console.Write("{0}", i);
                i += a;
            }
            Console.ReadKey();
         }
    }
}
