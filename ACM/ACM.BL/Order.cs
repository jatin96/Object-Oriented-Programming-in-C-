using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Order
    {
        public Order()
        {

        }
        public Order(int orderId)
        {
            orderId = orderId;
        }
        public DateTimeOffset? OrderDate { set; get; }
        public int OrderId { get; private set; }
        public Order Retrieve(int orderId)
        {
            return new Order();
        }
        public bool Save()
        {
            return true;
        }
        public bool Validate()
        {
            var isValid = true;
            if (OrderDate == null) isValid = false;
            return isValid;
        }

    }

}
