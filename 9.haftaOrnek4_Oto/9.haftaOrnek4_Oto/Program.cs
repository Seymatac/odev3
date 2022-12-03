using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.haftaOrnek4_Oto{
 class oto{
        protected double motor_gucu = 5;
        protected double tork = 800;
        protected string renk = "Sarı";
        public oto(double guc, double tork, string renk){
            this.motor_gucu = guc;
            this.tork = tork;
            this.renk = renk;}
        public void OzellıkGoster(){
            Console.WriteLine("Motor Gücü = " + motor_gucu);
            Console.WriteLine("Tork = " + tork);
            Console.WriteLine("Renk = " + renk);}
        public double Motor_gucu{
            get{
                return motor_gucu;}
            set{
                motor_gucu = value;}}
        public double Tork{
            get{
                return tork;}
            set{
                tork = value;}}
        public string Renk{
            get{
                return renk;}
            set{
                renk = value;}}}
    class model1 : oto{
        public string tur;
        public model1(string tur, double guc, double tork, string renk) : base (guc, tork, renk){
            this.tur = tur; }
        public void TurGoster() {
            Console.WriteLine("Türü = " + tur);}}
    class model2 : oto{
        public string tur;
        public model2(string tur, double guc, double tork, string renk) : base(guc, tork, renk) {
            this.tur = tur;}
        public void TurGoster(){
            Console.WriteLine("Türü = " + tur);}}
    class Program{
        public static void Goster(oto Oto){
            // Console.WriteLine(Oto.Tur); hata verir.
            Console.WriteLine(Oto.Motor_gucu);
            Console.WriteLine(Oto.Tork);
            Console.WriteLine(Oto.Renk);}
        static void Main(string[] args){
            oto oto1 = new oto(75, 100, "Kırmızı");
            Goster(oto1);
            Console.WriteLine("-----------");
            model1 oto2 = new model1("Fiat", 100, 110, "Beyaz");
            Goster(oto2);
            Console.WriteLine("-----------");
            model2 oto3 = new model2("Renault", 100, 120, "Siyah");
            Goster(oto3);
            Console.ReadKey();}}}
