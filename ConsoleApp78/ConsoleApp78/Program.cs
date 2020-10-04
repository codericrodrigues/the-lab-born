using System;
using System.Globalization;

namespace Exeuri1008 {
    class Program {
        static void Main(string[] args) {

            int Funcionario, horastrab;
            double valorhora, salario;

            Funcionario = int.Parse(Console.ReadLine());
            horastrab = int.Parse(Console.ReadLine());
            valorhora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            salario = horastrab * valorhora;

            Console.WriteLine("NUMBER = " + Funcionario);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
