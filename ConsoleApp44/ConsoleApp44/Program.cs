using System;
using System.Globalization;

namespace ConsoleApp44 {
    class Program {
        static void Main(string[] args) {

            int N;
            N = int.Parse(Console.ReadLine());

            // Alocação dos vetores
            string[] nomes = new string[N];
            int[] idades = new int[N];
            double[] alturas = new double[N];

            // Leitura dos dados
            for (int i = 0; i < N; i++) {
                string[] s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                idades[i] = int.Parse(s[1]);
                alturas[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
            }

            //Calculo da altura media das pessoas
            double soma = 0.0;
                for (int i=0; i<N; i++) {
                    soma = soma + alturas[i];
                }
            double media = soma / N;
            Console.WriteLine("alturas media: " + media.ToString("F2", CultureInfo.InvariantCulture));

            // Porcentagem das pessoas menores 16 anos
            int cont = 0;
            for (int i=0; i<N; i++) {
                if (idades[i] < 16) {
                    cont++;
                }
            }
            double porcentagem = (double) cont / N * 100.0;
            Console.WriteLine("pessoas menos de 16 anos: " + porcentagem.ToString("F1", CultureInfo.InvariantCulture) + "%");

            Console.ReadLine();  
        }    
    }
}

