using System;
using System.Globalization;

namespace exe {
    class Program {
        static void Main(string[] args) {

        int minutos;
        double fatura;

        minutos = int.Parse(Console.ReadLine());
        
        fatura = 50.0;
        if (minutos > 100) {
            fatura += (minutos - 100) * 2.0;
            }
            Console.WriteLine("Valor a pagar: R$ " + fatura.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();                                                     
        }
    }
}
