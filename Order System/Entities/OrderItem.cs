using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_System.Entities
{
    public class OrderItem
    {
        public string OrderNumber { get; set; } 
        public string ProductId { get; set; }   
        public decimal Quantity { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(string number, string id, decimal quantity)
        {
            this.OrderNumber = number;
            this.ProductId = id;    
            this.Quantity = Quantity;
        }
    }



}
