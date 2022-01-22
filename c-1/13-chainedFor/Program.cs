using System;

namespace _13_chainedFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For encadeado");

            for(int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for(int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
                {
                    if(contadorColuna > contadorLinha)
                    {
                        break;
                    }
                    Console.Write(contadorColuna + 1);
                }

                Console.WriteLine(); // pula linha
            }


            // for(int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            // {
            //     for(int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
            //         Console.Write("*");

            //     Console.WriteLine(); // pula linha
            // }


            // for(int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            // {
            //     for(int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
            //     {
            //         Console.Write("*");
            //         if(contadorColuna >= contadorLinha)
            //             break;
            //     }

            //     Console.WriteLine(); // pula linha
            // }
        }
    }
}
