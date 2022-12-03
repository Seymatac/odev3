using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.haftaOrnek13_ParametreMetot
{
         class Program
         {
            static void Yaz(object o){
                Console.WriteLine("Birinci Metot = " + o);}
            static void Yaz(params object[] o){
             if (o.Length == 0)
                return;
             Console.Write("İkinci Metot = ");
             foreach (object n in o)
             Console.Write(n.ToString() + " ");
             Console.WriteLine();
             Console.ReadKey();}
            static void Main(string[] args)
            {
                Yaz(25); // Birinci Metot = 25
                Yaz("Deneme1", "Deneme2"); // İkinci Metot = Deneme1 Deneme2
                Yaz('a'); // Birinci metot = a
                Yaz('z', 1, 23f, 4, 56, "abc"); //İkinci Metot = z 1 23 4 56 abc
            }
        }
    }


