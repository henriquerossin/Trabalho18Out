using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho18Out
{
    internal class Caminhao : Veiculo
    {
        public Caminhao()
        {
        }

        public Caminhao(string marca, string modelo) : base(marca, modelo)
        {
            Tipo = "Caminhão";
        }

        public override string ToString()
        {
            return ExibirInformacoes();
        }
    }
}
