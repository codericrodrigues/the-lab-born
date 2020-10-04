using System;


namespace ConsoleApp12 {
    class Program {
        static void Main(string[] args) {

            string[] valores = Console.ReadLine().Split(' ');

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            if (b > c && d > a && +d > a + b && c > 0 && d > 0 && a % 2 == 0) {
                Console.WriteLine("Valores aceitos");
            }
            else {
                Console.WriteLine("Valores aceitos");
            }
        }
    }
}     
