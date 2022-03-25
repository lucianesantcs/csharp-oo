namespace ByteBank
{
  public class BonusManager 
  {
    private double totalBonificacao;
    public void Registrar(Employee funcionario) 
    {
      totalBonificacao += funcionario.GetBonificacao();
    }

    public void Registrar(Director diretor) 
    {
      totalBonificacao += diretor.GetBonificacao();
    }

    public double GetTotalBonificacao()
    {
      return totalBonificacao;
    }
  }
}