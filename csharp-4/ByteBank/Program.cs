using System;
using System.IO;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CarregarContas();
        }

        private static void CarregarContas()
        {
            LeitorDeArquivo leitor = null;
            // LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt");
            try
            {
                leitor = new LeitorDeArquivo("contas.txt");
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
                // leitor.Fechar();
            }
            catch(IOException)
            {
                Console.WriteLine("IO");
            }
            finally
            {
                leitor.Fechar();
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
