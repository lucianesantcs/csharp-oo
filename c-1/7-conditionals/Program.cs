using System;

namespace _7_conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Condicionais");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            if(idadeJoao >= 18)
            {
                Console.WriteLine("Possui mais de 18 anos.");
            }
            else
            {
                if(quantidadePessoas >= 2)
                {
                    Console.WriteLine("Não possui mais de 18, mas está acompanhado.");
                }
                else
                {
                    Console.WriteLine("Não possui mais de 18 anos.");
                }
            }
        }
    }
}
