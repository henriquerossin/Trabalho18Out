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
            Tipo = "Caminhao";
            Disponivel = true;
        }

        public override decimal CalcularValor(int dias)
        {
            return dias * 200;
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
