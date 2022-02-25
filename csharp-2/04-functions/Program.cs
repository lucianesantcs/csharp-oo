using System;

namespace _04_functions
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();
            contaDoBruno.titular = "Bruno";

            // contaDoBruno.Sacar(50);
            bool resultadoSaque = contaDoBruno.Sacar(50);
            Console.WriteLine(contaDoBruno.saldo);
            Console.WriteLine(resultadoSaque);

            contaDoBruno.Depositar(500);
            Console.WriteLine(contaDoBruno.saldo);

            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";

            contaDoBruno.Transferir(200, contaDaGabriela);
            bool resultadoTransferencia = contaDoBruno.Transferir(200, contaDaGabriela);

            Console.WriteLine(contaDaGabriela.saldo); // 500
            Console.WriteLine(contaDoBruno.saldo); // 150
            Console.WriteLine(resultadoTransferencia); // true
        }
    }
}
