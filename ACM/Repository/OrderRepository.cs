using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACM.BL;

namespace ACM.Repository
{
    public class OrderRepository
    {
        public bool Save()
        {
            // Code to save

            return true;
        }

        public Order Retrieve(int orderId)
        {
            // Code that retrieves data 
            Order order = new Order(orderId);
            
            if(orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00,
                new TimeSpan(7, 0, 0));
            };
            return order;
        }
    }
}
