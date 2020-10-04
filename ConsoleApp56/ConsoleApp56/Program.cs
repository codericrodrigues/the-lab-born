using System;
using System.Globalization;

namespace ConsoleApp56 { 
    class Program {
        static void Main(string[] args) {

            int codigo1, codigo2, quantidade1, quantidade2;
            double valorPeça1, valorPeça2;

            double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("VALOR A PAGAR: R$", CultureInfo.InvariantCulture);

            Console.ReadLine();


        }
    }
}
