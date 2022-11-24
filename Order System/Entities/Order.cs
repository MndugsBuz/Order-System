using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_System.Entities
{
    public class Order
    { 
        public string CustomerId { get; set; }  
        public string OrderNumber { get; set; }    
        public string OrderDate { get; set; }
        public double OrderAmount { get; set; }
        private List<Order> orders { get; set; }

     public Order ()
        {
        }

        public Order(string id, string number, string date, double amount)
        {
            this.CustomerId = id;
            this.OrderNumber = number;  
            this.OrderDate = date;
            this.OrderAmount = amount; // product price * orderitem quantity
        }
   }
}
