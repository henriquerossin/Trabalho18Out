using Trabalho18Out.Abstracts;
using Trabalho18Out.Entities;
using Trabalho18Out.Models;

namespace Trabalho18Out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RentalCompany RentalCompany = new RentalCompany();

            List<string> mainOptions = new List<string>()
            {
                "Menu Clientes",
                "Menu Veículos",
                "Menu Locações",
                "Voltar ao menu principal"
            };

            List<string> customerOptions = new List<string>()
            {
                "Cadastrar Cliente",
                "Listar Clientes",
                "Atualizar Cliente",
                "Remover Cliente",
                "Voltar ao Menu Principal"
            };

            List<string> vehicleOptions = new List<string>()
            {
                "Cadastrar Veículo",
                "Listar Veículos",
                "Atualizar Veículo",
                "Voltar ao Menu Principal"
            };

            List<string> rentaleOptions = new List<string>()
            {
                "Cadastrar Locação",
                "Listar Locações",
                "Finalizar Locação",
                "Remover Locação",
                "Voltar ao Menu Principal"
            };

            void CreateCustomer()
            {
                Console.WriteLine("Informe o nome do cliente:");
                string name = Console.ReadLine() ?? "";
                Console.WriteLine("Informe a data de nascimento do cliente:");
                DateOnly birthDate = DateOnly.Parse(Console.ReadLine() ?? "");
                Console.WriteLine("Informe o email do cliente:");
                string email = Console.ReadLine() ?? "";
                Console.WriteLine("Informe o logradouro do cliente: ");
                string street = Console.ReadLine() ?? "";
                Console.WriteLine("Informe o número do endereço do cliente: ");
                string number = Console.ReadLine() ?? "";
                Console.WriteLine("Informe o complemento do endereço do cliente: ");
                string complement = Console.ReadLine() ?? "";
                Console.WriteLine("Informe o bairro do cliente: ");
                string neighborhood = Console.ReadLine() ?? "";
                Console.WriteLine("Informe a cidade do cliente: ");
                string city = Console.ReadLine() ?? "";
                Console.WriteLine("Informe o estado do cliente: ");
                string state = Console.ReadLine() ?? "";
                Console.WriteLine("Informe o CEP do cliente: ");
                string zipCode = Console.ReadLine() ?? "";

                var contact = new Contact(email, null);

                var address = new Address(street, int.Parse(number), neighborhood, zipCode, complement, city, state, "BR");

                Console.Write("Qual tipo de cliente está cadastrando (1 - Pessoa física, 2 - Pessoa jurírica): ");
                int customerType = int.Parse(Console.ReadLine() ?? "1");

                if (customerType == 1)
                {
                    Console.Write("Informe o número da CNH: ");
                    string cnh = Console.ReadLine() ?? "";
                    Console.Write("Informe do número do CPF: ");
                    string cpf = Console.ReadLine() ?? "";
                    var customer = new CustomerPF(name, birthDate, contact, address, cnh, cpf);

                    RentalCompany.Customers.Add(customer);
                }
                else
                {
                    Console.Write("Informe o CNPJ da empresa: ");
                    string cnpj = Console.ReadLine() ?? "";
                    var customer = new CustomerPJ(name, birthDate, contact, address, cnpj);
                    RentalCompany.Customers.Add(customer);
                }
            }

            Person FindCustomerByName(string name)
            {
                return RentalCompany.Customers.Find(c => c.GetName() == name)!; // Função lambda.
            }

            void DeleteCustomer()
            {
                Console.Write("Informe o nome do cliente a ser removido: ");
                string name = Console.ReadLine() ?? "";
                var customer = FindCustomerByName(name);
                if (customer is not null)
                {
                    RentalCompany.Customers.Remove(customer);
                    Console.WriteLine("Cliente removido com sucesso.");
                }
                else
                {
                    Console.WriteLine("Cliente não encontrado.");
                }
            }

            void ListCustomers()
            {
                Console.WriteLine("--- Lista de Clientes ---");
                foreach (var customers in RentalCompany.Customers)
                {
                    Console.WriteLine(customers);
                    //Console.WriteLine(customers.ToString());
                }
            }

            Person UpdatePhone()
            {
                Console.Write("Informe o nome do cliente que será analizado: ");
                string name = Console.ReadLine() ?? "";
                var customer = FindCustomerByName(name);

                if (customer is not null)
                {
                    Console.WriteLine("Informe o telefone do cliente: ");
                    string phone = Console.ReadLine() ?? "";
                    customer.SetContactPhone(phone);
                    Console.WriteLine("Telefone atualizado com sucesso.");
                }
                else
                {
                    Console.WriteLine("Cliente não encontrado.");
                }
                    return customer!;
            }

            void CustomerMenu(int options)
            {
                switch (options)
                {
                    case 1:
                        CreateCustomer();
                        break;
                    case 2:
                        ListCustomers();
                        break;
                    case 3:
                        Console.WriteLine(UpdatePhone());
                        break;
                    case 4:
                        DeleteCustomer();
                        break;
                    case 5:
                        Console.WriteLine("Retornando ao Menu Principal");
                        break;
                }
            }

            do
            {
                int mainChoice = Menu.Display("--- Menu Principal ---", mainOptions);

                switch (mainChoice)
                {
                    case 1:
                        int customerChoice = Menu.Display("--- Menu Clientes ---", customerOptions);
                        CustomerMenu(customerChoice);
                        break;
                    case 2:
                        int vehicleChoice = Menu.Display("--- Menu Veículos ---", vehicleOptions);
                        break;
                    case 3:
                        int rentalChoice = Menu.Display("--- Menu Locações ---", rentaleOptions);
                        break;
                    case 4:
                        Console.WriteLine("Saindo do programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            } while (true);
        }
    }
}
