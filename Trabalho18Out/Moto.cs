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
            Disponivel = true;
        }

        public override decimal CalcularValor(int dias)
        {
            return dias * 50;
        }

        public override bool VerificarDisponibilidade()
        {
            return Disponivel;
        }

        public override string? ToString()
        {
            return ExibirInformacoes();
        }
    }
}
