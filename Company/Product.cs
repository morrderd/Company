using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Product
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; private set; }
        public Decimal? ActualPrice { get; set; }
        public string Description { get; set; }
        public string ProductName { get; set; }
        
    }
}
