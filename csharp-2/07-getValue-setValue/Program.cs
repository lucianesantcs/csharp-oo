using System;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Client cliente = new Client();
            cliente.Nome = "Guilherme";
            cliente.CPF = "434.564.879-20";
            cliente.Profissao = "Desenvolvedor";

            ContaCorrente conta = new ContaCorrente();
            conta.Saldo = -10;
            Console.WriteLine(conta.Saldo);

            conta.Titular = cliente;
            Console.WriteLine(conta.Titular.Nome);

            // conta.DefinirSaldo(-10);            
            // Console.WriteLine(conta.ObterSaldo());
        }
    }
}
