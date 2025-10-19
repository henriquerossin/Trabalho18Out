using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho18Out
{
    public abstract class Veiculo
    {
        public Veiculo()
        {
        }

        public string Marca { get; private set; }
        public string Modelo { get; private set; }
        public string Tipo { get; protected set; }
        public bool Disponivel { get; set; }

        public Veiculo(string marca, string modelo)
        {
            this.Marca = marca;
            this.Modelo = modelo;
        }

        public abstract decimal CalcularValor(int dias);

        public abstract bool VerificarDisponibilidade();

        public virtual string ExibirInformacoes()
        {
            return $"Marca: {this.Marca}, Modelo: {this.Modelo}, Tipo: {this.Tipo}";
        }
    }
}
