using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateProd
{
    public delegate bool ProductFilter(Product product);
    internal class ProductService
    {
         public List<Product> Products { get; set; }

        public ProductService()
        {
            Products = new List<Product>
            {
                new Product("Product1", 10.0, true),
                new Product("Product2", 20.0, false),
                new Product("Product3", 30.0, true),
                new Product("Product4", 40.0, false),
                new Product("Product5", 50.0, true)
            };
        }

        public void FilterProducts(ProductFilter filter)
        {
            foreach (var product in Products)
            {
                if (filter!= null && filter(product))
                {
                    Console.WriteLine(product.ToString());
                }
            }
        }
    }
}
