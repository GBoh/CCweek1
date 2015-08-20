using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidCustomerClass
{
    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }



    class Program
    {
        public static void testValidation(string firstName, string lastName)
        {
            if (firstName == null || lastName == null)
            {
                throw new NullReferenceException();
            }
        }

        static void Main(string[] args)
        {
            var customer1 = new Customer();
            customer1.FirstName = "Bill";
            customer1.LastName = "Gates";
            //Console.WriteLine(customer1.FirstName);
            testValidation(customer1.FirstName, customer1.LastName);
            //Console.ReadLine();
        }
    }
}
