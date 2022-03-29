using System;

namespace ByteBank
{
  public abstract class Autenticable: Employee
  {
    public string Senha { get; set; }
    public Autenticable(double salario, string cpf): base(salario, cpf)
    {
      //
    }
    public bool Autenticar(string senha)
    {
      return this.Senha == senha;
    }
  }
}
