namespace ByteBank
{
  public class Assistant: Employee
  {
    public Assistant(string cpf): base(2000, cpf) 
    {
      // 
    }
    public override void AumentarSalario()
    {
      Salario *= 1.1;
    }
    public override double GetBonificacao()
    {
      return Salario * 0.2;
    }
  }
}
