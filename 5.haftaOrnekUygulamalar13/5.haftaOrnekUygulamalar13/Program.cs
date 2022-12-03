using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.haftaOrnekUygulamalar13
{
    class Program{ 
    // Random rnd = new Random(); //kullanılsaydı yine farklı değer üretirdi.
    public int Zar(){
    Random rnd = new Random();
    return rnd.Next(1,7); }
    public static void metotlar(int a, int b, int c){
    Console.WriteLine("a= "+a + " b= "+b + " c= "+c); }
    static void Main(string[] args){
     //Program a = new Program();   // her bir değişken için aynı değerleri üretirdi.
     //metotlar(a.Zar(), a.Zar(), a.Zar());
    Random rnd = new Random();
    Program a = new Program();
    metotlar(rnd.Next(1, 7), rnd.Next(1, 7), rnd.Next(1, 7));
    Console.ReadKey();
    }
   }
  }