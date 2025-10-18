using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho18Out
{
    internal class Moto : Veiculo
    {
        public Moto()
        {
        }

        public Moto(string marca, string modelo) : base(marca, modelo)
        {
            Tipo = "Moto";
        }

        public override string? ToString()
        {
            return ExibirInformacoes();
        }
    }
}
