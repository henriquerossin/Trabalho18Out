using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho18Out
{
    public abstract class Pessoa
    {
        public Pessoa()
        {
        }

        public string Nome { get; private set; }
        public string Cpf { get; private set; }

        public Pessoa(string nome, string cpf)
        {
            this.Nome = nome;
            this.Cpf = cpf;
        }

        public virtual string ExibirInformacoes()
        {
            return $"Nome: {this.Nome}, CPF: {this.Cpf}";
        }
    }
}
