using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.haftaOrnek7
{
    class Program
    {
        static int BuyukBul(int a, int b){
            if(a > b)
            return a;
                     return b;}
        static int BuyukBul3 (int a, int b, int c){
            return BuyukBul(a, BuyukBul(b, c));}
        static void Main(string[] args){
            int s1, s2, s3;
            Console.Write("Birinci sayıyı girin. ");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı girin. ");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Üçüncü sayıyı girin. ");
            s3 = Convert.ToInt32(Console.ReadLine());

            int enbuyuk = BuyukBul3(s1, s2, s3);
            Console.WriteLine("En büyük {0}'dir ", enbuyuk);
            Console.ReadKey();
        }
    }
}
