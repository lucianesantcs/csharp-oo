// using _05_namespaces;

namespace Client
{
  public class ContaCorrente
  {
    public int numeroAgencia;

    public int NumeroAgencia 
    {
      get 
      {
        return numeroAgencia;
      }
      set 
      {
        if(value <= 0)
        {
          return;
        }
        numeroAgencia = value;
      }
    }
    public int Numero { get; set; }
    public Client Titular { get; set; }
    public static int TotalDeContasCriadas { get; private set; }
    // private static int TotalDeContasCriadas { get; set; }
    // public static int ObterTotalDeContasCriadas() 
    // {
    //   return TotalDeContasCriadas;
    // }

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

    // construtor da conta corrente, tornando obrigatório passar os parâmetros
    public ContaCorrente(int agencia, int numero) 
    {
      NumeroAgencia = agencia;
      Numero = numero;

      ContaCorrente.TotalDeContasCriadas++;
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