using System;

namespace _10_calculateSavings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular poupança com for");

            double valorInvestido = 1000;
            for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                valorInvestido *= 1.0036;
                Console.WriteLine("Após " + contadorMes + " meses, você terá R$" + valorInvestido);
            }
        }
    }
}
