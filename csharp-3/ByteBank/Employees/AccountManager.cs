namespace ByteBank
{
  public class AccountManager: Employee
  {
    public AccountManager(string cpf): base(4000, cpf) 
    {
      // 
    }
    public override void AumentarSalario()
    {
      Salario *= 1.05;
    }
    public override double GetBonificacao()
    {
      return Salario * 0.25;
    }
  }
}
