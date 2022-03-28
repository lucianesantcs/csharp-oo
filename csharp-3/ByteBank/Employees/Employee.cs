using System;

namespace ByteBank
{
  public class Employee
  {
    public static int TotalDeFuncionarios { get; set; }
    public string Nome { get; set; }
    public string CPF { get; private set; }
    public double Salario { get; protected set; }

    public Employee(double salario, string cpf)
    {
      CPF = cpf;
      Salario = salario;
      TotalDeFuncionarios++;
    }

    public virtual void AumentarSalario()
    {
      // Salario = Salario + (Salario * 0.1);
      // Salario = Salario * 1.1;
      Salario *= 1.1;
    }

    public virtual double GetBonificacao()
    {
      return Salario * 0.10;
    }

  }
}
