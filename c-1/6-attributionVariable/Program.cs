using System;

namespace _6_attributionVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Atribuições de variáveis");
            int idade = 32;
            int idadeGustavo = idade;

            idade = 20;

            Console.WriteLine(idade); // 20
            Console.WriteLine(idadeGustavo); // 32

        }
    }
}
