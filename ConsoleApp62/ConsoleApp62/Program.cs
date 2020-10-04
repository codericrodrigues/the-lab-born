using System;
using System.Globalization;

namespace ConsoleApp62 { 
    class Program {
        static void Main(string[] args) {

            int N, x;
            N = int.Parse(Console.ReadLine());
            x = int.Parse(Console.ReadLine());
                                  
            int cont_in = 0;
            int cont_out = 0;

            while (x >= 10 && x <= 20) {
                cont_in = cont_in + 1;
            }
            if (x < 10 && x > 20) {
                N = int.Parse(Console.ReadLine());
                cont_out = cont_out + 1;
            }
                Console.WriteLine(cont_in + " in");
                Console.WriteLine(cont_out + " out");
                Console.ReadLine();
            }                  
        }            
    }






