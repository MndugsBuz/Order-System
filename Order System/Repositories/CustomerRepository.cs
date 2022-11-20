using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Order_System.Entities;

namespace Order_System.Repositories
{
    public class CustomerRepository
    {
        private List<Customer> customers { get; set; } = new List<Customer>();

        public CustomerRepository()
        {
            customers.Add(new Customer("F00001", "Petras Petraitis", 2000.00, 0)); // 3 CustomerPaymentAmount
            customers.Add(new Customer("F00002", "Jonas  Jonaitis", 2500.00, 0));
            customers.Add(new Customer("134010201", "Company A", 5000.00, 0));
            customers.Add(new Customer("134030402", "Company B", 3000.00, 0));
            customers.Add(new Customer("134050603", "Company C", 2500.00, 15));
        }

        public List<Customer> New()
        {
            return customers;
        }

        public List<Customer> Delete()
        {
            return customers;
        }
    }
}
