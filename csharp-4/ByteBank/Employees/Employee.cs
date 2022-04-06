using System;

namespace ByteBank
{
  public abstract class Employee
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
    public abstract void AumentarSalario();
    public abstract double GetBonificacao();

  }
}
