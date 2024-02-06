using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class ProductBl
    {
        ProductDetails productDetails = new ProductDetails();

        public List<Product> GetListForDb()
        {
            return productDetails.GetListOfProduct();
        }
    }
}
