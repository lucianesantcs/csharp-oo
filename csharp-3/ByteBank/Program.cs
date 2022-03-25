using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee carlos = new Employee();
            carlos.Nome = "Carlos";
            carlos.CPF = "546.879.157-20";
            carlos.Salario = 2000;

            Console.WriteLine(carlos.GetBonificacao());
        }
    }
}
