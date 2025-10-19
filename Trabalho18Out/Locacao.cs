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
        private List<Aluguel> alugueis;

        public Locacao()
        {
            veiculos = new List<Veiculo>();
            clientes = new List<Cliente>();
            alugueis = new List<Aluguel>();
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

        public Aluguel RealizarLocacao(Cliente cliente, Veiculo veiculo, int dias)
        {
            Console.WriteLine("Informe o nome do Cliente que vai alugar o veículo: ");
            string nome = Console.ReadLine()!;
            Console.WriteLine("Informe o CPF do mesmo: ");
            string cpf = Console.ReadLine()!;

            Cliente clienteEncontrado = null;
            foreach (var c in clientes)
            {
                if (c.Nome == nome && c.Cpf == cpf)
                {
                    clienteEncontrado = c;
                    break;
                }
            }
            if (clienteEncontrado == null)
            {
                Console.WriteLine("Cliente não encontrado. Por favor, cadastre o cliente antes de realizar a locação.");
                return null!;
            }
            else
            {
                cliente = clienteEncontrado!;
            }

            Console.WriteLine("Informe o tipo de veículo que deseja alugar: ");
            string tipo = Console.ReadLine()!;
            Console.WriteLine("Informe a marca do veículo que deseja alugar: ");
            string marca = Console.ReadLine()!;
            Console.WriteLine("Informe o modelo do veículo que deseja alugar: ");
            string modelo = Console.ReadLine()!;

            Veiculo veiculoEncontrado = null!;
            foreach (var c in veiculos)
            {
                if (c.Tipo == tipo && c.Marca == marca && c.Modelo == modelo && c.VerificarDisponibilidade() == true)
                {
                    veiculoEncontrado = c;
                    break;
                }
            }
            if (veiculoEncontrado == null)
            {
                Console.WriteLine("Veículo não encontrado ou indisponível para locação.");
                return null!;
            }
            else
            {
                veiculo = veiculoEncontrado;
            }

            Console.WriteLine("Informe por quantos dias o veículo será alocado: ");
            dias = int.Parse(Console.ReadLine()!);

            Aluguel aluguel = new Aluguel(cliente, veiculo, dias);
            return aluguel;
        }

        public void ListarLocacoes(List<Aluguel> alugueis)
        {
            Console.WriteLine("Locações em andamento:");
            foreach (var aluguel in alugueis)
            {
                Console.WriteLine(aluguel.ToString());
            }
        }
    }
}
