using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string ShowFullName()
        {
            return String.Format("{0} {1}", FirstName, LastName);
        }
    }

    class FullTimeEmployee : Employee
    {
        public int YearsEmployed { get; set; }
    }

    class PartTimeEmployee : Employee
    {
        public int MonthsEmployed { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var employee1 = new FullTimeEmployee
            {
                FirstName = "Bill",
                LastName = "Gates",
                YearsEmployed = 5
            };

            Debug.Assert(employee1.ShowFullName() == "Bill Gates");
            var employee2 = new PartTimeEmployee
            {
                FirstName = "Steve",
                LastName = "Jobs",
                MonthsEmployed = 2
            };

            Debug.Assert(employee2.ShowFullName() == "Steve Jobs");

        }
    }
}
