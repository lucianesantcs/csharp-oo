using System;

namespace ByteBank
{
  public class Employee
  {
    public static int TotalDeFuncionarios { get; private set; }
    public string Nome { get; set; }
    public string CPF { get; private set; }
    public double Salario { get; set; }

    public Employee(string cpf)
    {
      CPF = cpf;
      TotalDeFuncionarios++;
    }

    public virtual double GetBonificacao()
    {
      return Salario * 0.10;
    }

  }
}
