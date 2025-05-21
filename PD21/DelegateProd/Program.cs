using System.Threading.Channels;

namespace DelegateProd
{
    internal class Program
    {
        public static bool IsStock(Product product)
        {
            Console.WriteLine("Метод 1");
            return product.IsStock == true;
        }

        static void Main(string[] args)
        {
           var productService = new ProductService();
            
            Console.WriteLine("Products in stock:");
            productService.FilterProducts(IsStock);

            Console.WriteLine("\nProducts with price greater than 20:");

            productService.FilterProducts(p => p.Price > 20);

           // string input = "7685r9iygi";
           // input += "!!!!!!!";
           // input += "???????";
           // input = "000000000";

           // ProductFilter filter = IsStock;
           // filter += p => {Console.WriteLine("Метод 2"); return true; };

           //// filter -= p => { Console.WriteLine("Метод 2"); return true; };

           // filter = null;
            

            
           // //filter(new Product("Product1", 10.0, true));
           // filter?.Invoke(new Product("Product1", 10.0, true));


        }
    }
}
