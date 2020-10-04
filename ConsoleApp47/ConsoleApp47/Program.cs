using System;
using System.Globalization;

namespace ConsoleApp47 {
    class Program {
        static void Main(string[] args) {

            int N;
            double[] nreais;
            N = int.Parse(Console.ReadLine());
            nreais = new double[N];

            string[] s = Console.ReadLine().Split(' ');

            for (int i=0; i < N; i++) {
                nreais[i] = double.Parse(s[N], CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Maior elemento: " + nreais.ToString(),"F1", CultureInfo.InvariantCulture);
                      

            Console.ReadLine();
        }
    }
}
