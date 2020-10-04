using System;
using System.Globalization;

namespace ConsoleApp60 { 
    class Program {
        static void Main(string[] args) {

            double idade, soma, media;
            int cont;

            idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            cont = 0;
            soma = 0.0;
            while (idade >= 0) {
                soma = idade + soma;
                cont = cont + 1;
                idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            if (cont == 0) {
                Console.WriteLine("Impossivel calcular");
            }
            media = soma / cont;
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}

