using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            BonusManager gerenciador = new BonusManager();

            Employee carlos = new Employee(2000, "546.879.157-20");
            carlos.Nome = "Carlos";
            // carlos.Salario = 2000;
            gerenciador.Registrar(carlos);
            carlos.AumentarSalario();
            
            Console.WriteLine("Salario carlos " + carlos.Salario);
            
            Director roberta = new Director("454.658.148-3");
            roberta.Nome = "Roberta";
            // roberta.Salario = 5000;
            gerenciador.Registrar(roberta);

            Employee robertaTeste = roberta;
            roberta.AumentarSalario();
            Console.WriteLine("Salario roberta " + roberta.Salario);
        }
    }
}
