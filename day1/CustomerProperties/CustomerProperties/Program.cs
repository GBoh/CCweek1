using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer1 = new customer
            {
                FirstName = "Sally",
                LastName = "Williams",
                Age = 23,
                Birthday = DateTime.Parse("01/01/2028")
            };

            var customer2 = new customer
            {
                FirstName = "Mike",
                LastName = "Harrison",
                Age = 10, //default 10, test with negative age
                Birthday = DateTime.Parse("01/01/2019")
            };

            //var customer3 = new customer
            //{
            //    firstName = Console.ReadLine(),
            //    lastName = Console.ReadLine(),
            //    age = int.Parse(Console.ReadLine()),
            //    birthday = int.Parse(Console.ReadLine())
            //};

            Console.WriteLine("Customer {0} {1} is {2} years old and was born in year {3}", customer2.FirstName, customer2.LastName, customer2.Age, customer2.Birthday);

            Debug.Assert(customer1.Age == 23, "Sally is 23.");
            //Debug.Assert(customer2.age == 10, "Mike is 10.");
            //Console.WriteLine("Thank you for joining {0} {1}", customer3.firstName, customer3.lastName);
            Console.ReadLine();
        }
    }
}
