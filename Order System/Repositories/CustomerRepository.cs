using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
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

        public List<Customer> WriteToJson()
        {
            File.WriteAllText("C:/desktop ml/Renkuosi programuoti/Back-End C Sharp code/221017 code mb paskaita Basic_C#_exam/Order System/Order System/customers.json",
            JsonConvert.SerializeObject(customers));
            Console.WriteLine("Customers writed to JSON file");

            return customers;
        }

        public List<Customer> ReadFromJson()
        {
            string readjson = File.ReadAllText("C:\\desktop ml\\Renkuosi programuoti\\Back-End C Sharp code\\221017 code mb paskaita Basic_C#_exam\\Order System\\Order System\\customers.json");
            customers = JsonConvert.DeserializeObject<List<Customer>>(readjson);

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

            return customers;
        }

        public List<Customer> DeteleCustomer()
        {
            Console.WriteLine("[2] Enter Customer name to Delete");
            string customernumbertoDelete = Console.ReadLine();
            foreach (var item in customers)
            {

                if (item.CustomerName == customernumbertoDelete)
                {
                    Console.WriteLine("Removing order with number: " + item.CustomerName);
                    customers.Remove(item);
                    break;
                }
            }
            return customers;
        }

        public void PrintCustomers()
        {
            Console.WriteLine("Customers:");
            int index = 1;
            foreach (var items in customers)
            {
                Console.Write(index + ". ");
                Console.Write(items.CustomerId + "|");
                Console.Write(items.CustomerName + "|");
                Console.Write(items.CustomerPaymentAmount + "|");
                Console.Write(items.CustomerPaymentConditions + "|");
                Console.WriteLine();
                index++;
            }
            Console.WriteLine();
        }

    }

}
