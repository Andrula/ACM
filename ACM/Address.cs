using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM
{
    public class Address
    {
        /* Constructors */
        public Address()
        {

        }

        public Address(int addressId)
        {
            AddressId = addressId;
        }

        /* Fields */
        public int AddressId { get; set; }
        public int AddressType { get; set; }
        public string AddressLineOne { get; set; }
        public string AddressLineTwo { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        public bool Validate()
        {
            var isValid = true;

            if (PostalCode == null) isValid = false;

            return isValid;
        }
    }
}
