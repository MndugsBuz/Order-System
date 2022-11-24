using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Order_System.Entities;

namespace Order_System.Repositories
{
    public class ProductRepository
    {
        private List<Product> _products = new List<Product>(); 

        public ProductRepository ()
     
        { 
          _products.Add(new Product("44232418", "Lenovo ThinkPad P15v Gen 2", "21A90020MH", 2268.0m, "pcs", 10.0m ));
          _products.Add(new Product("46998122", "Lenovo ThinkPad P15v 15.6",  "IPS, FHD, 1920 x 1080, i7, i7-11800H, 32 GB, NVIDIA T1200, GDDR6, 4 GB", 3219.6m, "pcs", 5.0m));
          _products.Add(new Product("37312368", "Dell XPS 17 9700", "FHD+ i7-10875H RTX2060 32GB 1TB", 2295.0m, "pcs", 10.0m ));
          _products.Add(new Product("52306809", "Dell XPS 9510, 15.6", "FHD+ i7-11800H, 16 GB, 1 TB, NVGeForce RTX 3050 Ti", 2351.0m, "pcs", 5.0m));
          _products.Add(new Product("47651442", "Apple MacBook Pro 16", "M1 Max 32/1TB Silver SWE MK1H3KS/A", 3649.0m, "pcs", 5.0m ));
        }

        public List<Product> WriteToJson()
        {
            File.WriteAllText("C:/desktop ml/Renkuosi programuoti/Back-End C Sharp code/221017 code mb paskaita Basic_C#_exam/Order System/Order System/products.json",
            JsonConvert.SerializeObject(_products));
            Console.WriteLine("Products writed to JSON file");

            return _products;
        }

        public List<Product> ReadFromJson()
        {
            string readjson = File.ReadAllText("C:\\desktop ml\\Renkuosi programuoti\\Back-End C Sharp code\\221017 code mb paskaita Basic_C#_exam\\Order System\\Order System\\customers.json");
            _products = JsonConvert.DeserializeObject<List<Product>>(readjson);

            return _products;
        }

        public List<Product> AddProduct()
        {
            Console.WriteLine("[1] Product Id");
            string productId = Console.ReadLine();
            Console.WriteLine("[2] Product Name");
            string productName = (Console.ReadLine());
            Console.WriteLine("[3] Product Description");
            string productDescription = Console.ReadLine();
            Console.WriteLine("[4] Product price format 10,00");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("[5] Product price format pcs");
            string unitOfMeasurement = Console.ReadLine();
            Console.WriteLine("[6] Product Balance");
            decimal productBalance = decimal.Parse(Console.ReadLine());
            _products.Add(new Product(productId, productName, productDescription, price, unitOfMeasurement, productBalance));

            return _products;
        }

        public List<Product> DeleteProduct()
        {
            Console.WriteLine("[2] Enter Customer name to Delete");
            string productnametoDelete = Console.ReadLine();
            foreach (var item in _products)
            {

                if (item.ProductName == productnametoDelete)
                {
                    Console.WriteLine("Removing order with number: " + item.ProductName);
                    _products.Remove(item);
                    break;
                }
            }
            return _products;
        }

        public void PrintProducts()
        {
            Console.WriteLine("Customers:");
            int index = 1;
            foreach (var items in _products)
            {
                Console.Write(index + ". ");
                Console.Write(items.ProductId + "|");
                Console.Write(items.ProductName + "|");
                Console.Write(items.ProductDescription + "|");
                Console.Write(items.Price + "|");
                Console.Write(items.UnitOfMeasurement + "|");
                Console.Write(items.Balance + "|");
                Console.WriteLine();
                index++;
            }
            Console.WriteLine();
        }

    }

}


