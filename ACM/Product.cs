using ACME.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ACM
{   
    /// 
    // Constructors
    /// 

    public class Product : EntityBase
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        }

        /// 
        // Fields
        /// 

        public int ProductId { get; set; }
        public string ProductDescription { get; set; }

        public decimal? CurrentPrice { get; set; }
        private string _productName;
        public string ProductName
        {
            get
            {
                return _productName.InsertSpaces();
            }
            set
            {
                _productName = value;
            }
        }

        ///
        /* Methods */
        ///

        public override string ToString() => ProductName;

        public override bool Validate()
        {
            var isValid = true;
            // Code to validate
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;
            return isValid;
        }

        public string log() =>
            $"{ProductId}: {ProductName} Description: {ProductDescription} Status: {EntityState.ToString()}";
    }
}
