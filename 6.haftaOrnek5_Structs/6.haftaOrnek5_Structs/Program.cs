using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.haftaOrnek5_Structs
{
    struct üniversite{
    public string fakulte;
    public string bolum;
    public string ogrgor;
    public üniversite(string a, string b, string c){
    fakulte = a;
    bolum = b;
    ogrgor = c; }}
    class structornek { 
         public static void Main(){

    üniversite k1 = new üniversite("Teknoloji Fakültesi", "Yazılım Mühendisliği", "2.sınıf");
    üniversite k2;
    Console.WriteLine(k1.fakulte);    // Teknoloji Fakültesi
    Console.WriteLine(k1.bolum);     // Yazılım Mühendisliği
    Console.WriteLine(k1.ogrgor);   // 2.sınıf
    k2.fakulte ="Tıp Fakultesi";
    Console.WriteLine(); //
    Console.WriteLine(k2.fakulte); // Tıp Fakültesi
    Console.ReadKey();
 }
}

}
