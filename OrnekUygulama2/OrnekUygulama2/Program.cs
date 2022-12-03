using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekUygulama2
{
    class Program{
        static void Main(string[] args){
            int[,] dizi1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 2, 3, 4 } };
            int[,] dizi2 = { { 2, 4, 6 }, { 3, 4, 5 }, { 5, 7, 9 } };
            int[,] dizi3 = new int[3, 3];

            for (int i = 0; i < 3; i++){
                for (int j = 0; j < 3; j++){
                    for (int t = 0; t < 3; t++){
                        dizi3[i, j] += dizi1[i, t] * dizi2[t, j];}}}
            for (int j = 0; j < 3; j++){
                
                for (int t = 0; t < 3; t++){
                    Console.Write("{0}",dizi3[j, t]);
                    Console.ReadKey();
                }}}}}
  /*  23  33  43
      53  78 103
     333 483 633 */
    
