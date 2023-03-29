using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.Repository
{
    public class ProductRepository
    {
        public bool Save()
        {
            //Code to save

            return true;
        }

        public Product Retrieve(int productId)
        {
            Product product = new Product(2)
            {
                ProductName = "Cola",
                ProductDescription = "A drink",
                CurrentPrice = 10
            };

            return product;
        }
    }
}
