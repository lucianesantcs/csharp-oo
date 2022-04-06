namespace ByteBank
{
  public class BonusManager 
  {
    private double totalBonificacao;
    public void Registrar(Employee funcionario) 
    {
      totalBonificacao += funcionario.GetBonificacao();
    }

    public double GetTotalBonificacao()
    {
      return totalBonificacao;
    }
  }
}