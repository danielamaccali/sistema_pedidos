using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using exercEnum.Entities;

namespace exercEnum.Entities
{
    class Order
    {
        DateTime moment;
        OrderStatus status;
        Client client;
        List<OrderItem> Items = new List<OrderItem>();

        public Order ()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            this.moment = moment;
            this.status = status;
            this.client = client;
        }

        public void AddItem (OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem (OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0;
            foreach (OrderItem item in Items)
            {
                sum += item.subTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine("Order moment: " + moment.ToString("dd/MM/yyyy HH:mm:ss"));
            text.AppendLine("Order status: " + status);
            text.AppendLine("Client: " + client);
            text.AppendLine("");
            text.AppendLine("Order items: ");
            foreach (OrderItem item in Items)
            {
                text.AppendLine(item.ToString());
            }
            text.AppendLine($"Total price: R${Total().ToString("F2", CultureInfo.InvariantCulture)}");
            return text.ToString();
        }
    }
}
