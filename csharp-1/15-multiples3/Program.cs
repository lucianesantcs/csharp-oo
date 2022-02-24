using System;

namespace _15_multiples3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Múltiplos de 3");

            for(int contador = 1; contador <= 100; contador++)
            {
                if(contador % 3 == 0)
                {
                    Console.Write(contador + " ");
                }
            }
        }
    }
}
