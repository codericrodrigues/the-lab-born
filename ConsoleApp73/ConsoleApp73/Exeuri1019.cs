using System;


namespace Exeuri1019 {
    class Program {
        static void Main(string[] args) {

            //Leia um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma fábrica, e informe-o 
            //(...) expresso no formato horas:minutos:segundos

            int N, horas, resto, minutos, segundos;

            N = int.Parse(Console.ReadLine());
            
            horas = N / 3600;
            resto = N % 3600;

            minutos = resto / 60;
            segundos = minutos % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);

            Console.ReadLine();             
                       
        }
    }
}
