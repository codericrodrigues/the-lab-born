using System;
using System.Globalization;


namespace Exe3 {
    class Program {
        static void Main(string[] args) {

            //fazer um programa para ler um nome (apenas uma palavra) e idade de duas pessoas. Ao final mostrar uma mensagem  com os nomes
            //e a idade média entre as pessoas, com uma casa decimal.

            string nomeM, nomeJ;
            int idadeM, idadeJ;
            double media;

            string[] vet;

            vet = Console.ReadLine().Split(' ');
            nomeM = vet[0];
            idadeM = int.Parse(vet[1]);

            vet = Console.ReadLine().Split(' ');
            nomeJ = vet[0];
            idadeJ = int.Parse(vet[1]);

            media = (idadeM + idadeJ) / 2.0;

            Console.WriteLine("A idade media de " + nomeM + " e " + nomeJ + " é de " 
                + media.ToString("F1", CultureInfo.InvariantCulture) + " anos");

            Console.ReadLine();

        }
    }
}
