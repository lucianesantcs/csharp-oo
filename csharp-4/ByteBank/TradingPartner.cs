using System;

namespace ByteBank
{
    public class TradingPartner: IAutenticable
    {
      public string Senha { get; set; }
      public bool Autenticar(string senha)
      {
        return this.Senha == senha;
      }
    }

}