using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.haftaOrnekUygulamalar11
{
    // 1'den 100'e kadar olan sayıların toplamı
    class Topla
    {
        public int tpl;
        public Topla (int Toplam)
        {
            tpl = Toplam; }
        public int Toplama
        {
            get {                   // değeri görüntüle
                return tpl;}
            set {                   // yeni değeri depola
                tpl = value + tpl; }
        }
        static void Main(string[] args)
        {

           Topla ekle = new Topla(0);
           Console.WriteLine("Başlangıç değeri=" + ekle.Toplama);
           for (int i = 1; i < 100; i++)
           ekle.Toplama = i; 
           Console.WriteLine("Sayıların toplamı" + ekle.Toplama);
           Console.ReadKey();



        }
    }
}
