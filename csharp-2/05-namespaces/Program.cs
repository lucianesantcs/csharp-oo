using System;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            // Client gabriela = new Client();
            // gabriela.nome = "Gabriela";
            // gabriela.profissao = "Desenvolvedora C#";
            // gabriela.cpf = "434.568.878-20";

            ContaCorrente conta = new ContaCorrente();
            // conta.titular = gabriela;
            conta.saldo = 500;
            conta.numeroAgencia = 563;
            conta.numero = 5634527;
            
            // 2 maneira de instanciar um novo cliente
            conta.titular = new Client();
            conta.titular.nome = "Gabriela Costa";
            conta.titular.profissao = "Desenvolvedora C#";
            conta.titular.cpf = "434.568.878-20";


            // Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular.nome);

        }
    }
}
