using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateProd
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsStock { get; set; }

        public Product(string name, double price, bool isStock)
        {
            Name = name;
            Price = price;
            IsStock = isStock;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}, IsStock: {IsStock}";
        }
    }
}
