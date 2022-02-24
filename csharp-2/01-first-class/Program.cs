using System;

namespace _01_first_class
{
    class Program
    {
        static void Main(string[] args)
        {
            // separado objeto em uma classe Account.cs
            // string titular = "Gabriela";
            // int numeroAgencia = 863;
            // int numero = 863146;
            // double saldo = 100;

            ContaCorrente contaGabriela = new ContaCorrente();
            contaGabriela.titular = "Gabriela";
            contaGabriela.numeroAgencia = 863;
            contaGabriela.numero = 863146;
            contaGabriela.saldo = 100;

            contaGabriela.saldo += 200;

            Console.WriteLine(contaGabriela.titular);
            Console.WriteLine(contaGabriela.saldo);
        }
    }
}
