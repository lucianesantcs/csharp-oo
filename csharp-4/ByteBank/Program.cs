using System;
using System.IO;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                CarregarContas();
            }
            catch (Exception)
            {
                Console.WriteLine("Ocorreu um erro!");
            }
        }

        private static void CarregarContas()
        {
            using (LeitorDeArquivo leitor = new LeitorDeArquivo("conta.txt"))
            {
                leitor.LerProximaLinha();
            }

        }
        private static void TestaInnerException()
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(4350, 2334);
                ContaCorrente conta2 = new ContaCorrente(8350, 6334);
                // conta.Transferir(10000, conta2);
                conta.Sacar(10000);
            } 
            // catch (Exception ex)
            catch (OperacaoFinanceiraException ex)
            {
                Console.WriteLine(ex.Message);
                // Console.WriteLine(ex.StackTrace);
                // Console.WriteLine("Info inner exception:");
                // Console.WriteLine(ex.InnerException.Message);
                // Console.WriteLine(ex.InnerException.StackTrace);
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
