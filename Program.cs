using System;
using exerc_proposto.Entities;
using exerc_proposto.Entities.Enums;
using static System.Console;

namespace exerc_proposto
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter client data:");
            Write("Name: ");
            string name = ReadLine();
            Write("Email: ");
            string email = ReadLine();
            Write("Birth Date (DD/MM/AAAA): ");
            DateTime birth = DateTime.Parse(ReadLine());
            Client client = new Client(name, email, birth);

            WriteLine("Enter order data: ");
            Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(ReadLine());

            Write("How many items to this order? ");
            Order order = new Order(DateTime.Now, status, client);

            int n = int.Parse(ReadLine());
            for (int i = 1; i <= n; i++)
            {
                WriteLine($"Enter #{i} item data:");
                Write("Product name:");
                string pName = ReadLine();
                Write("Product price: ");
                double price = double.Parse(ReadLine());

                Product product = new Product(name, price);

                Write("Quantity: ");
                int quantity = int.Parse(ReadLine());

                OrderItem orderItem = new OrderItem(quantity, price, product);

                order.addItem(orderItem);
            }
            WriteLine();

            WriteLine("ORDER SUMMARY:");
            WriteLine(order);
        }
    }
}