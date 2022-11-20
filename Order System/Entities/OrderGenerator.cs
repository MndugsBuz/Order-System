using Order_System.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_System.Entities
{
    public class OrderGenerator
    {
        public AddressRepository addressRepository;
        public CustomerRepository customerRepository;
        public OrdersRepository orderRepository; 
        public OrderItemRepository orderItemRepository;
        public ProductRepository productRepository;

       // public List<ReportItem> Report = new List<ReportItem>();
    }


}
