using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            BonusManager gerenciador = new BonusManager();

            Employee carlos = new Employee();
            carlos.Nome = "Carlos";
            carlos.CPF = "546.879.157-20";
            carlos.Salario = 2000;
            gerenciador.Registrar(carlos);
            
            Director roberta = new Director();
            roberta.Nome = "Roberta";
            roberta.CPF = "454.658.148-3";
            roberta.Salario = 5000;
            gerenciador.Registrar(roberta);

            Console.WriteLine(carlos.GetBonificacao());
            Console.WriteLine(roberta.GetBonificacao());
            Console.WriteLine(gerenciador.GetTotalBonificacao());
        }
    }
}
