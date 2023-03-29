using ACM.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void ValidateProduct()
        {
            //Arrange
            ProductRepository productRepository = new ProductRepository();  
            Product product = new Product(2)
            {
                ProductDescription = "A drink",
                ProductName = "Cola",
                CurrentPrice = 10
            };
            var expected = product;

            //Act
            var actual = productRepository.Retrieve(2);

            //Assert
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);

        }
    }
}
