using System;

namespace ByteBank
{
    public class ContaCorrente
    {
        public static double TaxaOpeacao { get; private set; }
        public Cliente Titular { get; set; }
        public static int TotalDeContasCriadas { get; private set; }


        private int numeroAgencia;
        public int NumeroAgencia
        {
            get
            {
                return numeroAgencia;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }

                numeroAgencia = value;
            }
        }
        public int Numero { get; set; }

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
            NumeroAgencia = agencia;
            Numero = numero;

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
