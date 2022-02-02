using System;
using System.Globalization;
using exercEnum.Entities;

namespace exercEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ler os dados de um pedido com N itens (N fornecido pelo usuário).
            //Depois, mostrar um sumário do pedido conforme exemplo(próxima página).
            //Nota: o instante do pedido deve ser o instante do sistema: DateTime.Now

            Console.WriteLine("DADOS DO CLIENTE");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Data de nascimento (DD/MM/AAAA): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine(), new CultureInfo("pt-br"));
            Console.WriteLine("-------------------");
            Console.WriteLine("DADOS DO PEDIDO");
            Console.Write("Status (pending_payment / processing / shipped / delivered): ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(name, email, birthDate);
            Order Order = new Order(DateTime.Now, status, client);

            Console.Write("Número de itens do pedido: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Entre dados item {i}");
                Console.Write("Nome do produto: ");
                string productName = Console.ReadLine();
                Console.Write("Preço do produto: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(productName, productPrice);

                Console.Write("Quantidade: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem OrderItem = new OrderItem(productPrice, quantity, product);

                Order.AddItem(OrderItem);

            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY");
            Console.WriteLine(Order);
        }
    }
}
