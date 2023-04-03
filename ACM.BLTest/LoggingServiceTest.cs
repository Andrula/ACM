using ACM.BL;
using ACME.common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ACM.BLTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {

            //Arrange
            var changedItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                EmailAddress = "Andreas@live.dk",
                FirstName = "Andreas",
                LastName = "Rasmussen",
                AddressList = null
            };
            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Cola",
                ProductDescription = "A soft drink",
                CurrentPrice = 6
            };
            changedItems.Add(product);

            //Act
            LoggingService.WriteToFile(changedItems);
            
            //Assert
            //nothing happens here to assert.

        }
    }
}
