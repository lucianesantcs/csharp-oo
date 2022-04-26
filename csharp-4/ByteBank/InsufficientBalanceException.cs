using System;

namespace ByteBank
{
    public class SaldoInsuficienteException: OperacaoFinanceiraException
    {
      public double Saldo { get; }
      public double ValorSaque { get; }
      public SaldoInsuficienteException()
      {

      }
      public SaldoInsuficienteException(double saldo, double valorSaque): this("Tentativa de saque no valor de " + valorSaque + " em uma conta com saldo de " + saldo + ".")
      {
       Saldo = saldo;
       ValorSaque = valorSaque; 
      }
      public SaldoInsuficienteException(string menssagem): base(menssagem)
      {

      }

      public SaldoInsuficienteException(string menssagem, Exception excecaoInterna): base(menssagem, excecaoInterna) 
      {
        
      }
    }
}