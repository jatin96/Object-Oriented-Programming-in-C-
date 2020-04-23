using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            if (productId == 2)
            {
                product.ProductName = "Azure";
                product.Description = "Cloud storage by Microsoft";
                product.CurrentPrice = 19.2M;
            }
            return product;
        }
        public bool save(Customer customer)
        {
            return true;
        }
    }
}
