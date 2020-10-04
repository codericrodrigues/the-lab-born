using System;


namespace ConsoleApp29 {
    class Program {
        static void Main(string[] args) {

            int i;

            i = int.Parse(Console.ReadLine());

            for (i=0; i<5; i++) {
                Console.WriteLine("Valor de i: " + i);
            }
            Console.ReadLine();
        }
    }
}
