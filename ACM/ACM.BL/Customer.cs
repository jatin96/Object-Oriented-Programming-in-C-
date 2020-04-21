using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public Customer()
        {

        }
        public Customer(int customerId)
        {
            CustomerId = CustomerId;
        }
        public int CustomerId { get; private set; }
        // FirstName is the property. When you just want to set and get the value to a backing field, use this shortcut way to assign and get the values.
        public string FirstName { get; set; }
        //this is the more generic way to get or set values. _lastName is the backing field. LastName is it's property. use this method when you have to do 
        // some modifications before setting the value to the backing field. public in a property means that it can be accessed outside the project too. use internal
        // if you want the access to be inside the project only.
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
        public string  EmailAddress { get; set; }
        public string FullName
        {
            get
            {
                string FullName;
                if (string.IsNullOrWhiteSpace(FirstName))
                    FullName = LastName;
                else if (string.IsNullOrWhiteSpace(LastName))
                    FullName = FirstName;
                else
                    FullName = LastName + ", " + FirstName;

                return FullName;
            }
        }
        public Customer Retrieve(int customerId)
        {
            return new Customer();
        }
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }
        public bool Validate()
        {
            var isValid = true;
            if (String.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (String.IsNullOrWhiteSpace(EmailAddress)) isValid = false;
            return isValid;
        }


    }
}
