using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(4350, 2334);
                ContaCorrente conta2 = new ContaCorrente(8350, 6334);
                conta2.Transferir(-10, conta);

                conta.Depositar(50);
                // conta.Sacar(500);
                conta.Sacar(-500);
            } 
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
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
