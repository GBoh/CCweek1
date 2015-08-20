using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLookupWithDictionary
{
    class Product
    {
        public int Id;
        public string Name;
        public decimal Price;
    }

    public class ProductCatalog
    {
        Dictionary<int, Product> catalog = new Dictionary<int, Product>();
        public string LookupId(int id)
        {
            return catalog[id].Name;
        }

        public ProductCatalog()
        {
            catalog.Add(9875, new Product
            {
                Id = 9875,
                Name = "Salad",
                Price = 15.00m
            });

            catalog.Add(1234, new Product
            {
                Id = 1234,
                Name = "Water",
                Price = 5.00m
            });


            catalog.Add(4321, new Product
            {
                Id = 4321,
                Name = "Soda",
                Price = 0.99m
            });
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var catalog = new ProductCatalog();
            Console.WriteLine(catalog.LookupId(1234));
            Console.ReadLine();
        }
    }
}
