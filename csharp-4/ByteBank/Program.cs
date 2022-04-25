using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(0, 2);
            } 
            catch(ArgumentException ex) 
            {
                Console.WriteLine(ex.ParamName); // numero ou agencia, mesmo nome dos parâmetros da classe
            }
            catch(Exception x)
            {
                Console.WriteLine(x.Message);
            }
        }

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
            try
            {
                return numero / divisor;
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Exceção com numero " + numero + " e divisor " + divisor);
                throw;
            }
        }
    }
}
