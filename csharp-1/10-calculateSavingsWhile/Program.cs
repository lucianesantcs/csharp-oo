using System;

namespace _10_calculateSavings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular poupança com while");
            double valorInvestido = 1000;
            int contadorMes = 1;

            while(contadorMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após " + contadorMes + " meses, você terá R$" + valorInvestido);
                contadorMes ++; // contadorMes = contadorMes + 1; e contadorMes += 1;
            }

            // 0.36% = 0.0036
            // valorInvestido = valorInvestido + valorInvestido * 0.0036;
            // Console.WriteLine("Após 1 mês, você terá R$" + valorInvestido);

            // valorInvestido = valorInvestido + valorInvestido * 0.0036;
            // Console.WriteLine("Após 2 meses, você terá R$" + valorInvestido);

        }
    }
}
