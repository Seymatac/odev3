using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.haftaOrnek11_MetodlarınAsırıYuklenmesı
{
    class Program
    {
            static void Metot1(float x, float y)
            {
                Console.WriteLine("Birinci metot çağrıldı.");
            }
            static void Metot1(int x, int y)
            {
                Console.WriteLine("İkinci metot çağrıldı.");
            }
            static void Main()
            {
                Metot1('f', 'g'); //İkinci metod çağrılır.(int floata göre az kapasiteli.)
                Console.ReadKey();
            }
        }
    }


