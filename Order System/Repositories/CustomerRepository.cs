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

        public List<Customer> AddCustomer()
        {
            Console.WriteLine("[1] Customer Id");
            string customerId = Console.ReadLine();
            Console.WriteLine("[2] Customer Name");
            string customerName = (Console.ReadLine());
            Console.WriteLine("[3] Customer Payment Amount");
            double customerPaymentAmount = double.Parse(Console.ReadLine());
            Console.WriteLine("[4] Customer Payment Conditions (number of days)");
            int customerPaymentConditions = int.Parse(Console.ReadLine());
            customers.Add(new Customer(customerId, customerName, customerPaymentAmount, customerPaymentConditions));

            foreach (var items in customers)
            {
                Console.Write(items.CustomerId + "|");
                Console.Write(items.CustomerName + "|");
                Console.Write(items.CustomerPaymentAmount + "|");
                Console.Write(items.CustomerPaymentConditions + "|ADDCustomer");
                Console.WriteLine();
            }
            return customers;
        }

        public List<Customer> DeteleCustomer()
        {
            Console.WriteLine("[2] Enter Customer number to Delete");
            int customernumberDelete = int.Parse(Console.ReadLine());
            customers.RemoveAt(customernumberDelete - 1);

            foreach (var items in customers)
            {
                Console.Write(items.CustomerId + "|");
                Console.Write(items.CustomerName + "|");
                Console.Write(items.CustomerPaymentAmount + "|");
                Console.Write(items.CustomerPaymentConditions + "|RemoveCustomer");
                Console.WriteLine();
            }
            return customers;
        }
              
    }

}
