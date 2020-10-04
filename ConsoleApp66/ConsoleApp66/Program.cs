using System;
using System.Globalization;

namespace ConsoleApp66 {
    class Program {
        static void Main(string[] args) {

            int x;
            double[] A;

            x = int.Parse(Console.ReadLine());
            A = new double[x];

            for (int i = 0; i < x; i++)
            {
                A[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                x = x + 1;
            }
        }
    }
}



        
                    
        
    

