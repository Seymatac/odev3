using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.haftaOrnek2{
    class A{
        public int x;
        private int y;
        protected int z;
        public A(){
            x = 1;
            y = 2;
            z = 3;
            Console.WriteLine("A yapıcısı çalıştı.");} // birinci

        public void Lİstele(){
            Console.WriteLine("x = {0}; y = {1}; z = {2};", x,y,z);}} //x=1 y=2 z=3
    class T: A{
        public string s;
        public T(){
            s = "Türemiş Sınıf";
            Console.WriteLine("T yapıcısı çalıştı.");} // ikinci
        public void Yaz(){
            Console.WriteLine("s = {0}; x = {1}; z = {2};", s, x, z);}} //s=Türemiş Sınıf x=1 z=3
    class Program{
        static void Main(string[] args){
            T t = new T();
            t.Lİstele();
            t.Yaz();
            Console.ReadKey();}}}
