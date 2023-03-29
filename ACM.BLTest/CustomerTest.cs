using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void CustomerValid()
        {
            //Arrange
            Customer customer = new Customer
            {
                FirstName = "Andreas",
                LastName = "Rasmussen"
            };
            string expected = "Rasmussen, Andreas";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //Arrange
            Customer customer = new Customer
            {
                FirstName = "Andreas"
            };
            string expected = "Andreas";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            //Arrange
            var c1 = new Customer();
            c1.FirstName = "Andreas";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Mads";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Mikkel";
            Customer.InstanceCount += 1;

            //Act

            //Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            //Arrange
            var customer = new Customer
            {
                LastName = "Rasmussen",
                EmailAddress = "xandreas@live.dk"
            };
            var expected = true;

            //Act
            var actual = customer.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingEmail()
        {
            //Arrange
            var customer = new Customer
            {
                FirstName = "Andreas"
            };
            var expected = false;

            //Act
            var actual = customer.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
            
        }
    }
}
