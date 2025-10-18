using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho18Out
{
    internal class Carro : Veiculo
    {
        public Carro()
        {
        }

        public Carro(string marca, string modelo) : base(marca, modelo)
        {
            Tipo = "Carro";
        }

        public override string ToString()
        {
            return ExibirInformacoes();
        }
    }
}
