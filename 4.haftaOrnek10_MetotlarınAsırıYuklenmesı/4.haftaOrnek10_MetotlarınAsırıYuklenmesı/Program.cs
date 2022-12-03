using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.haftaOrnek10_MetotlarınAsırıYuklenmesı
{
    class Program
    {
        static void Metot1(float x, float y)
        {
            Console.WriteLine("Birinci metot çağrıldı. ");
        }
        static void Metot1(double x, double y)
        {
            Console.WriteLine("İkinci metot çağrıldı. ");
        }

        static void Main()
        {
            Metot1(5, 6); // Birinci metot çağrıldı.(en az kapasiteli türlü metot çağrıldı.)
            Console.ReadKey();
        } } }


