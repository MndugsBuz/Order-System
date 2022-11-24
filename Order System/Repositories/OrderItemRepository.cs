using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Order_System.Entities;

namespace Order_System.Repositories
{
    public class OrderItemRepository
    {
        private List<OrderItem> orderItems { get; set; } = new List<OrderItem>();

        public OrderItemRepository()
        {
            orderItems.Add(new OrderItem("219128", "44232418", 1)); // Order number, ProductId, Quantity 
            orderItems.Add(new OrderItem("219228", "46998122", 2));
            orderItems.Add(new OrderItem("219598", "37312368", 1));
            orderItems.Add(new OrderItem("219458", "52306809", 1));
            orderItems.Add(new OrderItem("219396", "47651442", 1));
          
        }

        public List<OrderItem> WriteToJson()
        {
            File.WriteAllText("C:/desktop ml/Renkuosi programuoti/Back-End C Sharp code/221017 code mb paskaita Basic_C#_exam/Order System/Order System/orderitems.json",
            JsonConvert.SerializeObject(orderItems));
            Console.WriteLine("OrderItems writed to JSON file");

            return orderItems;
        }

        public List<OrderItem> ReadFromJson()
        {
            string readjson = File.ReadAllText("C:\\desktop ml\\Renkuosi programuoti\\Back-End C Sharp code\\221017 code mb paskaita Basic_C#_exam\\Order System\\Order System\\orderitems.json");
            orderItems = JsonConvert.DeserializeObject<List<OrderItem>>(readjson);

            return orderItems;
        }

        public List<OrderItem> AddOrderItem()
        {
            Console.WriteLine("[1] Order Number");
            string orderNumber = (Console.ReadLine());
            Console.WriteLine("[2] Product Id");
            string productId = Console.ReadLine();
            Console.WriteLine("[3] Quantity");
            decimal quantity = decimal.Parse(Console.ReadLine());
            orderItems.Add(new OrderItem(orderNumber, productId, quantity));

            return orderItems;
        }

        public List<OrderItem> DeleteOrderItem()
        {
            Console.WriteLine("[2] Enter Order number to Delete");
            string ordernumbertoDelete = Console.ReadLine();
            foreach (var item in orderItems)
            {

                if (item.OrderNumber == ordernumbertoDelete)
                {
                    Console.WriteLine("Removing order with number: " + item.OrderNumber);
                    orderItems.Remove(item);
                    break;
                }
            }

            return orderItems;
        }
        public void PrintOrderItems()
        {
            Console.WriteLine("OrderItems:");
            int index = 1;
            foreach (var items in orderItems)
            {
                Console.Write(index + ". ");
                Console.Write(items.OrderNumber + "|");
                Console.Write(items.ProductId + "|");
                Console.Write(items.Quantity + "|");
                Console.WriteLine();
                index++;
            }
            Console.WriteLine();
        }
    }
}

   
