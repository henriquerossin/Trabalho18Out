using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho18Out
{
    internal class Caminhao : Veiculo
    {
        public bool Disponivel { get; set; }

        public Caminhao()
        {
        }

        public Caminhao(string marca, string modelo) : base(marca, modelo)
        {
            Tipo = "Caminhão";
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
