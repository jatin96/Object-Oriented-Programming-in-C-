using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //Arrange
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                ProductName = "Azure",
                Description = "Cloud storage by Microsoft",
                CurrentPrice = 19.2M
            };

            //Access
            var actual = productRepository.Retrieve(2);
            //Assert
            //You cannot compare like this because objects are equal only when they point to the same memory location.
            //Assert.AreEqual(expected, actual);
            //you have to compare each property separately

            Assert.AreEqual(expected.ProductId, actual.ProductId);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.Description, actual.Description);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);

        }
    }
}
