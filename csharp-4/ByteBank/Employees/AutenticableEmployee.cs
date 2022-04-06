using System;

namespace ByteBank
{
  public abstract class AutenticableEmployee: Employee, IAutenticable
  {
    public string Senha { get; set; }
    public AutenticableEmployee(double salary, string cpf) : base(salary, cpf)
    {
      // 
    }
    public bool Autenticar(string senha)
    {
      return this.Senha == senha;
    }
  }
}