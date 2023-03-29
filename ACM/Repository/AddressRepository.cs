using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ACM.Repository
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);

            if (addressId == 1)
            {
                address.AddressLineOne = "Randersgade";
                address.AddressLineTwo = "66";
                address.AddressType = 1;
                address.City = "Copenhagen";
                address.Region = "Sjaelland";
                address.Country = "Denmark";
                address.PostalCode = "2100";
            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressLineOne = "Randersgade",
                AddressLineTwo = "66",
                AddressType = 1,
                City = "Copenhagen",
                Region = "Sjaelland",
                Country = "Denmark",
                PostalCode = "2100",
            };
            addressList.Add(address);

            Address address2 = new Address(2)
            {
                AddressLineOne = "Århussgade",
                AddressLineTwo = "46",
                AddressType = 2,
                City = "Copenhagen",
                Region = "Sjaelland",
                Country = "Denmark",
                PostalCode = "2100",
            };
            addressList.Add(address2);

            Address address3 = new Address(3)
            {
                AddressLineOne = "Jyllandssgade",
                AddressLineTwo = "52",
                AddressType = 3,
                City = "Copenhagen",
                Region = "Sjaelland",
                Country = "Denmark",
                PostalCode = "2100",
            };
            addressList.Add(address3);

            return addressList;
        }

        public bool Save(Address address)
        {
            // Code to save data

            return true;
        }
    }
}
