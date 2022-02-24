using System;

namespace _14_multiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuada com for");

            for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
            {
                for (int contador = 0; contador <= 10; contador++)
                {
                    Console.Write(multiplicador + " * " + contador + " = " + multiplicador * contador);
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
