using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho18Out
{
    internal class Aluguel
    {
        public Cliente Cliente { get; private set; }
        public Veiculo Veiculo { get; private set; }
        public int Dias { get; private set; }
        public decimal ValorTotal { get; private set; }

        public Aluguel(Cliente cliente, Veiculo veiculo, int dias)
        {
            Cliente = cliente;
            Veiculo = veiculo;
            Dias = dias;
            ValorTotal = veiculo.CalcularValor(dias);
            veiculo.Disponivel = false;
        }

        public override string ToString()
        {
            return $"Cliente: {Cliente}\nVeículo: {Veiculo}\nDias: {Dias}\nValor Total: {ValorTotal:C}";
        }
    }
}
