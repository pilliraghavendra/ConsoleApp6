using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ProductDetails
    {
        List<Product> products = new List<Product>();

        public List<Product> GetListOfProduct()
        {
            products.Add(new Product() { Name="Apple", Category="Fruit", Description = "Item1", Prize = 10});
            products.Add(new Product() { Name = "Mango", Category = "Fruit", Description = "Item2", Prize = 20 });
            products.Add(new Product() { Name = "Pomgranate", Category = "Fruit", Description = "Item3", Prize = 5 });

            return products;
        }
    }
}
