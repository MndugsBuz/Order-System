using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Order_System.Entities;

namespace Order_System.Repositories
{
    public class OrderItemRepository
    {
        private List<OrderItem> orderItems { get; set; } = new List<OrderItem>();

        public OrderItemRepository()
        {
            orderItems.Add(new OrderItem(219128, "44232418", 1)); // Order number, ProductId, Quantity 
            orderItems.Add(new OrderItem(219228, "46998122", 2));
            orderItems.Add(new OrderItem(219598, "37312368", 1));
            orderItems.Add(new OrderItem(219458, "52306809", 1));
            orderItems.Add(new OrderItem(219396, "47651442", 1));
          
        }

        public List<Customer> AddOrderItem()
        {
            Console.WriteLine("[1] Order Number");
            int orderNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("[2] Product Id");
            string productId = Console.ReadLine();
            Console.WriteLine("[3] Quantity");
            decimal quantity = decimal.Parse(Console.ReadLine());
            orderItems.Add(new OrderItem(orderNumber, productId, quantity));
                       
            return orderItems;
        }

        public List<Customer> DeteleCustomer()
        {
            Console.WriteLine("[2] Enter Customer number to Delete");
            int customernumberDelete = int.Parse(Console.ReadLine());
            orderItems.RemoveAt(customernumberDelete - 1);

            return orderItems;
        }

    }
}
