using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer : EntityBase
    {
        /* Constructors */
        public Customer()
        {

        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }

        /* Fields */

        public List<Address> AddressList { get; set; }

        public int CustomerId { get; private set; }
        public string EmailAddress {  get; set; }

        public static int InstanceCount { get; set; }

        public string FirstName { get; set; }

        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }


        public string FullName
        {
            get 
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        /* Methods */

        // Method that validate inserted values.
        public override bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        public string log() => $"{CustomerId}: {FullName} Email: {EmailAddress} Status {EntityState.ToString()}";
    }
}
