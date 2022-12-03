using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.haftaOrnekUygulamalar2
{
    class Ogrenci
    {
        public ulong OgrenciNo;
        public string Ad;
        public string Soyad;
        public string Bolum;
        public byte Sinif;
    }
    class Program
    {
        static void Main()
        {
            Ogrenci ogr = new Ogrenci();
            Console.WriteLine(ogr.OgrenciNo);
            Console.WriteLine(ogr.Ad);
            Console.WriteLine(ogr.Soyad);
            Console.WriteLine(ogr.Bolum);
            Console.WriteLine(ogr.Sinif);
            Console.ReadKey();
        }
    }
}
