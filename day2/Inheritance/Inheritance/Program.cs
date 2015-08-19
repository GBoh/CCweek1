using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{

    //abstract employee class that has the elements all other kinds of employee will have
    abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //method to format first and last name as one string
        public string ShowFullName()
        {
            return String.Format("{0} {1}", FirstName, LastName);
        }
    }

    //full time gets its base from abstract and adds YearsEmployed
    class FullTimeEmployee : Employee
    {
        public int YearsEmployed { get; set; }
    }

    //part time get its base from abstract and adds MonthsEmployed
    class PartTimeEmployee : Employee
    {
        public int MonthsEmployed { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //add employee 1 to full time employee
            var employee1 = new FullTimeEmployee
            {
                FirstName = "Bill",
                LastName = "Gates",
                YearsEmployed = 5
            };
            //checks to ensure is true
            Debug.Assert(employee1.ShowFullName() == "Bill Gates");
            Debug.Assert(employee1.YearsEmployed == 5);


            //add employee 2 to part time employee
            var employee2 = new PartTimeEmployee
            {
                FirstName = "Steve",
                LastName = "Jobs",
                MonthsEmployed = 2
            };
            //checks to ensure is true
            Debug.Assert(employee2.ShowFullName() == "Steve Jobs");
            Debug.Assert(employee2.MonthsEmployed == 2);
        }
    }
}
