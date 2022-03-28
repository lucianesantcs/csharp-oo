namespace ByteBank
{
  public class Director: Employee
  {
    public Director(string cpf): base(5000, cpf) 
    {
      // 
    }
    public override void AumentarSalario()
    {
      Salario *= 1.15;
    }
    public override double GetBonificacao()
    {
      return Salario + base.GetBonificacao();
    }
  }
}
