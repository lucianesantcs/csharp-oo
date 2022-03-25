using System;

namespace ByteBank
{
  public class Employee
  {
    public string Nome { get; set; }
    public string CPF { get; set; }
    public double Salario { get; set; }

    public virtual double GetBonificacao()
    {
      return Salario * 0.10;
    }

  }
}
