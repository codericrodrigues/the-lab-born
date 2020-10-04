using System;

namespace ConsoleApp65 {
    class Program {
        static void Main(string[] args) {

            int N, idade, soma, cont;
            double media;

            

            N = int.Parse(Console.ReadLine());
           

            soma = 0;
            for (int i=1; i<=N; i++) {
                idade = int.Parse(Console.ReadLine());
                soma = soma + idade;
            }
            media = soma / N;
            Console.WriteLine("MEDIA" + " media");
            Console.ReadLine();

        }
    }
}
