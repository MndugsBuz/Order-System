using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_System.Entities
{
    public class OrderItem
    {
        public int OrderNumber { get; set; } 
        public string ProductId { get; set; }   
        public decimal Quantity { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int number, string id, double quantity)
        {
            this.OrderNumber = number;
            this.ProductId = id;    
            this.Quantity = Quantity;
        }
    }



}
