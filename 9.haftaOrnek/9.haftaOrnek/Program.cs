using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.haftaOrnek
{
    class oto{
        protected double boy = 5;
        protected double agırlık = 800;
        protected string renk = "Sarı";
        public void goster(){
            Console.WriteLine("Boy = " + boy);
            Console.WriteLine("Ağırlık = " + agırlık);
            Console.WriteLine("Renk = " + renk);}}
    class model1 : oto
    {
        public string tur;
        public int silindir_sayisi;
        public int supap_sayisi;
        public int tork;
        public int guc;
        public void OzellikYaz()
        {
            Console.WriteLine("Tür = " + tur);
            Console.WriteLine("Boy = " + boy);
            Console.WriteLine("Ağırlık = " + agırlık);
            Console.WriteLine("Renk = " + renk);
            Console.WriteLine("Silindir Sayısı = " + silindir_sayisi);
            Console.WriteLine("Supap Sayısı = " + supap_sayisi);
            Console.WriteLine("Tork = " + tork);
            Console.WriteLine("Güç = " + guc);}}

    class model2 : oto {
        public double model2_boy{
            get{
                return boy;}
            set {
                boy = value;}}
        public double model2_agırlık{
            get{
                return agırlık;}
            set{
                agırlık = value;}}
        public string model2_renk{
            get{
                return renk;}
            set{
                renk = value;}}
        public string tur = "Hatchback";
        public int silindir_sayisi = 8;
        public int supap_sayisi = 16;
        public int tork = 300;
        public int guc = 210;
        public void OzellıkYaz()
        {
            Console.WriteLine("Tür = " + tur);
            Console.WriteLine("Boy = " + model2_boy);
            Console.WriteLine("Ağırlık = " + model2_agırlık);
            Console.WriteLine("Renk = " + model2_renk);
            Console.WriteLine("Silindir Sayısı = " + silindir_sayisi);
            Console.WriteLine("Supap Sayısı = " + supap_sayisi);
            Console.WriteLine("Tork = " + tork);
            Console.WriteLine("Güç = " + guc);
        } } 
   class Program{
   static void Main(string[] args) {
            model1 oto1 = new model1();
            model2 oto2 = new model2();
            oto1.tur = "Sedan";
            oto1.silindir_sayisi = 4;
            oto1.supap_sayisi = 8;
            oto1.guc = 75;
            oto1.tork = 100;
            oto1.OzellikYaz();
            Console.WriteLine("***********");
            oto2.model2_boy = 6;
            oto2.model2_agırlık = 900;
            oto2.model2_renk = "kırmızı";
            oto2.OzellıkYaz();
            Console.WriteLine("***********");
            oto2.goster();
            Console.WriteLine("***********");
            oto1.goster();
            Console.ReadKey();}}}
