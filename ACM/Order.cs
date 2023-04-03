using ACME.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM
{
    public class Order : EntityBase, ILoggable
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
        public int CustomerId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public int ShippingAddressId { get; set; }


        public string Log() =>
            $"{OrderId}: Date: {this.OrderDate.Value.Date} Status: {EntityState}";

        public override string ToString() =>
            $"{OrderDate.Value.Date} ({OrderId})";

        public override bool Validate()
        {
            var isValid = true;
            // Code to validate

            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}
