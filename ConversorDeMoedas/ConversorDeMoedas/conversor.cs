using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos
{
    internal class conversorDeMoedas
    {

        public static decimal taxaDolarParaoReal = 5.25m;
        public static decimal taxaEuroParaoReal = 5.60m;
        public static decimal taxaLibraParaoReal = 6.50m;

        public static decimal converterParaReal(decimal valor, string moedaOrigem)
        {

            if (moedaOrigem == "USD")
            {

                return valor * taxaDolarParaoReal;
            }
            else if (moedaOrigem == "EUR")
            {


                return valor * taxaEuroParaoReal;
            }
            else if (moedaOrigem == "GBP")
            {


                return valor * taxaLibraParaoReal;

            }
            else
            {
                Console.WriteLine("Moeda inválida");

                return 0;
            }



        }
    }
}
