using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho18Out
{
    internal class Locacao
    {

        private List<Veiculo> veiculos;
        private List<Cliente> clientes;

        public Locacao()
        {
            veiculos = new List<Veiculo>();
            clientes = new List<Cliente>();
        }

        public void CadastrarVeiculo(List<Veiculo> veiculos, Veiculo veiculo)
        {
            Console.Write("Informe o tipo do veículo (Carro, Moto, Caminhão): ");
            string tipo = Console.ReadLine()!;

            Console.Write("Informe a marca do veículo: ");
            string marca = Console.ReadLine()!;

            Console.Write("Informe o modelo do veículo: ");
            string modelo = Console.ReadLine()!;

            if (tipo == "Carro")
            {
                veiculo = new Carro(marca, modelo);
            }
            else if (tipo == "Moto")
            {
                veiculo = new Moto(marca, modelo);
            }
            else if (tipo == "Caminhão")
            {
                veiculo = new Caminhao(marca, modelo);
            }
            else
            {
                Console.WriteLine("Tipo de veículo inválido.");
            }
            veiculos.Add(veiculo);
        }

        public void CadastrarCliente(List<Cliente> clientes, Cliente cliente)
        {
            Console.Write("Informe o nome do Cliente: ");
            string nome = Console.ReadLine()!;

            Console.Write("Informe o CPF do cliente: ");
            string cpf = Console.ReadLine()!;

            Console.WriteLine("Informe o telefone do cliente: ");
            string telefone = Console.ReadLine()!;

            cliente = new Cliente(nome, cpf, telefone);

            clientes.Add(cliente);
        }

        public void ListarVeiculos(List<Veiculo> veiculos)
        {
            Console.WriteLine("Clientes cadastrados:");
            foreach (var veiculo in veiculos)
            {
                if (veiculo.VerificarDisponibilidade() == true)
                {
                    Console.WriteLine($"{veiculo.ToString()} está disponível.");
                }
                else
                {
                    Console.WriteLine($"{veiculo.ToString()} não está disponível para locação.");
                }
            }
        }

        public void ListarClientes(List<Cliente> clientes)
        {
            Console.WriteLine("Clientes Cadastrados:");
            foreach (var cliente in clientes)
            {
                Console.WriteLine(cliente.ToString());
            }
        }
    }
}
