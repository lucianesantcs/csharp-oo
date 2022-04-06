using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Metodo();
            }
            catch(NullReferenceException erro)
            {
                Console.WriteLine(erro.Message);
            }
        }

        private static void Metodo()
        {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
            try
            {
                int resultado = Dividir(10, divisor);
                Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
            }
            catch(DivideByZeroException erro)
            {
                Console.WriteLine(erro.Message);
                // Console.WriteLine("Não é possível dividir por zero");
            }
        }

        private static int Dividir(int numero, int divisor)
        {   
            ContaCorrente conta = null;
            Console.WriteLine(conta.Saldo);
            return numero / divisor;
        }
    }
}
