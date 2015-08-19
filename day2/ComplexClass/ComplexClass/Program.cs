using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexClass
{
    class Account
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public decimal Amount { get; set; }
        public bool IsOpen { get; set; }
    }

    class Customer
    {
        public Customer()
        {
            this.Checking = new Account();
            this.Savings = new Account();
        }

        public string Name { get; set; }

        //Checking Account
        public Account Checking { get; set; }

        //Savings Account
        public Account Savings { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer
            {
                //sets name
                Name = "Alice",

                //sets checking account
                Checking =
                {
                    Id=1234,
                    Amount=100.00m,
                    Type="Checking",
                    IsOpen = true
                },

                //sets Savings account
                Savings =
                {
                    Id=4321,
                    Amount=0m,
                    Type="Savings",
                    IsOpen = false
                }

            };

            Console.WriteLine(customer.Name + " has {0:C} in account {1} ", customer.Checking.Amount, customer.Checking.Type);
            Console.ReadLine();
        }
    }
}
