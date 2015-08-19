using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductWithConstructor
{
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }

        public Product(string name, decimal? price, int? inStock,  string description)
        {
            if(name != null && price.HasValue && inStock.HasValue)
            {
                Console.WriteLine("you have met the 3 minimum requirements");
                Console.WriteLine("The item {0} costs {1} and there are {2} left:\n{3}", name, price, inStock, description);
            }
            else
            {
                Console.WriteLine("You are missing a requirment");
            }
        }
    }
}
