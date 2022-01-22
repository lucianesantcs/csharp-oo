using System;

namespace _7_conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Condicional boolean");

            int idadeJoao = 16;
            // int quantidadePessoas = 2;
            // bool acompanhado = quantidadePessoas >= 2;
            bool acompanhado = false;

            if(idadeJoao >= 18 || acompanhado)
            {
                Console.WriteLine("Pode entrar.");
            }
            else
            {
                Console.WriteLine("Não pode entrar.");
            }
        }
    }
}
