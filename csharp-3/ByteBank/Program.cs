using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularBonificacao();
        }

        public static void CalcularBonificacao()
        {
            BonusManager gerenciador = new BonusManager();

            Employee pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Employee roberta = new Director("159.753.398-04");
            roberta.Nome = "Roberta";

            Employee igor = new Assistant("981.198.778-53");

            Employee camila = new AccountManager("326.985.628-89");
            camila.Nome = "Camila";

            gerenciador.Registrar(pedro);
            gerenciador.Registrar(roberta);
            gerenciador.Registrar(igor);
            gerenciador.Registrar(camila);

            Console.WriteLine("Total bon " + gerenciador.GetTotalBonificacao());
        }
    }
}
