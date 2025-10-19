using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho18Out
{
    internal class Carro : Veiculo
    {
        //public bool Disponivel { get; set; }

        public Carro()
        {
        }

        public Carro(string marca, string modelo) : base(marca, modelo)
        {
            Tipo = "Carro";
            Disponivel = true;
        }

        public override decimal CalcularValor(int dias)
        {
            return dias * 100;
        }

        public override bool VerificarDisponibilidade()
        {
            return Disponivel;
        }

        public override string ToString()
        {
            return ExibirInformacoes();
        }
    }
}
