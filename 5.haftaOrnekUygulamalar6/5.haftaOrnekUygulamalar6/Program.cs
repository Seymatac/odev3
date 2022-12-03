using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.haftaOrnekUygulamalar6
{
    class Dortgen
    {
    public int En = 20;
    public int Boy = 5;
    public int Alan(){
    int Alan = En * Boy;
    return Alan; }
    static void Main(){
    Dortgen d1 = new Dortgen();
    Console.WriteLine("***************");
    Console.WriteLine("En:{0}",d1.En);
    Console.WriteLine("Boy:{0}",d1.Boy);
    Console.WriteLine("Alan:{0}",d1.Alan());
    Console.WriteLine("***************");
    Console.ReadKey();
     }
    }
}
