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

            Console.WriteLine("The product {0} costs {2:C}, there are {3} left in stock. This product is {1}", item1.Name, item1.Description, item1.Price, item1.Stock);

            Console.WriteLine("Which property would you like to edit?");
            var type = Console.ReadLine();
            switch (type)
            {
                case "name":
                    Console.WriteLine("Enter new " + type);
                    item1.Name = Console.ReadLine();
                    break;

                case "price":
                    Console.WriteLine("Enter new " + type);
                    item1.Price = decimal.Parse(Console.ReadLine());
                    break;

                case "stock":
                    Console.WriteLine("Enter new " + type);
                    item1.Stock = int.Parse(Console.ReadLine());
                    break;

                case "description":
                    Console.WriteLine("Enter new " + type);
                    item1.Description = Console.ReadLine();
                    break;
                default:
                    break;
            }
            Console.WriteLine("The product {0} costs {2:C}, there are {3} left in stock. This product is {1}", item1.Name, item1.Description, item1.Price, item1.Stock);
            Console.ReadLine();
        }
    }
}
