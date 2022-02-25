using System;

namespace _02_standard_values
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.titular = "Gabriela";
            
            Console.WriteLine(conta.saldo); // retorna 100 definido na classe Account
        }
    }
}
