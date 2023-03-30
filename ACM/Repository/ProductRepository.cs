using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.Repository
{
    public class ProductRepository
    {
        public bool Save(Product product)
        {
            var succes = true;

            if (product.IsChanged)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        // call stored procedure
                    }
                    else
                    {
                        // call store procedure
                    }
                }
                else
                {
                    succes = false;
                }
            }
            return succes;
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
