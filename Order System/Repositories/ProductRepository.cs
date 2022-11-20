using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

    }
}
