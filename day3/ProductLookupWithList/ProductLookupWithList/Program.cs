using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLookupWithList
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class ProductCatalog
    {
        public int LookupId(int id)
        {
            foreach (var product in catalog)
            {
                Console.WriteLine(product.Id);
                if (id == product.Id)
                {
                    Console.WriteLine(product.Id);
                    return product.Id;
                }
            }
            return id;
        }


        internal List<Product> catalog = new List<Product>();
        public ProductCatalog()
        {
            catalog.Add(new Product
            {
                Id = 6936,
                Name = "Shoes",
                Price = 7.00m
            });
            catalog.Add(new Product
            {
                Id = 1234,
                Name = "hats",
                Price = 5.00m
            });

            catalog.Add(new Product
            {
                Id = 6548,
                Name = "Pants",
                Price = 2.00m
            });

            catalog.Add(new Product
            {
                Id = 9875,
                Name = "Shirts",
                Price = 89.00m
            });
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var catalog = new ProductCatalog();
            Debug.Assert(catalog.LookupId(1234) == 1234);
        }
    }
}
