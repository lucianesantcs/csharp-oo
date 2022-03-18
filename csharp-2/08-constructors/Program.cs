using System;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(867, 86712540);
            // Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            // conta.Numero = 86712540;
            // conta.NumeroAgencia = 867;

            ContaCorrente conta2 = new ContaCorrente(563, 08712540);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            Console.WriteLine(conta.NumeroAgencia);
            Console.WriteLine(conta.Numero);
            
        }
    }
}
