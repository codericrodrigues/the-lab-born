using System;
using System.Globalization;


namespace TempoÉDinheiro
{
    class Program
    {
        static void Main(string[] args)
        {

            //Uma empresa estrangeira de autopeças para carros decide abrir uma filial no Brasil.
            //Esta empresa contratou 10 funcionários. Dois fatores são essenciais para esta
            //empresa medir o desempenho de seus funcionários, são eles: tempo e valor em vendas.
            //No primeiro trimestre, fizeram análise de horas trabalhadas e vendas, baseados nos 
            //produtividade, comparando a quantidade de horas mensais dos vendedores
            //fatores tempo e valor total das vendas dos 3 vendedores contratados. 
            //Obs: Considerando que os vendedores devem cumprir carga horária mensal de 144 horas e todos trabalham no mesmo horário.

            string Vendedor1, Vendedor2, Vendedor3;
            double TotaldeVendas, ValorHora, MetaVendas;
            int horasTrab;
            Console.WriteLine("Indice Horas: Vendedor1 ");
            horasTrab = int.Parse(Console.ReadLine());
            if (horasTrab < 144)
            {
                Console.WriteLine("Quantidade de horas insuficiente!");
            }
            else if (horasTrab > 144) {
                Console.WriteLine("Gerou banco de horas.");
            }
            else Console.WriteLine("Quantidade de Horas suficiente!");

            Console.WriteLine("Meta de Vendas da empresa = R$21.6000");
            Console.WriteLine("Digite as horas trablhadas:  horasTrab");
            if (horasTrab * 144 < 21.600) {
                Console.WriteLine("Meta de Vendas não alcançada");
            }
            else {
                Console.WriteLine("Meta de Vendas alcançada! Parabéns!!!"); 
                Console.ReadLine();
            }
        }
    }
}

