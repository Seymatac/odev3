using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.haftaOrnek5_NameHiding{
    class X{
        protected int a;
        public X (int a){
            Console.WriteLine("X = " + a); // X = 5   X = 6
            this.a = a;}
        public int A{
            get{
                Console.WriteLine("X Sınıfı = " + a); // X Sınıfı = 6
                return a;}}}
    class Y : X{
        protected int b;
        public Y(int a) : base(a){
            Console.WriteLine("Y = " + a); // Y = 5
            this.b = a;}
        new public int A{
            get{
                Console.WriteLine("Y sınıfı = " + b); // Y Sınıfı = 5
                return b;}}}
    class Program{
        static void Main(){
            Y y = new Y(5);
            X yy = new X(6);
            int deneme = y.A;
            int deneme2 = yy.A;
            Console.ReadKey();}}}

