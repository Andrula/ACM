using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM
{
    public class Order
    {
        /* Constructors */
        public Order()
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        /* Fields */
        public int OrderId { get; set; }
        public DateTimeOffset OrderDate { get; set; }

        public bool Validate ()
        {
            var isValid = true;
            // Code to validate

            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}
