namespace Trabalho18Out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Locacao locacao = new Locacao();
            int opcao;

            do
            {
                Console.WriteLine("Escolha uma das opções: ");
                Console.WriteLine("1 - Cadastrar veículo");
                Console.WriteLine("2 - Exibir veículos cadastrados: ");
                Console.WriteLine("3 - Cadastrar cliente: ");
                Console.WriteLine("4 - Exibir clientes cadastrados: ");
                Console.WriteLine("5 - Realizar locação de veículo: ");
                Console.WriteLine("6 - Exibir locações: ");
                Console.WriteLine("7 - Encerrar sistema.");
                opcao = int.Parse(Console.ReadLine()!);

                switch (opcao)
                {
                    case 1:
                        locacao.CadastrarVeiculo();
                        break;
                    case 2:
                        locacao.ListarVeiculos();
                        break;
                    case 3:
                        locacao.CadastrarCliente();
                        break;
                    case 4:
                        locacao.ListarClientes();
                        break;
                    case 5:
                        locacao.RealizarLocacao();
                        break;
                    case 6:
                        locacao.ListarLocacoes();
                        break;
                    case 7:
                        Console.WriteLine("Encerrando sistema.");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

            } while (opcao != 7);
        }
    }
}
