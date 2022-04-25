using System;

namespace ByteBank
{
    public class ContaCorrente
    {
        public static double TaxaOpeacao { get; private set; }
        public Cliente Titular { get; set; }
        public static int TotalDeContasCriadas { get; private set; }


        // private int numeroAgencia;
        public int NumeroAgencia { get; }
        // public int NumeroAgencia
        // {
        //     get
        //     {
        //         return numeroAgencia;
        //     }
        //     set
        //     {
        //         if (value <= 0)
        //         {
        //             return;
        //         }

        //         numeroAgencia = value;
        //     }
        // }

        // private readonly int numeroConta;
        // public int NumeroConta 
        // {
        //     get
        //     {
        //         return numeroConta;
        //     }
        // }

        public int NumeroConta { get; }

        private double saldo = 100;

        public double Saldo
        {
            get
            {
                return this.saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                this.saldo = value;
            }
        }


        public ContaCorrente(int agencia, int numero)
        {    
            if(agencia <= 0) 
            {
                throw new ArgumentException("O argumento agencia deve ser maior que 0.", nameof(agencia));
            }

            if(numero <= 0) 
            {
                throw new ArgumentException("O argumento numero deve ser maior que 0.", nameof(numero));
            }

            NumeroAgencia = agencia;
            // numeroConta = numero;
            NumeroConta = numero;

            TaxaOpeacao = 30 / TotalDeContasCriadas;
            TotalDeContasCriadas++;
        }


        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
            {
                return false;
            }

            this.saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }


        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }

            this.saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
