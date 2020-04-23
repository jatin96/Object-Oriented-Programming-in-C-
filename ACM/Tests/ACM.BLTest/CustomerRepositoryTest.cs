using System;
using System.Linq.Expressions;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "jatin.jt.narula@gmail.com",
                FirstName = "Jatin",
                LastName = "Narula"
            };

            //Access
            var actual = customerRepository.Retrieve(1);
            //Assert
            //You cannot compare like this because objects are equal only when they point to the same memory location.
            //Assert.AreEqual(expected, actual);
            //you have to compare each property separately

            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.LastName, actual.LastName);

        }
    }
}
