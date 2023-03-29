using ACM.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.Repository
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }


        // Method that returns the defined customer
        public Customer Retrieve(int customerId)
        {
            // code that returns the costumer
            Customer customer = new Customer(customerId);

            if(customerId == 1)
            {
                customer.FirstName = "Andreas";
                customer.LastName = "Rasmussen";
                customer.EmailAddress = "Andreas@live.dk";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }
            return customer;
        }

        // Method that saves data
        public bool Save()
        {
            // code that saves the data

            return true;
        }
    }
}
