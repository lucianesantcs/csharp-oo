using System;

namespace ByteBank
{
    public class OperacaoFinanceiraException: Exception 
    {
      public OperacaoFinanceiraException()
      {

      }

      public OperacaoFinanceiraException(string menssagem): base(menssagem)
      {

      }

      public OperacaoFinanceiraException(string menssagem, Exception excecaoInterna): base(menssagem, excecaoInterna) 
      {
        
      }
    }
}