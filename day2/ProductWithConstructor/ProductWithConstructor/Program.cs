using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductWithConstructor
{

    class Program
    {
        static void Main(string[] args)
        {
            var item1 = new Product("Chocolate", 0.99m, 5);

            Console.WriteLine("The product {0} which is {1} costs {2:C} there are {3} left in stock", item1.Name, item1.Description, item1.Price, item1.Stock);
            Console.WriteLine("Would you like to add a description?");
            if (Console.ReadLine() == "yes")
            {
                Console.WriteLine("Enter description");
                item1.Description = Console.ReadLine();
                Console.WriteLine("The product {0} which is {1} costs {2:C} there are {3} left in stock", item1.Name, item1.Description, item1.Price, item1.Stock);
            }
            else
            {
                Console.WriteLine("Thank you");
            }
            Console.ReadLine();
        }
    }
}
