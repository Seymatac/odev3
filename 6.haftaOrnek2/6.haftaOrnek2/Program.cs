using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.haftaOrnek2
{
  class indexleyici{
       public double rakam;
       public double this[double index]{
            get{
            return Math.Pow(index, 2);}
            set {
            rakam = value; }}}
    class indexleyicistart
    {
        static void Main()
        {

            indexleyici i = new indexleyici();
            Console.WriteLine("i[3.4]={0}", i[3.4]); // 3.4*3.4 = 11.56
            i[10] = 10;
            Console.WriteLine(i.rakam); // 10
            i[10] = 15;
            Console.WriteLine(i.rakam); // 15
            Console.WriteLine("i[10]={0}", i[10]); // 10*10 = 100
            Console.ReadKey();
        }
    }
}
