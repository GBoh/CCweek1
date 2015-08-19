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
            Console.WriteLine("Please input name of poduct, price, and stock ammount. Description Optional");
            var item1 = new Product(
                Console.ReadLine(),
                decimal.Parse(Console.ReadLine()),
                int.Parse(Console.ReadLine()),
                Console.ReadLine()
                );

        }
    }
}
