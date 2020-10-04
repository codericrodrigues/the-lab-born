using System;
using System.Globalization;

namespace ConsoleApp53 { 
    class Program {
        static void Main(string[] args) {

            double N, media, nota1, nota2, nota3, nota4;

            N = int.Parse(Console.ReadLine());
            
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
