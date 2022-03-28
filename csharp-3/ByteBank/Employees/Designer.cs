namespace ByteBank
{
  public class Designer: Employee
  {
    public Designer(string cpf): base(3000, cpf) 
    {
      // 
    }
    public override void AumentarSalario()
    {
      Salario *= 1.11;
    }
    public override double GetBonificacao()
    {
      return Salario * 0.17;
    }
  }
}
