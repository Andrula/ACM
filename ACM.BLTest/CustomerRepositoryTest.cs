using ACM.BL;
using ACM.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void IsRetrieveValid()
        {
            //Arrange
            CustomerRepository customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                FirstName = "Andreas",
                LastName = "Rasmussen",
                EmailAddress = "Andreas@live.dk"
            };

            //Act
            var actual = customerRepository.Retrieve(1);

            //Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.LastName,actual.LastName);
            Assert.AreEqual(expected.FirstName,actual.FirstName);
            Assert.AreEqual(expected.EmailAddress,actual.EmailAddress);
           
        }

        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            //Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "Andreas@live.dk",
                FirstName = "Andreas",
                LastName = "Rasmussen",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressLineOne = "Randersgade",
                        AddressLineTwo = "66",
                        AddressType = 1,
                        City = "Copenhagen",
                        Region = "Sjaelland",
                        Country = "Denmark",
                        PostalCode = "2100",
                    },
                    new Address()
                    {
                        AddressLineOne = "Århussgade",
                        AddressLineTwo = "46",
                        AddressType = 2,
                        City = "Copenhagen",
                        Region = "Sjaelland",
                        Country = "Denmark",
                        PostalCode = "2100",
                    },
                    new Address()
                    {
                        AddressLineOne = "Jyllandssgade",
                        AddressLineTwo = "52",
                        AddressType = 1,
                        City = "Copenhagen",
                        Region = "Sjaelland",
                        Country = "Denmark",
                        PostalCode = "2100"
                    }
                }
            };

            //Act
            var actual = customerRepository.Retrieve(1);

            //Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);

            for (int i = 0; i < 1; i++)
            {

            }


        }
    }
}
