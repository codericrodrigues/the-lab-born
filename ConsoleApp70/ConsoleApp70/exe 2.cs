using System;
using System.Globalization;


namespace Exe2 {
    class Program {
        static void Main(string[] args) {

            //fazer um programa para ler as medidas da base e altura de um retângulo. Em seguida, mostrar o valor da area, perímetro e 
            //... diagonal deste retângulo, com quatro casas decimais.
            double area,perimetro, diagonal, b, h;
            
            b = double.Parse(Console.ReadLine());
            h = double.Parse(Console.ReadLine());

            area = b * h;
            perimetro = 2.0 * (b + h);
            diagonal = perimetro / 2.0;

            Console.WriteLine("AREA = " + area.ToString("F4"), CultureInfo.InvariantCulture);
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4"), CultureInfo.InvariantCulture);
            Console.WriteLine("DIAGONAL =  " + diagonal.ToString("F4"), CultureInfo.InvariantCulture);

            Console.ReadLine();
        }

    }
}

