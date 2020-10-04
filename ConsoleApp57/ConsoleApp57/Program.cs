using System;
using System.Globalization;

namespace ConsoleApp57 {
    class Program {
        static void Main(string[] args) {

            int codigo1, quantidade1, codigo2, quantidade2;
            double valor1, valor2, total;

            valor1 = int.Parse(Console.ReadLine());
            total = double.Parse(Console.ReadLine());

            string[] vet = Console.ReadLine().Split(' ');

            valor1 = double.Parse(vet[0]);
            valor2 = double.Parse(vet[1]);

                           
            Console.WriteLine("VALOR A PAGAR: R$" + total.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
             

        }
    }
}
