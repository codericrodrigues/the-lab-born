using System;

namespace uri1113 {
    class Program {
        static void Main(string[] args) {

            int x, y;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            Console.Write(x);
            Console.Write(y);
                                 
            while (x < y) { 
                Console.WriteLine("DECRESCENTE");
                while (x > y) ;
                Console.WriteLine("CRESCENTE");
            }
            Console.ReadLine();
        }
    }
}
