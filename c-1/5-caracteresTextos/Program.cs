using System;

namespace _5_caracteresTextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Caracteres e textos");
            
            char primeiraLetra = 'a';
            primeiraLetra = (char)65; // retorna A
            primeiraLetra = (char)(primeiraLetra + 1); // retorna B
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura cursos de tecnologia " + 2022;
            Console.WriteLine(titulo);

            // string cursosProgramação = " - .NET" + " - Java" + " - JavaScript";
            string cursosProgramação = 
            @" - .NET 
            - Java 
            - JavaScript";
            Console.WriteLine(cursosProgramação);
        }
    }
}
