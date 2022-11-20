using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_System.Entities
{
    public class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price { set; get; }
        public string UnitOfMeasurement { get; set; }
        public decimal Balance { set; get; } 

        private List<Product> _products { get; set; }

        public Product()
        { 
        }

        public Product(string id, string name, string description, decimal price, string unit, decimal balance)

        {
            this.ProductId = id;
            this.ProductName = name;
            this.ProductDescription = description;
            this.Price = price;
            this.UnitOfMeasurement = unit;
       
        }
             
    }
}
