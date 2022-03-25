namespace ByteBank
{
  public class Director: Employee
  {
    public Director(string cpf): base(cpf) 
    {
      // 
    }
    public override double GetBonificacao()
    {
      return Salario + base.GetBonificacao();
    }
  }
}
