using Order_System.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_System.Repositories
{
    public class AddressRepository
    {
        private List<Address> addresses { get; set; } = new List<Address>();

        public AddressRepository ()
        {
            addresses.Add(new Address("F00001", "Kaunas", "Lithuania", 53211, "Kauno g.", 1));
            addresses.Add(new Address("F00002", "Vilnius",  "Lithuania", 21123, "Vilniaus g.", 1));
            addresses.Add(new Address("134010201", "Kaunas", "Lithuania", 53531, "Vilniaus g.", 20));
            addresses.Add(new Address("134030402", "Kaunas", "Lithuania", 53001, "Tilto g.", 15));
            addresses.Add(new Address("134050603", "Vilnius", "Lithuania", 21123, "Lietaus g.", 10));
           
        }

    }
}
