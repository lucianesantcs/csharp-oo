using System;

namespace _03_types_reference_value
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.numeroAgencia = 863;
            contaDaGabriela.numero = 863452;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
            contaDaGabrielaCosta.titular = "Gabriela";
            contaDaGabrielaCosta.numeroAgencia = 863;
            contaDaGabrielaCosta.numero = 863452;

            Console.WriteLine(contaDaGabriela == contaDaGabrielaCosta); // false

            int idade = 34;
            int novaIdade = 60;
            Console.WriteLine(idade == novaIdade); // true

            contaDaGabriela = contaDaGabrielaCosta; // as variáveis apontam para o mesmo objeto
            Console.WriteLine(contaDaGabriela == contaDaGabrielaCosta); // true

            contaDaGabriela.saldo = 300;
            Console.WriteLine(contaDaGabriela.saldo); // 300
            Console.WriteLine(contaDaGabrielaCosta.saldo); // 300
        }
    }
}
