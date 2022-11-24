using Order_System.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Order_System.Repositories;
using Order_System.Entities;


namespace Order_System
{
    public class OrdersReportGenerator
    {
        public CustomerRepository customerRepository;
        public OrderItemRepository orderItemRepository;
        public OrdersRepository ordersRepository;
        public ProductRepository productRepository;

        public List<OrderReportItem> Report = new List<OrderReportItem>();

        public OrdersReportGenerator(CustomerRepository customerRepository, OrderItemRepository orderItemRepository, OrdersRepository ordersRepository, ProductRepository productRepository, List<OrderReportItem> report)
        {
            this.customerRepository = customerRepository;
            this.orderItemRepository = orderItemRepository;
            this.ordersRepository = ordersRepository;
            this.productRepository = productRepository;
        } 
        
        public List<OrderReportItem> GenerateReportUnpaidOrders()
        {
           // List<Order> orders = ordersRepository.RetrieveList();
            List<Customer> retrieveCustomers = new List<Customer>();
            List<OrderItem> retrieveOderItems = new List<OrderItem>();
            List<OrderReportItem> reportItems = new List<OrderReportItem>();

           /* foreach (var order in orders)
            {

            }
           */
           


            reportItems.Add(new OrderReportItem()
            {


            });

            return reportItems;
        }
    }

    

    



}
