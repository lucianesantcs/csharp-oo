using System;

namespace _7_conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escopo");

            int idadeJoao = 16;
            bool acompanhado = false;
            string mensagemAdicional;

            if(acompanhado) 
            {
                mensagemAdicional = "Está acompanhado.";
            }
            else 
            {
                mensagemAdicional = "Não está acompanhado.";
            }

            if(idadeJoao >= 18 || acompanhado)
            {
                Console.WriteLine("Pode entrar.");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("Não pode entrar.");
            }

            Console.WriteLine("Escopo exercício");

            double salario = 3751.1;

            if(salario >= 1900.0 && salario <= 2800.0)
            {
                Console.WriteLine("IR de 7.5% e pode deduzir na declaração o valor de R$142.");
            }

            if(salario >= 2800.01 && salario <= 3751.0)
            {
                Console.WriteLine("IR de 15% e pode deduzir na declaração o valor de R$350.");
            }

            if(salario >= 3751.01 && salario <= 4664.00)
            {
                Console.WriteLine("IR de 22.5% e pode deduzir na declaração o valor de R$636.");
            }
        }
    }
}
