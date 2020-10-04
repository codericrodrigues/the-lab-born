using System;

namespace ConsoleApp64
{
    class Program
    {
        static void Main(string[] args)
        {

            int contador;
           
            contador = int.Parse(Console.ReadLine());
            
            while (contador < 100) {
                contador = contador + 10;
                Console.WriteLine("contador");
                Console.ReadLine();
            }
        }
    }
}

