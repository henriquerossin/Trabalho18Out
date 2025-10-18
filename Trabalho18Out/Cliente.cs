using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho18Out
{
    public class Cliente : Pessoa
    {
        public string Telefone { get; private set; }
        public Cliente()
        {
        }

        public Cliente(string nome, string cpf, string telefone) : base(nome, cpf)
        {
            Telefone = telefone;
        }

        public override string ToString()
        {
            return ExibirInformacoes() + $", Telefone: {Telefone}";

        }
    }
}
