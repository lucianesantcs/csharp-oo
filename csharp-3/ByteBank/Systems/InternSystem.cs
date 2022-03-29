using System;

namespace ByteBank
{
  public class InternSystem
  {
    public bool Logar(Autenticable funcionario, string senha)
    {
      bool usuarioAutenticado = funcionario.Autenticar(senha);

      if(usuarioAutenticado)
      {
        Console.WriteLine("Bem-vindo ao sistema!");
        return true;
      }
      else
      {
        Console.WriteLine("Senha incorreta!");
        return false;
      }
    }
  }
}
