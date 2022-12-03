using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.haftaOrnek1_NameSpace
{
    class Deneme
    {
        public Deneme()
        {
            Console.WriteLine("Deneme 1");}}} // birinci çıktı.

namespace _7.haftaOrnek1_NameSpace1
{
    class Deneme
    {
        public Deneme()
        {
            Console.WriteLine("Deneme 2");} } } // ikinci çıktı.
    class Program
    {
        static void Main(string[] args)
        {
        _7.haftaOrnek1_NameSpace.Deneme d1 = new _7.haftaOrnek1_NameSpace.Deneme();
        _7.haftaOrnek1_NameSpace1.Deneme d2 = new _7.haftaOrnek1_NameSpace1.Deneme();
        Console.ReadKey();
        }
    }

