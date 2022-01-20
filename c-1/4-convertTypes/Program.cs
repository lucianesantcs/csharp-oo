using System;

namespace _4_convertTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Convertendo tipos");

            double salario;
            salario = 1200.50;

            int salarioEmInteiro;
            // (int)) casting: converte double em int
            salarioEmInteiro = (int)salario;
            Console.WriteLine("Salario em inteiro " + salarioEmInteiro);

            float altura = 1.80f; // sufixo f para forçar o float
            Console.WriteLine("Altura " + altura);

            // int: 32bits long: 64bits
            long idade;
            idade = 130000000000000;
            Console.WriteLine("Idade " + idade);

            // short: 16bits
            short quantidadeProdutos;
            quantidadeProdutos = 15000;
            Console.WriteLine("Quantidade de produtos " + quantidadeProdutos);
        }
    }
}
