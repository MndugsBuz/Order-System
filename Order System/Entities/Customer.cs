using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_System.Entities
{
    public class Customer
    {
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }    
        public double CustomerPaymentAmount { get; set; } 
        public int CustomerPaymentConditions { get; set; }

        private List<Customer> customers { get; set; }

        public Customer()
        {
        }
        public Customer (string id, string name, double amount, int conditions)
        {
            this.CustomerId = id;
            this.CustomerName = name;   
            this.CustomerPaymentAmount = amount; 
            this.CustomerPaymentConditions = conditions;
        }
     }
}
