using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM
{
    public class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }    
        public int Quantity { get; set; }
        
        public bool Validate()
        {
            var isValid = true;
            // Code to validate
            if(Quantity <= 0) isValid = false;
            if(ProductId <= 0) isValid = false;
            if(PurchasePrice == 0) isValid = false;

            return isValid;
        }

        public bool Save()
        {
            // Code to save

            return true;
        }

        public OrderItem Retrieve(int orderItemId)
        {
            // Code to retrieve

            return new OrderItem(); 
        }
    }
}
