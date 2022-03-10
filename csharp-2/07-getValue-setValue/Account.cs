// using _05_namespaces;

namespace Client
{
  public class ContaCorrente
  {
    // public int numeroAgencia;
    public int NumeroAgencia { get; set; }
    
    // public int numero;
    public int Numero { get; set; }

    // private Client titular;
    // public Client Titular
    // {
    //   get
    //   {
    //     return titular;
    //   }
    //   set 
    //   {
    //     titular = value;
    //   }
    // }
    public Client Titular { get; set; }

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

    // public double GetSaldo()
    // {
    //   return this.saldo;
    // }

    // public void SetSaldo(double valor) 
    // {
    //   if (valor < 0)
    //   {
    //     return;
    //   }

    //   this.saldo = valor;
    // }

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
      // contaDestino.saldo += valor;
      contaDestino.Depositar(valor);
      return true;
    }

  }
}