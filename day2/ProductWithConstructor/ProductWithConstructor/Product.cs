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

        public Product(string name, decimal price, int stock, string description = "NO DESCRIPTION")
        {
            Name = name;
            Price = price;
            Stock = stock;
            Description = description;
        }
    }
}
