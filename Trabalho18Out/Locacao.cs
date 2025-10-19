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

        public void CadastrarVeiculo()
        {
            Console.Write("Informe o tipo do veículo (Carro, Moto, Caminhão): ");
            string tipo = Console.ReadLine()!;

            Console.Write("Informe a marca do veículo: ");
            string marca = Console.ReadLine()!;

            Console.Write("Informe o modelo do veículo: ");
            string modelo = Console.ReadLine()!;

            Veiculo veiculo;

            if (tipo == "Carro")
            {
                veiculo = new Carro(marca, modelo);
                veiculo.Tipo = tipo;
            }
            else if (tipo == "Moto")
            {
                veiculo = new Moto(marca, modelo);
                veiculo.Tipo = tipo;
            }
            else if (tipo == "Caminhao")
            {
                veiculo = new Caminhao(marca, modelo);
                veiculo.Tipo = tipo;
            }
            else
            {
                Console.WriteLine("Tipo de veículo inválido.");
                return;
            }

            veiculos.Add(veiculo);
            Console.WriteLine("Veículo cadastrado!");
            Console.ReadLine();
            Console.Clear();
        }

        public void ListarVeiculos()
        {
            Console.WriteLine("Veículos cadastrados:");
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
            Console.WriteLine("Fim da lista.");
            Console.ReadLine();
            Console.Clear();
        }

        public void CadastrarCliente()
        {
            Console.Write("Informe o nome do Cliente: ");
            string nome = Console.ReadLine()!;

            Console.Write("Informe o CPF do cliente: ");
            string cpf = Console.ReadLine()!;

            Console.WriteLine("Informe o telefone do cliente: ");
            string telefone = Console.ReadLine()!;

            Cliente cliente = new Cliente(nome, cpf, telefone);
            clientes.Add(cliente);
            Console.WriteLine("Cliente cadastrado.");
            Console.ReadLine();
            Console.Clear();
        }

        public void ListarClientes()
        {
            Console.WriteLine("Clientes Cadastrados:");
            foreach (var cliente in clientes)
            {
                Console.WriteLine(cliente.ToString());
            }
            Console.WriteLine("Fim da lista.");
            Console.ReadLine();
            Console.Clear();
        }

        public void RealizarLocacao()
        {
            Console.WriteLine("Informe o nome do Cliente que vai alugar o veículo: ");
            string nome = Console.ReadLine()!;
            Console.WriteLine("Informe o CPF do mesmo: ");
            string cpf = Console.ReadLine()!;

            Cliente clienteEncontrado = null!;
            foreach (var cliente in clientes)
            {
                if (cliente.Nome == nome && cliente.Cpf == cpf)
                {
                    clienteEncontrado = cliente;
                    break;
                }
            }
            if (clienteEncontrado == null)
            {
                Console.WriteLine("Cliente não encontrado. Por favor, cadastre o cliente antes de realizar a locação.");
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
            }

            Console.WriteLine("Informe por quantos dias o veículo será alocado: ");
            int dias = int.Parse(Console.ReadLine()!);

            Aluguel aluguel = new Aluguel(clienteEncontrado!, veiculoEncontrado!, dias);
            alugueis.Add(aluguel);
            Console.WriteLine("Alocação efetuada.");
            Console.ReadLine();
            Console.Clear();
        }

        public void ListarLocacoes()
        {
            Console.WriteLine("Locações em andamento:");
            foreach (var aluguel in alugueis)
            {
                Console.WriteLine(aluguel.ToString());
            }
            Console.WriteLine("Fim da lista.");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
