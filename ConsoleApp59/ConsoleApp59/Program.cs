using System;

namespace ConsoleApp59
{
    class Program
    {
        static void Main(string[] args)
        {

            int X, Y;
            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());

            while (X != Y)
            {
                if (X < Y)
                {
                    Console.WriteLine("Crescente");
                }
                else if (X > Y)
                {
                    Console.WriteLine("Decrescente");
                    Console.ReadLine();
                }
            }
        }
    }
}






