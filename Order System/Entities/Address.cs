using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_System.Entities
{
    public class Address
    {
        public string CustomerId { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public int PostalCode { get; set; }
        public string Street { get; set; }
        public int StreetNumber { get; set; }

        private List<Address> _addresses { get; set; }

        public Address()
        {
        }

        public Address ( string id, string city, string region, int postalCode, string street, int streeNumber)
        {
           this.CustomerId = id;
           this.City = city;
           this.Region = region;
           this.PostalCode = postalCode;
           this.Street = street;    
           this.StreetNumber = streeNumber;
                        
        }
    }
}

    
