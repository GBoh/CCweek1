using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidateWithExceptions
{
    class Program
    {
        public static decimal CalculateTotalPriceWithTax(decimal price, decimal taxRate)
        {
            if (taxRate > 10 || taxRate <= 0)
            {
                throw new ArgumentOutOfRangeException("Tax Rate", "Your taxrate of " + taxRate + " is either above 10% or less than 0%");
            }

            if (price <= 0)
            {
                throw new ArgumentOutOfRangeException("Price", "Your product price cannot be $0.00 or less");
            }

            return Math.Round(price + (price * (taxRate / 100)), 2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CalculateTotalPriceWithTax(1.89m, 5m));
            Console.ReadLine();
        }
    }
}
