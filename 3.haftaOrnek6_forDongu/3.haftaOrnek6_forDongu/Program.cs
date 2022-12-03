using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.haftaOrnek6_forDongu
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0, j = 0; i < 20; i++, j++)
            {
                i *= j;
                Console.WriteLine("i = " + i + " " + "j = " + j);
                Console.ReadKey();
            }}}}
                 /* i = 0 j = 0
                    i = 1 j = 1
                    i = 4 j = 2
                    i = 15 j =3
                    i = 64 j = 4 */