using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Order_System.Entities;
using Newtonsoft.Json;

namespace Order_System.Repositories
{
    public class OrdersRepository
    {
       private List<Order> orders { get; set; } = new List<Order>();
       public OrdersRepository ()
        {
            orders.Add(new Order("F00001", 219128, "2022 09 15", 2000*1)); // 4 OrderAmount = OrderItem.Quantity * Product.Price
            orders.Add(new Order("F00002", 219228, "2022 10 11", 1000*2));
            orders.Add(new Order("134010201", 219598, "2022 09 28", 2000*1));
            orders.Add(new Order("134030402", 219458, "2022 09 20", 3000*1));
            orders.Add(new Order("134050603", 219396, "2022 09 29", 4000*1)); 
        }

        public List<Order> RetrieveList()
        {
            return orders;
        }

        public List<Order> WriteToJson()
        {
            List<Order> writeOrders = new List<Order>();

            for (int i = 100; i < 105; i++)

                writeOrders.Add(new Order()
                {
                    CustomerId = "F001" + i,
                    OrderNumber = i,
                    OrderDate = "2022 10 25",
                    OrderAmount = 110 * i //OrderItem.Quantity * Product.Price,
                });

            //string writejson = JsonSerializer.SerializeObject(writeOrders);
            File.WriteAllText("C:/desktop ml/Renkuosi programuoti/Back-End C Sharp code/221017 code mb paskaita Basic_C#_exam/Order System/Order System/orders.json",
                JsonConvert.SerializeObject(writeOrders));

            return writeOrders;
        }

        public List<Order> ReadFromJson()
        {
            List<Order> readOrders = new List<Order>();
            string readjson = File.ReadAllText("C:\\desktop ml\\Renkuosi programuoti\\Back-End C Sharp code\\221017 code mb paskaita Basic_C#_exam\\Order System\\Order System\\orders.json");
            readOrders = JsonConvert.DeserializeObject<List<Order>>(readjson);

            foreach (var items in readOrders)
            {
                Console.Write(items.CustomerId + "|");
                Console.Write(items.OrderNumber + "|");
                Console.Write(items.OrderDate + "|");
                Console.Write(items.OrderAmount + "|");
                Console.WriteLine();
            }

            return readOrders;
        }
    }
}
