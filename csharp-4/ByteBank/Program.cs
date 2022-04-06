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
            // catch(NullReferenceException erro)
            catch(NullReferenceException erro)
            {
                Console.WriteLine(erro.Message);
            }
            // catch(DivideByZeroException erro)
            // {
            //     Console.WriteLine(erro.Message);
            // }
        }

        // tratamento específico
        // static void Main(string[] args)
        // {
        //     try
        //     {
        //         Metodo();
        //     }
        //     catch(DivideByZeroException erro)
        //     {
        //             Console.WriteLine(erro.Message);
        //     }
        //     catch(Exception erro)
        //     {
        //         Console.WriteLine(erro.Message);
        //     }
        // }

        private static void Metodo()
        {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
        }

        private static int Dividir(int numero, int divisor)
        {   
            ContaCorrente conta = null;
            // Console.WriteLine(conta.Saldo);
            return numero / divisor;
        }
    }
}
