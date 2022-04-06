using System;

namespace ByteBank
{
    public class Cliente
    {
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
                this.cpf = value;
            }
        }
        public string Profissao { get; set; }
    }
}
