using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                FirstName = "Jatin",
                LastName = "Narula"
            };
            string expected = "Narula, Jatin";

            //--Access
            string actual = customer.FullName;
            //--Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameTestFirstNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                LastName = "Narula"
            };
            string expected = "Narula";

            //--Access
            string actual = customer.FullName;
            //--Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                FirstName = "Jatin"
            };
            string expected = "Jatin";

            //--Access
            string actual = customer.FullName;
            //--Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateValid()
        {
            //Arrange
            Customer customer = new Customer { LastName = "Narula", EmailAddress = "jatin.jt.narula@gmail.com" };
            var expected = true;

            //Access
            var actual = customer.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateMissingLastName()
        {
            //arrange
            var customer = new Customer { EmailAddress = "jatin.jt.narula@gmail.com" };
            var expected = false;
            //access
            var actual = customer.Validate();
            //assert
            Assert.AreEqual(expected, actual);
        }


    }
}
