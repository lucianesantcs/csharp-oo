// namespace _05_namespaces
namespace Client
{
  public class Client {
    // public string nome;
    // public string cpf;
    // public string profissao;


    private string cpf;

    public string Nome { get; set; }
    public string CPF 
    { 
      get 
      {
        return this.cpf;
      }
      set 
      {
        // escrever lógica de validação de CPF
        this.cpf = value;
      }
    }
    public string Profissao { get; set; }

  }
}