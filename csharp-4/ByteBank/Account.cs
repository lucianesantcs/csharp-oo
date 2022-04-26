using System;

namespace ByteBank
{
    public class ContaCorrente
    {
        public static double TaxaOpeacao { get; private set; }
        public Cliente Titular { get; set; }
        public static int TotalDeContasCriadas { get; private set; }
        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciasNaoPermitidas { get; private set; }

        public int NumeroAgencia { get; }

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
            NumeroConta = numero;

            TotalDeContasCriadas++;
            TaxaOpeacao = 30 / TotalDeContasCriadas;
        }


        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para o saque.", nameof(valor));
            }

            if (this.saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(Saldo, valor);
            }

            this.saldo -= valor;
        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }


        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para a transferência.", nameof(valor));
            }

            try 
            {
                Sacar(valor);
            }
            catch(SaldoInsuficienteException ex)
            {
                ContadorTransferenciasNaoPermitidas++;
                // throw new Exception("Operação não realizada.", ex);
                throw new OperacaoFinanceiraException("Operação não realizada.", ex);
            }
            this.saldo -= valor;
            contaDestino.Depositar(valor);
        }
    }
}
