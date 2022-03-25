namespace ByteBank
{
  public class Director: Employee
  {
    public override double GetBonificacao()
    {
      return Salario + base.GetBonificacao();
    }
  }
}
