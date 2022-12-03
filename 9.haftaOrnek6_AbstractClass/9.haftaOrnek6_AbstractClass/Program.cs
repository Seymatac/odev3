using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.haftaOrnek6_AbstractClass
{
    abstract class OgrNot{ 
         public int vize;
         public int final;
         public OgrNot (int v, int f){
         vize = v;
         final = f;}}

    class ögr : OgrNot{
        public string str;
        public ögr(string ad, int vize, int final) : base(vize, final){
        str =ad;}
        public void AdGöster(){
        Console.WriteLine("Öğrenci Adı = " + str);
        Console.WriteLine("Vize Notu = " + vize + "\n" + "Final Notu = " + final); }}
    class Ana_sınıf{
    static void Main(){
    ögr d = new ögr("Erkan Tanyıldızı", 77, 98);
    d.AdGöster();
    Console.ReadKey(); }}}
