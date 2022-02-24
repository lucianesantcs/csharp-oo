using System;

namespace _12_calculateLongTermSavings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular poupança longo prazo");

            double valorInvestido = 1000;
            double fatorRendimento = 1.0036;

            for(int contadorAno = 1; contadorAno <= 5; contadorAno++) 
            {   
                for(int contadorMes = 1; contadorMes <= 12; contadorMes++) 
                {
                    valorInvestido *= fatorRendimento;
                }
                fatorRendimento += 0.0010;
            }

            Console.WriteLine("Ao término do investimento, você terá R$" + valorInvestido);
        }
    }
}
