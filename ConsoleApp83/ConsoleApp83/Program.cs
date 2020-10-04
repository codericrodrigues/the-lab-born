using System;
using System.Globalization;


namespace TempoÉDinheiro {
    class Program {
        static void Main(string[] args) {

            //Uma empresa estrangeira de autopeças para carros decide abrir uma filial no Brasil, 
            //especificamente no Estado de São Paulo. Esta empresa contratou 10 funcionários. 
            //Dois fatores são essenciais para esta empresa medir o desempenho de seus funcionários,
            //são eles: tempo e produtividade. No primeiro trimestre, fizeram análise de vendas, baseados
            //nos fatores tempo e produtividade, comparando a quantidade de horas mensais dos vendedores
            //e o valor total das vendas dos 3 vendedores contratados. Considerando que os vendedores tem
            //carga horária mensal de 144 horas e trabalham no mesmo horário.

            string Vendedor1, Vendedor2, Vendedor3;
            double tempo, TotaldeVendas;
            int horas;

            Console.WriteLine("Vendedor1: ");
            horas = int.Parse(Console.ReadLine());
                  

            if (horas < 144) {
                Console.WriteLine("Quantidade de horas insuficiente!");
            }
            else if (horas > 144) {
                Console.WriteLine("Gerou banco de horas.");
            }
            else Console.WriteLine("Quantidade de Horas suficiente!");

            Console.WriteLine("Vendedor2: ");
            horas = int.Parse(Console.ReadLine());


            if (horas < 144) {
                Console.WriteLine("Quantidade de horas insuficiente!");
            }
            else if (horas > 144) {
                Console.WriteLine("Gerou banco de horas.");
            }
            else Console.WriteLine("Quantidade de Horas suficiente!");

            Console.WriteLine("Vendedor3: ");
            horas = int.Parse(Console.ReadLine());

            if (horas < 144) {
                Console.WriteLine("Quantidade de horas insuficiente!");
            }
            else if (horas > 144) {
                Console.WriteLine("Gerou banco de horas.");
            }
            else Console.WriteLine("Quantidade de Horas suficiente!");

            Console.ReadLine();

            

           
                         
            

        }
    }
}
