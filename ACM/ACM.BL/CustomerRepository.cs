using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            if (customerId == 1)
            {
                customer.EmailAddress = "jatin.jt.narula@gmail.com";
                customer.FirstName = "Jatin";
                customer.LastName = "Narula";
            }
            return customer;
        }
        public bool save(Customer customer)
        {
            return true;
        }
    }
}
