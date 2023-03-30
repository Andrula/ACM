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
        [TestMethod]
        public void ValidateSaveProduct()
        {
            //Arrange
            var productRepository = new ProductRepository();
            var updatedProdut = new Product(2)
            {
                ProductName = "Cola",
                ProductDescription = "A drink",
                CurrentPrice = 10,
                IsChanged = true,
            };

            //Act
            var actual = productRepository.Save(updatedProdut);

            //Assert
            Assert.AreEqual(true, actual);
        }
        [TestMethod]
        public void SaveTestInvalid()
        {
            //Arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                ProductName = "Cola",
                ProductDescription = "A drink",
                CurrentPrice = null,
                IsChanged = true,
            };

            //Act
            var actual = productRepository.Save(updatedProduct);

            //Assert
            Assert.AreEqual(false, actual);
        }
    }
}
