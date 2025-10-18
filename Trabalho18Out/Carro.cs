using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho18Out
{
    internal class Carro : Veiculo
    {

        public bool Disponivel { get; set; }

        public Carro()
        {
        }

        public Carro(string marca, string modelo) : base(marca, modelo)
        {
            Tipo = "Carro";
        }

        public override bool VerificarDisponibilidade()
        {
            if (Disponivel == true)
            {
                return Disponivel = true;
            }
            else
            {
                return Disponivel = false;
            }
        }

        public override string ToString()
        {
            return ExibirInformacoes();
        }
    }
}
