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
                Console.WriteLine("1. Cadastrar veículo");
                Console.WriteLine("2 - Exibir veículos cadastrados: ");
                Console.WriteLine("3 - Cadastrar cliente: ");
                Console.WriteLine("4 - Exibir clientes cadastrados: ");
                Console.WriteLine("5 - Realizar locação de veículo: ");

            } while (true);

        }
    }
}
